import { DatePipe } from "@angular/common";
import { Component } from "@angular/core";
import { FormArray, FormBuilder, FormControl, FormGroup, Validators } from "@angular/forms";
import { Title } from "@angular/platform-browser";
import { ActivatedRoute, Router } from "@angular/router";
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
    groups: Group[];
    filesForGroup: File[] = [];
    fileLengthError:string = "";

    constructor(private fb: FormBuilder,
                private route: ActivatedRoute,
                private router: Router,
                private titleService: Title,
                private groupService: GroupService,
                private materialService: MaterialService)
                {
                    this.materialId = this.route.snapshot.params['id'];
                }

    ngOnInit(): void {
        this.titleService.setTitle("Edit material - Training Center")

        if (this.materialId) {
            this.materialService.getMaterial(this.materialId).subscribe(res => {
              this.form.patchValue(res);
              this.selectedGroupId = res.groupId;

              this.getGroups();
            });
        }
        else{
            this.getGroups();
        }


        this.form = this.fb.group({
            name: ['', Validators.required],
            materialType: ['', Validators.required],
            groupId: ['', [Validators.required]],
            fileIds: new FormArray([]),
        });


        this.materialService.getMaterialTypes().subscribe(res => {
            this.materialTypes = res;
        })
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

    getFilesForGroup(groupId: number){
        let group = this.groups.find(g => g.id == groupId);
        if(group){
            this.materialService.getFilesForGroup(group.courseId, this.materialId).subscribe(res => {
                this.filesForGroup = res;

                const formArray: FormArray = this.form.get('fileIds') as FormArray;

                this.filesForGroup.forEach(file => {
                    if(file.hasMaterial)
                        formArray.push(new FormControl(file.id));
                });
            })
        }
    }

    getGroups(){
        this.groupService.getGroups().subscribe(res =>{
            this.groups = res;

            if(this.selectedGroupId)
                this.getFilesForGroup(this.selectedGroupId);
        })
    }

    onSubmit(){
        if(this.form.value.fileIds.length === 0)
        {
            this.fileLengthError = "Select minimum one file";
            return;
        }
        let material : Material = new Material();

        if(this.materialId)
            material.id = +this.materialId;

        material.name = this.form.value.name;
        material.materialType = this.form.value.materialType;
        material.groupId = +this.form.value.groupId;
        material.files = [];

        this.form.value.fileIds.forEach(id => {
            let file = new File();
            file.id = +id;
            material.files.push(file);
        });

        this.materialService.egitMaterial(material).subscribe(result => {
            if(this.materialId)
                this.router.navigate(['../../'], { relativeTo: this.route });
            else
                this.router.navigate(['../'], { relativeTo: this.route });
        })
    }

}