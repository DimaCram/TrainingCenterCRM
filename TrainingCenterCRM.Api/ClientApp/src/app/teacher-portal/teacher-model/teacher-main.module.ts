import { NgModule } from "@angular/core";
import { FormsModule, ReactiveFormsModule } from "@angular/forms";
import { BrowserModule } from "@angular/platform-browser";
import { RouterModule } from "@angular/router";
import { NgbModule } from "@ng-bootstrap/ng-bootstrap";
import { DndDirective } from "src/app/directives/drag-and-drop.directive";
import { NavMenuComponent } from "src/app/nav-menu/nav-menu.component";
import { SharedModule } from "src/app/shared.module";
import { GroupControlComponent } from "../teacher-groups/group-control/group-control.component";
import { TeacherGroupsComponent } from "../teacher-groups/teacher-groups.component";
import { MaterialAllComponent } from "../teacher-materials/material-all/material-all.component";
import { MaterialEditComponent } from "../teacher-materials/material-edit/material-edit.component";
import { MaterialFileAddComponent } from "../teacher-materials/material-file-add/material-file-add.component";
import { TeacherMainComponent } from "./teacher-main.component";

@NgModule({
    imports:
    [
        BrowserModule,
        FormsModule,
        RouterModule,
        ReactiveFormsModule,
        SharedModule,
        NgbModule
    ],
    declarations:
    [
        TeacherMainComponent,
        MaterialAllComponent,
        MaterialFileAddComponent,
        MaterialEditComponent,
        TeacherGroupsComponent,
        GroupControlComponent
    ],
    exports: [ TeacherMainComponent ]
})
export class TeacherMainModule { }