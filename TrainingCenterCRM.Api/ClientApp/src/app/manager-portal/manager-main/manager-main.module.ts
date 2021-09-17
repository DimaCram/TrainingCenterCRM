import { NgModule } from "@angular/core";
import { FormsModule } from "@angular/forms";
import { BrowserModule } from "@angular/platform-browser";
import { RouterModule } from "@angular/router";
import { StudentsAllComponent } from "../manager-students/students-all/students-all.component";
import { StudentsEditComponent } from "../manager-students/students-edit/students-edit.component";
import { ManagerMainComponent } from "./manager-main.component";

@NgModule({
    imports:      [ BrowserModule, FormsModule, RouterModule ],
    declarations: [ ManagerMainComponent, StudentsAllComponent, StudentsEditComponent],
    exports: [ ManagerMainComponent]
})
export class ManagerMainModule { }