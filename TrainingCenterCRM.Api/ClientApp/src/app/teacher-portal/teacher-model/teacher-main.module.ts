import { NgModule } from "@angular/core";
import { FormsModule, ReactiveFormsModule } from "@angular/forms";
import { BrowserModule } from "@angular/platform-browser";
import { RouterModule } from "@angular/router";
import { DndDirective } from "src/app/directives/drag-and-drop.directive";
import { NavMenuComponent } from "src/app/nav-menu/nav-menu.component";
import { NavMenuMainModule } from "src/app/nav-menu/nav-menu.module";
import { TeacherMainComponent } from "./teacher-main.component";

@NgModule({
    imports:      [ BrowserModule, FormsModule, RouterModule, ReactiveFormsModule, NavMenuMainModule ],
    declarations:
    [
        TeacherMainComponent,
    ],
    exports: [ TeacherMainComponent ]
})
export class TeacherMainModule { }