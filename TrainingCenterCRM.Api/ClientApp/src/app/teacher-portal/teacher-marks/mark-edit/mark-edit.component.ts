import { HttpClient } from "@angular/common/http";
import { Component, ElementRef, Inject, ViewChild } from "@angular/core";
import { FormBuilder, FormGroup, Validators } from "@angular/forms";
import { Title } from "@angular/platform-browser";
import { ActivatedRoute, Router } from "@angular/router";
import { ToastService } from "src/app/components/toast/toast.service";
import { Course } from "src/app/models/course.model";
import { Material } from "src/app/models/metirial.model";
import { StudentMark } from "src/app/models/student-mark.model";
import { Student } from "src/app/models/student.model";
import { Topic } from "src/app/models/topic.model";
import { CourseService } from "src/app/services/courses.service";
import { MaterialService } from "src/app/services/material.service";
import { StudentMarkService } from "src/app/services/student-mark.service";
import { StudentService } from "src/app/services/student.service";
import { TopicService } from "src/app/services/topic.service";

@Component({
    selector: 'teacher-mark-edit',
    templateUrl: './mark-edit.component.html'
})

export class MarkEditComponent{

    form: FormGroup;
    id: number;
    student: Student;
    materials: Material[];
    groupId: number;

    constructor(private fb: FormBuilder,
                private studentService: StudentService,
                private studentMarkService: StudentMarkService,
                private materialService: MaterialService,
                private route: ActivatedRoute,
                private router: Router,
                private titleService: Title,
                private toastService: ToastService)
                {
                    this.id = +this.route.snapshot.params['id'];
                }


    ngOnInit(): void {
        this.titleService.setTitle("Edit course - Training Center")

        if (this.id) {
            this.studentMarkService.getMark(this.id).subscribe(res => {
                                        this.form.patchValue(res);
            });
        }

        const studentId = +this.route.snapshot.queryParams['studentId'];
        this.studentService.getStudent(studentId).subscribe(res => this.student = res)

        this.groupId = +this.route.snapshot.queryParams['groupId'];
        this.materialService.getMaterialsByGroup(this.groupId).subscribe(res => this.materials = res);
        console.log(this.groupId)

        this.form = this.fb.group({
            mark: ['', Validators.required],
            comment: [''],
            materialId: ['', Validators.required]
        });
    }

    onSubmit(){
        let mark = new StudentMark();
        if(this.id)
            mark.id = this.id

        mark.mark = +this.form.value.mark;
        mark.comment = this.form.value.comment;
        mark.studentId = this.student.id;
        mark.materialId = +this.form.value.materialId;

        this.studentMarkService.editMark(mark).subscribe(result => {
            if(this.id)
            {
                this.toastService.showSuccess("Mark edited");
            }
            else
            {
              this.toastService.showSuccess("Mark added");
            }
            console.log({groupId: this.groupId})
            this.router.navigate(['teacher/groupControl'],  { queryParams: {groupId: this.groupId}})
        });
    }
}