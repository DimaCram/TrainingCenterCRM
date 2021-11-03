import { DatePipe } from "@angular/common";
import { Component } from "@angular/core";
import { FormArray, FormBuilder, FormControl, FormGroup, Validators } from "@angular/forms";
import { Title } from "@angular/platform-browser";
import { ActivatedRoute, Router } from "@angular/router";
import { group } from "console";
import { ToastService } from "src/app/components/toast/toast.service";
import { File } from "src/app/models/file.model";
import { Group } from "src/app/models/group.model";
import { Material } from "src/app/models/metirial.model";
import { GroupService } from "src/app/services/group.service";
import { MaterialService } from "src/app/services/material.service";

@Component({
    selector: 'teacher-material-edit',
    templateUrl: './material-edit.component.html',
})
export class MaterialEditComponent {
    form: FormGroup;
    selectedGroupId: number;
    materialId: number;
    materialTypes: string[] = [];
    group: Group;
    filesForGroup: File[] = [];

    fileLengthError:string = "";
    groupError: string;

    constructor(private fb: FormBuilder,
                private route: ActivatedRoute,
                private router: Router,
                private titleService: Title,
                private groupService: GroupService,
                private materialService: MaterialService,
                private toastService: ToastService)
                {
                    this.materialId = this.route.snapshot.params['id'];
                }

    ngOnInit(): void {
        this.titleService.setTitle("Edit material - Training Center")

        if (this.materialId) {
            this.materialService.getMaterial(this.materialId).subscribe(res => {
              this.form.patchValue(res);
            });
        }


        this.form = this.fb.group({
            name: ['', Validators.required],
            materialType: ['', Validators.required],
            fileIds: new FormArray([]),
        });


        this.materialService.getMaterialTypes().subscribe(res => {
            this.materialTypes = res;
        })

        this.route.queryParams.subscribe(params => {
            const groupId = +params['groupId'];

            this.groupService.hasAccessToGroup(groupId).subscribe(hasAccess => {
                if(hasAccess)
                    this.getGroup(+params['groupId'])
                else
                    this.router.navigate(['/error', 401]);
            })
        });

    }


    onCheckChange(event) {
        const formArray: FormArray = this.form.get('fileIds') as FormArray;

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

    getFilesForGroup(){
        if(this.group){
            this.materialService.getFilesForGroup(this.group.courseId, this.materialId).subscribe(res => {
                this.filesForGroup = res;

                const formArray: FormArray = this.form.get('fileIds') as FormArray;

                this.filesForGroup.forEach(file => {
                    if(file.hasMaterial)
                        formArray.push(new FormControl(file.id));
                });
            })
        }
    }

    getGroup(groupId: number){
        this.groupService.getGroup(groupId).subscribe(res =>{
            this.group = res;
            this.getFilesForGroup();
        })
    }

    onSubmit(){
        if(this.form.value.fileIds.length === 0)
        {
            this.fileLengthError = "Select minimum one file";
            return;
        }
        if(!this.group.id){
            this.groupError = "Group not found";
            return;
        }

        let material = new Material();

        if(this.materialId)
            material.id = +this.materialId;

        material.name = this.form.value.name;
        material.materialType = this.form.value.materialType;
        material.groupId = +this.group.id;
        material.files = [];

        this.form.value.fileIds.forEach(id => {
            let file = new File();
            file.id = +id;
            material.files.push(file);
        });

        this.materialService.egitMaterial(material).subscribe(result => {
            if(this.materialId)
            {
                this.toastService.showSuccess("Material edited");
            }
            else
            {
                this.toastService.showSuccess("Material added");
            }
            this.router.navigate(['/teacher/groupControl'], { relativeTo: this.route, queryParams : {groupId: this.group.id} });
        })
    }
}