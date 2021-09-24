import { DatePipe } from "@angular/common";
import { Component } from "@angular/core";
import { FormBuilder, FormGroup, Validators } from "@angular/forms";
import { ActivatedRoute, Router } from "@angular/router";
import { Course } from "src/app/models/course.model";
import { Request } from "src/app/models/request.model";
import { Student } from "src/app/models/student.model";
import { CourseService } from "src/app/services/courses.service";
import { RequestService } from "src/app/services/request.service";
import { StudentService } from "src/app/services/student.service";

@Component({
    selector: 'app-request-edit',
    templateUrl: './request-edit.component.html',
})
export class RequestEditComponent {
    requestId: number;
    student: Student = new Student();
    courses: Course[];
    requestStatuses: string[];

    form: FormGroup;

    constructor(private fb: FormBuilder,
                private datePipe: DatePipe,
                private requestSevice: RequestService,
                private studentService: StudentService,
                private courseService: CourseService,
                private route: ActivatedRoute,
                private router: Router){}


    ngOnInit(): void {
        this.route.queryParams.subscribe(params => {
            this.student.id = params['studentId'];
            this.requestId = this.route.snapshot.params['id'];

            if (this.requestId) {
                this.requestSevice.getRequest(this.requestId).subscribe(res => {
                    this.form.patchValue(res)
                    this.form.get('readyToStartDate').setValue(this.datePipe.transform(res.readyToStartDate,"yyyy-MM-dd"));
                });
            }

            this.studentService.getStudent(this.student.id).subscribe(res => {
                this.student = res;
            });
        });

        this.requestSevice.getRequestStatuses().subscribe(res => {
            this.requestStatuses = res;
        });

        this.courseService.getCourses().subscribe(res => {
            this.courses = res;
        });


        this.form = this.fb.group({
            readyToStartDate: ['', Validators.required],
            comments: [''],
            courseId: ['', Validators.required],
            status: ['', Validators.required]
        });

    }

    onSubmit(){
      this.editRequest();
    }


    editRequest(): void{
      let request : Request = new Request();

      if(this.requestId)
        request.id = +this.requestId;

      request.readyToStartDate = this.form.value.readyToStartDate;
      request.comments = this.form.value.comments;
      request.courseId = +this.form.value.courseId;
      request.studentId = +this.student.id;
      request.status = this.form.value.status;

      this.requestSevice.egitRequest(request).subscribe(result => {
            if(this.requestId)
                this.router.navigate(['../../'], { relativeTo: this.route });
            else
                this.router.navigate(['../'], { relativeTo: this.route });

      },
      error => {console.error(error);});
    }
  }