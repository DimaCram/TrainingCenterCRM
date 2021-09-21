import { NgModule } from "@angular/core";
import { FormsModule, ReactiveFormsModule } from "@angular/forms";
import { BrowserModule } from "@angular/platform-browser";
import { RouterModule } from "@angular/router";
import { DndDirective } from "src/app/directives/drag-and-drop.directive";
import { CourseAllComponent } from "../manager-courses/course-all/course-all.component";
import { CourseEditComponent } from "../manager-courses/course-edit/course-edit.component";
import { StudentsAllComponent } from "../manager-students/students-all/students-all.component";
import { StudentsEditComponent } from "../manager-students/students-edit/students-edit.component";
import { TopicAllComponent } from "../manager-topics/topic-all/topic-all.component";
import { TopicEditComponent } from "../manager-topics/topic-edit/topic-edit.component";
import { ManagerMainComponent } from "./manager-main.component";

@NgModule({
    imports:      [ BrowserModule, FormsModule, RouterModule, ReactiveFormsModule ],
    declarations:
    [
        ManagerMainComponent,
        StudentsAllComponent,
        StudentsEditComponent,
        CourseAllComponent,
        CourseEditComponent,
        TopicAllComponent,
        TopicEditComponent,
        DndDirective
    ],
    exports: [ ManagerMainComponent]
})
export class ManagerMainModule { }