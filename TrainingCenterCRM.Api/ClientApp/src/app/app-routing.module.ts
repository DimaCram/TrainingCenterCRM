import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import { CourseAllComponent } from "./manager-portal/manager-courses/course-all/course-all.component";
import { CourseEditComponent } from "./manager-portal/manager-courses/course-edit/course-edit.component";
import { ManagerMainComponent } from "./manager-portal/manager-main/manager-main.component";
import { StudentsAllComponent } from "./manager-portal/manager-students/students-all/students-all.component";
import { StudentsEditComponent } from "./manager-portal/manager-students/students-edit/students-edit.component";
import { TopicAllComponent } from "./manager-portal/manager-topics/topic-all/topic-all.component";
import { TopicEditComponent } from "./manager-portal/manager-topics/topic-edit/topic-edit.component";

const routes: Routes = [
    { path: 'manager', component: ManagerMainComponent, children: [{ path: 'students', component: StudentsAllComponent }]},
    { path: 'manager', component: ManagerMainComponent, children: [{ path: 'students/edit', component: StudentsEditComponent }]},

    { path: 'manager', component: ManagerMainComponent, children: [{ path: 'courses', component: CourseAllComponent }]},
    { path: 'manager', component: ManagerMainComponent, children: [{ path: 'courses/edit', component: CourseEditComponent }]},
    { path: 'manager', component: ManagerMainComponent, children: [{ path: 'courses/edit/:id', component: CourseEditComponent }]},
    
    { path: 'manager', component: ManagerMainComponent, children: [{ path: 'topics', component: TopicAllComponent }]},
    { path: 'manager', component: ManagerMainComponent, children: [{ path: 'topics/edit/:id', component: TopicEditComponent }]},
    { path: 'manager', component: ManagerMainComponent, children: [{ path: 'topics/edit', component: TopicEditComponent }]}
]

@NgModule({
    imports: [RouterModule.forRoot(routes, { useHash: true, onSameUrlNavigation: 'reload' })],
    exports: [RouterModule],
    providers: [],
  })
  export class AppRoutingModule { }