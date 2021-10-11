import { Component } from "@angular/core";
import { Title } from "@angular/platform-browser";
import { Router } from "@angular/router";
import { NgxUiLoaderService } from "ngx-ui-loader";
import { Material } from "src/app/models/metirial.model";
import { Topic } from "src/app/models/topic.model";
import { MaterialService } from "src/app/services/material.service";
import { TopicService } from "src/app/services/topic.service";

@Component({
    selector: 'teacher-material-all',
    templateUrl: './material-all.component.html',
  })
  export class MaterialAllComponent {
    public materials: Material[] = [];
    public page = 1;
    public pageSize = 5;

    constructor(private materialSerive : MaterialService,
                private titleService: Title,
                private ngxService: NgxUiLoaderService){}

    ngOnInit(): void {
      this.titleService.setTitle("Materials - Training Center")

      this.ngxService.startLoader("loader");
      this.materialSerive.getMaterials().subscribe(result => {
        this.materials = result;
      });
    }


    deleteTopic(id: number):void{
        this.materialSerive.deleteMaterial(id).subscribe(result => {
            const removeIndex = this.materials.findIndex( item => item.id === id );
            this.materials.splice( removeIndex, 1 );
          });
    }
  }