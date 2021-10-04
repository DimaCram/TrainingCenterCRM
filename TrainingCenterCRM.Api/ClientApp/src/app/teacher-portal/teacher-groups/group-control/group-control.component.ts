import { Component } from "@angular/core";
import { ActivatedRoute } from "@angular/router";
import { Student } from "src/app/models/student.model";
import { StudentService } from "src/app/services/student.service";

@Component({
    selector: 'group-control',
    templateUrl: './group-control.component.html'
})

export class GroupControlComponent{
    groupStudents: Student[] = [];
    groupId: number;

    public page = 1;
    public pageSize = 5;

    constructor(private studentService: StudentService,
                private route: ActivatedRoute){}
    ngOnInit(): void {
        this.route.queryParams.subscribe(params => {
            this.groupId = params['groupId'];

            this.studentService.getStudentsByGroup(this.groupId).subscribe(res => {
                this.groupStudents = res;
                console.log(res);
            })
        });
    }
}