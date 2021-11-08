import { NgModule } from "@angular/core";
import { FormsModule, ReactiveFormsModule } from "@angular/forms";
import { BrowserModule } from "@angular/platform-browser";
import { RouterModule } from "@angular/router";
import { NgbModule } from "@ng-bootstrap/ng-bootstrap";
import { NgxUiLoaderModule } from "ngx-ui-loader";
import { DndDirective } from "src/app/directives/drag-and-drop.directive";
import { NavMenuComponent } from "src/app/nav-menu/nav-menu.component";
import { SharedModule } from "src/app/shared.module";
import { GroupControlComponent } from "../teacher-groups/group-control/group-control.component";
import { TeacherGroupsComponent } from "../teacher-groups/teacher-groups.component";
import { GroupMarksComponent } from "../teacher-marks/group-marks/group-marks.component";
import { MarkEditComponent } from "../teacher-marks/mark-edit/mark-edit.component";
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
        NgbModule,
        NgxUiLoaderModule
    ],
    declarations:
    [
        TeacherMainComponent,
        MaterialFileAddComponent,
        MaterialEditComponent,
        TeacherGroupsComponent,
        GroupControlComponent,
        MarkEditComponent,
        GroupMarksComponent
    ],
    exports: [ TeacherMainComponent ]
})
export class TeacherMainModule { }