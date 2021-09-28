import { DatePipe } from "@angular/common";
import { Component } from "@angular/core";
import { FormArray, FormBuilder, FormControl, FormGroup, Validators } from "@angular/forms";
import { Title } from "@angular/platform-browser";
import { ActivatedRoute, Router } from "@angular/router";
import { Course } from "src/app/models/course.model";
import { Group } from "src/app/models/group.model";
import { Student } from "src/app/models/student.model";
import { Teacher } from "src/app/models/teacher.model";
import { CourseService } from "src/app/services/courses.service";
import { GroupService } from "src/app/services/group.service";
import { StudentService } from "src/app/services/student.service";
import { TeacherService } from "src/app/services/teacher.service";

@Component({
    selector: 'manager-group-edit',
    templateUrl: './group-edit.component.html',
})
export class GroupEditComponent {

    form: FormGroup;
    groupId: number;
    courses: Course[];
    teachers: Teacher[];
    groupStatuses: string[];

    studentsForCourse: Student[] = [];

    constructor(private fb: FormBuilder,
              private groupService: GroupService,
              private route: ActivatedRoute,
              private router: Router,
              private courseService: CourseService,
              private teacherService: TeacherService,
              private studentService: StudentService,
              private datePipe: DatePipe,
              private titleService: Title
              ){
                this.groupId = this.route.snapshot.params['id'];
              }

    ngOnInit(): void {
        this.titleService.setTitle("Edit group - Training Center")

        if (this.groupId) {
            this.groupService.getGroup(this.groupId).subscribe(res => {

              this.form.patchValue(res);
              this.form.get('startDate').setValue(this.datePipe.transform(res.startDate,"yyyy-MM-dd"));

              this.getStudentForCourse(res.courseId.toString());
            });
        }

        this.form = this.fb.group({
            name: ['', Validators.required],
            startDate: ['', Validators.required],
            status: ['', [Validators.required]],
            teacherId: [''],
            courseId: ['', Validators.required],
            studentIds: new FormArray([]),
        });

        this.teacherService.getTeachers().subscribe(res => {
            this.teachers = res;
        }, error => {console.error(error);});

        this.courseService.getCourses().subscribe(res => {
            this.courses = res;
        }, error => {console.error(error);});

        this.groupService.getGroupStatuses().subscribe(res => {
            this.groupStatuses = res;
        }, error => {console.error(error);});
    }

    onCheckChange(event) {
        const formArray: FormArray = this.form.get('studentIds') as FormArray;

        if(event.target.checked){
          formArray.push(new FormControl(event.target.value));
        }
        else{
          let i: number = 0;

          formArray.controls.forEach((ctrl: FormControl) => {
            if(ctrl.value == event.target.value) {
              formArray.removeAt(i);
              return;
            }
            i++;
          });
        }
    }

    getStudentForCourse(courseId : string){
        this.studentService.getStudentsForGroupByCourse(courseId, this.groupId).subscribe(res => {
            this.studentsForCourse = res;

            const formArray: FormArray = this.form.get('studentIds') as FormArray;

            this.studentsForCourse.forEach(student => {
                if(student.hasGroup)
                    formArray.push(new FormControl(student.id));
            });
        })
    }

    onSubmit(): void{
        this.editGroup();
    }

    editGroup(){
        let group : Group = new Group();

        if(this.groupId)
            group.id = +this.groupId;

        group.name = this.form.value.name;
        group.startDate = this.form.value.startDate;
        group.groupStatus = this.form.value.status;
        group.teacherId = +this.form.value.teacherId;
        group.courseId = +this.form.value.courseId;
        group.students = [];

        this.form.value.studentIds.forEach(id => {
            let student = new Student();
            student.id = +id;
            group.students.push(student);
        });

        this.groupService.egitGroup(group).subscribe(result => {
            if(this.groupId)
                this.router.navigate(['../../'], { relativeTo: this.route });
            else
                this.router.navigate(['../'], { relativeTo: this.route });
        },
        error => {console.error(error);});
    }
}