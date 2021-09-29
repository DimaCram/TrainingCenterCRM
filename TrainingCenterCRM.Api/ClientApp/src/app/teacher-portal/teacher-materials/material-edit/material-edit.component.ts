import { Component } from "@angular/core";
import { FormBuilder, FormGroup, Validators } from "@angular/forms";
import { Title } from "@angular/platform-browser";
import { ActivatedRoute, Router } from "@angular/router";
import { Group } from "src/app/models/group.model";
import { GroupService } from "src/app/services/group.service";
import { MaterialService } from "src/app/services/material.service";

@Component({
    selector: 'teacher-material-edit',
    templateUrl: './material-edit.component.html',
})
export class MaterialEditComponent {
    form: FormGroup;
    groupId: number;
    materialTypes: string[] = [];
    groups: Group[];

    constructor(private fb: FormBuilder,
                private route: ActivatedRoute,
                private router: Router,
                private titleService: Title,
                private groupService: GroupService,
                private materialService: MaterialService)
                {
                    this.groupId = this.route.snapshot.params['id'];
                }

    ngOnInit(): void {
        this.titleService.setTitle("Edit material - Training Center")

        
        this.form = this.fb.group({
            name: ['', Validators.required],
            materialType: ['', Validators.required],
            groupId: ['', [Validators.required]],
            teacherId: [''],
            courseId: ['', Validators.required],
        });

        this.groupService.getGroups().subscribe(res =>{
            this.groups = res;
        })

        this.materialService.getMaterialTypes().subscribe(res => {
            this.materialTypes = res;
        })
    }
}