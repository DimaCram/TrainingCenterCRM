import { NgModule } from "@angular/core";
import { FormsModule, ReactiveFormsModule } from "@angular/forms";
import { BrowserModule } from "@angular/platform-browser";
import { RouterModule } from "@angular/router";
import { NgbModule } from "@ng-bootstrap/ng-bootstrap";
import { DndDirective } from "src/app/directives/drag-and-drop.directive";
import { NavMenuMainModule } from "src/app/nav-menu/nav-menu.module";
import { CourseAllComponent } from "../manager-courses/course-all/course-all.component";
import { CourseEditComponent } from "../manager-courses/course-edit/course-edit.component";
import { GroupAllComponent } from "../manager-groups/group-all/group-all.component";
import { GroupEditComponent } from "../manager-groups/group-edit/group-edit.component";
import { RequestAllComponent } from "../manager-requests/request-all/request-all.component";
import { RequestEditComponent } from "../manager-requests/request-edit/request-edit.component";
import { StudentsAllComponent } from "../manager-students/students-all/students-all.component";
import { StudentsEditComponent } from "../manager-students/students-edit/students-edit.component";
import { TeacherAllComponent } from "../manager-teachers/teacher-all/teacher-all.component";
import { TeacherEditComponent } from "../manager-teachers/teacher-edit/teacher-edit.component";
import { TopicAllComponent } from "../manager-topics/topic-all/topic-all.component";
import { TopicEditComponent } from "../manager-topics/topic-edit/topic-edit.component";
import { ManagerMainComponent } from "./manager-main.component";

@NgModule({
    imports:
    [
        BrowserModule,
        FormsModule,
        RouterModule,
        ReactiveFormsModule,
        NavMenuMainModule,
        NgbModule,
    ],
    declarations:
    [
        ManagerMainComponent,
        StudentsAllComponent,
        StudentsEditComponent,
        CourseAllComponent,
        CourseEditComponent,
        TopicAllComponent,
        TopicEditComponent,
        RequestAllComponent,
        RequestEditComponent,
        TeacherAllComponent,
        TeacherEditComponent,
        GroupAllComponent,
        GroupEditComponent
    ],
    exports: [ ManagerMainComponent]
})
export class ManagerMainModule { }