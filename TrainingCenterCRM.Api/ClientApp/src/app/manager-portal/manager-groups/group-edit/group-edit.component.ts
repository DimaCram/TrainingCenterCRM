import { Component } from "@angular/core";
import { FormBuilder, FormGroup, Validators } from "@angular/forms";
import { ActivatedRoute, Router } from "@angular/router";
import { Student } from "src/app/models/student.model";
import { CourseService } from "src/app/services/courses.service";
import { GroupService } from "src/app/services/group.service";
import { TeacherService } from "src/app/services/teacher.service";

@Component({
    selector: 'manager-group-edit',
    templateUrl: './group-edit.component.html',
})
export class GroupEditComponent {

    form: FormGroup;
    id: number;

    studentsForCourse: Student[];

    constructor(private fb: FormBuilder,
              private groupSevice: GroupService,
              private route: ActivatedRoute,
              private router: Router,
              private courseService: CourseService,
              private teacherService: TeacherService
              ){
                this.id = this.route.snapshot.params['id'];
              }

    ngOnInit(): void {
        this.form = this.fb.group({
            name: ['', Validators.required],
            startDate: ['', Validators.required],
            status: ['', [Validators.required]],
            teacherId: [''],
            courseId: ['', Validators.required]
        });

    }

    onSubmit(): void{

    }

    getStudentForCourse(courseId){

    }
}