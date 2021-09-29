import { NgModule } from "@angular/core";
import { FormsModule, ReactiveFormsModule } from "@angular/forms";
import { BrowserModule } from "@angular/platform-browser";
import { RouterModule } from "@angular/router";
import { NgbModule } from "@ng-bootstrap/ng-bootstrap";
import { DndDirective } from "src/app/directives/drag-and-drop.directive";
import { NavMenuComponent } from "src/app/nav-menu/nav-menu.component";
import { NavMenuMainModule } from "src/app/nav-menu/nav-menu.module";
import { MaterialAllComponent } from "../teacher-materials/material-all/material-all.component";
import { MaterialFileAddComponent } from "../teacher-materials/material-file-add/material-file-add.component";
import { TeacherMainComponent } from "./teacher-main.component";

@NgModule({
    imports:      [ BrowserModule, FormsModule, RouterModule, ReactiveFormsModule, NavMenuMainModule,
        NgbModule ],
    declarations:
    [
        TeacherMainComponent,
        MaterialAllComponent,
        MaterialFileAddComponent
    ],
    exports: [ TeacherMainComponent ]
})
export class TeacherMainModule { }