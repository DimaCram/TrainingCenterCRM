import { Component } from "@angular/core";
import { ActivatedRoute } from "@angular/router";
import { NgbModal } from "@ng-bootstrap/ng-bootstrap";
import { Material } from "src/app/models/metirial.model";
import { Student } from "src/app/models/student.model";
import { MaterialService } from "src/app/services/material.service";
import { StudentService } from "src/app/services/student.service";

@Component({
    selector: 'group-control',
    templateUrl: './group-control.component.html'
})

export class GroupControlComponent{
    groupStudents: Student[] = [];
    groupMaterials: Material[] = [];

    studentInfo: Student;
    groupId: number;

    public pageStudent = 1;
    public pageMaterial = 1;
    public pageSize = 5;

    constructor(private studentService: StudentService,
                private materialService: MaterialService,
                private modalService: NgbModal,
                private route: ActivatedRoute){}
                
    ngOnInit(): void {
        this.route.queryParams.subscribe(params => {
            this.groupId = params['groupId'];

            this.studentService.getStudentsByGroup(this.groupId).subscribe(res => {
                this.groupStudents = res;
            })
            
            this.materialService.getMaterialsByGroup(this.groupId).subscribe(res => {
                this.groupMaterials = res;
            })
        });
    }
    
    open(content: any, studentId: number) {
        let user = this.groupStudents.find(item => item.id == studentId);
        this.studentInfo = user;
        this.modalService.open(content, {ariaLabelledBy: 'modal-basic-title'});
    }
}