import { Component } from "@angular/core";
import { ActivatedRoute, Router } from "@angular/router";
import { NgbModal } from "@ng-bootstrap/ng-bootstrap";
import { NgxUiLoaderService } from "ngx-ui-loader";
import { ToastService } from "src/app/components/toast/toast.service";
import { Material } from "src/app/models/metirial.model";
import { Student } from "src/app/models/student.model";
import { GroupService } from "src/app/services/group.service";
import { MaterialService } from "src/app/services/material.service";
import { StudentService } from "src/app/services/student.service";

@Component({
    selector: 'group-control',
    templateUrl: './group-control.component.html'
})

export class GroupControlComponent{
    public filteredGroupStudents: Student[] = [];
    private groupStudents: Student[] = [];

    public filteredGroupMaterials: Material[] = [];
    private groupMaterials: Material[] = [];

    studentInfo: Student;
    groupId: number;

    public pageStudent = 1;
    public pageMaterial = 1;
    public pageSize = 5;

    constructor(private studentService: StudentService,
                private materialService: MaterialService,
                private groupService: GroupService,
                private modalService: NgbModal,
                private route: ActivatedRoute,
                private router: Router,
                private ngxService: NgxUiLoaderService,
                private toastService: ToastService)
                {
                    this.groupId = +this.route.snapshot.queryParams['groupId']
                    this.groupService.hasAccessToGroup(this.groupId).subscribe(hasAccess => {
                        if(!hasAccess)
                            this.router.navigate(['/error', 401]);
                    })
                }

    ngOnInit(): void {

        this.ngxService.startLoader("studentsLoader");
        this.ngxService.startLoader("materialsLoader");

        this.studentService.getStudentsByGroup(this.groupId).subscribe(res => {
            this.ngxService.stopLoader("studentsLoader");
            this.groupStudents = res;
            this.filteredGroupStudents = res;
        })

        this.materialService.getMaterialsByGroup(this.groupId).subscribe(res => {
            this.ngxService.stopLoader("materialsLoader");
            this.groupMaterials = res;
            this.filteredGroupMaterials = res;
        })
    }

    open(content: any, studentId: number) {
        let user = this.groupStudents.find(item => item.id == studentId);
        this.studentInfo = user;
        this.modalService.open(content, {ariaLabelledBy: 'modal-basic-title'});
    }

    deleteMaterial(id: number):void{
        this.materialService.deleteMaterial(id).subscribe(result => {
            const removeIndex = this.groupMaterials.findIndex( item => item.id === id );
            this.groupMaterials.splice( removeIndex, 1 );


            this.toastService.showSuccess("Material deleted");
        });
    }

    searchStudents(searchText: string){
        this.filteredGroupStudents = this.groupStudents.filter(student => {
          const term = searchText.toLowerCase();
          return student.name.toLowerCase().includes(term)
              || student.surname.toLowerCase().includes(term);
        });
    }

    searchMaterials(searchText: string){
        this.filteredGroupMaterials = this.groupMaterials.filter(material => {
          const term = searchText.toLowerCase();
          return material.name.toLowerCase().includes(term)
              || material.materialType.toLowerCase().includes(term);
        });
    }
}