import { Component } from "@angular/core";
import { ActivatedRoute, Router } from "@angular/router";
import { NgbModal } from "@ng-bootstrap/ng-bootstrap";
import { NgxUiLoaderService } from "ngx-ui-loader";
import { ToastService } from "src/app/components/toast/toast.service";
import { Material } from "src/app/models/metirial.model";
import { GroupService } from "src/app/services/group.service";
import { MaterialService } from "src/app/services/material.service";
import { saveAs } from 'file-saver';
import { Teacher } from "src/app/models/teacher.model";

@Component({
    selector: 'student-group',
    templateUrl: './student-group.component.html'
})

export class StudentGroupComponent{
    groupMaterials: Material[] = [];
    groupTeacher: Teacher;

    groupId: number;

    public pageStudent = 1;
    public pageMaterial = 1;
    public pageSize = 5;

    constructor(private materialService: MaterialService,
                private groupService: GroupService,
                private modalService: NgbModal,
                private route: ActivatedRoute,
                private router: Router,
                private ngxService: NgxUiLoaderService,
                private toastService: ToastService)
                {
                    this.groupId = +this.route.snapshot.queryParams['groupId']
                }

    ngOnInit(): void {

        this.ngxService.startLoader("materialsLoader");

        this.materialService.getMaterialsByGroup(this.groupId).subscribe(res => {
            this.ngxService.stopLoader("materialsLoader");
            this.groupMaterials = res;
        })

        this.ngxService.startLoader("teacherLoader");
        this.groupService.getGroupTeacher(this.groupId).subscribe(res => {
            this.ngxService.stopLoader("teacherLoader");
            this.groupTeacher = res;
        })
    }

    downloadMaterialFile(fileId: number, fileName: string){
    
        this.materialService.downloadFile(fileId).subscribe(result => {
            var blob = new Blob([result]);
            saveAs(blob, fileName);
        });
    }
}