import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import { AuthGuard } from "./account/guards/auth-guard.service";
import { LoginComponent } from "./account/login/login.component";
import { CourseAllComponent } from "./manager-portal/manager-courses/course-all/course-all.component";
import { CourseEditComponent } from "./manager-portal/manager-courses/course-edit/course-edit.component";
import { GroupAllComponent } from "./manager-portal/manager-groups/group-all/group-all.component";
import { GroupEditComponent } from "./manager-portal/manager-groups/group-edit/group-edit.component";
import { ManagerMainComponent } from "./manager-portal/manager-main/manager-main.component";
import { RequestAllComponent } from "./manager-portal/manager-requests/request-all/request-all.component";
import { RequestEditComponent } from "./manager-portal/manager-requests/request-edit/request-edit.component";
import { StudentsAllComponent } from "./manager-portal/manager-students/students-all/students-all.component";
import { StudentsEditComponent } from "./manager-portal/manager-students/students-edit/students-edit.component";
import { TeacherAllComponent } from "./manager-portal/manager-teachers/teacher-all/teacher-all.component";
import { TeacherEditComponent } from "./manager-portal/manager-teachers/teacher-edit/teacher-edit.component";
import { TopicAllComponent } from "./manager-portal/manager-topics/topic-all/topic-all.component";
import { TopicEditComponent } from "./manager-portal/manager-topics/topic-edit/topic-edit.component";

const routes: Routes = [
    { path: 'login', component: LoginComponent},

    { path: 'manager', component: ManagerMainComponent, children: [{ path: 'students', component: StudentsAllComponent }]},
    { path: 'manager', component: ManagerMainComponent, children: [{ path: 'students/edit', component: StudentsEditComponent }]},
    { path: 'manager', component: ManagerMainComponent, children: [{ path: 'students/edit/:id', component: StudentsEditComponent }]},

    { path: 'manager', component: ManagerMainComponent, children: [{ path: 'courses', component: CourseAllComponent }]},
    { path: 'manager', component: ManagerMainComponent, children: [{ path: 'courses/edit', component: CourseEditComponent }]},
    { path: 'manager', component: ManagerMainComponent, children: [{ path: 'courses/edit/:id', component: CourseEditComponent }]},

    { path: 'manager', component: ManagerMainComponent, children: [{ path: 'topics', component: TopicAllComponent }]},
    { path: 'manager', component: ManagerMainComponent, children: [{ path: 'topics/edit/:id', component: TopicEditComponent }]},
    { path: 'manager', component: ManagerMainComponent, children: [{ path: 'topics/edit', component: TopicEditComponent }]},

    { path: 'manager', component: ManagerMainComponent, children: [{ path: 'requests', component: RequestAllComponent }]},
    { path: 'manager', component: ManagerMainComponent, children: [{ path: 'requests/edit/:id', component: RequestEditComponent }]},
    { path: 'manager', component: ManagerMainComponent, children: [{ path: 'requests/edit', component: RequestEditComponent }]},

    { path: 'manager', component: ManagerMainComponent, children: [{ path: 'teachers', component: TeacherAllComponent }], canActivate: [AuthGuard]},
    { path: 'manager', component: ManagerMainComponent, children: [{ path: 'teachers/edit/:id', component: TeacherEditComponent }]},
    { path: 'manager', component: ManagerMainComponent, children: [{ path: 'teachers/edit', component: TeacherEditComponent }]},

    { path: 'manager', component: ManagerMainComponent, children: [{ path: 'groups', component: GroupAllComponent }]},
    { path: 'manager', component: ManagerMainComponent, children: [{ path: 'groups/edit/:id', component: GroupEditComponent }]},
    { path: 'manager', component: ManagerMainComponent, children: [{ path: 'groups/edit', component: GroupEditComponent }]},
]

@NgModule({
    imports: [RouterModule.forRoot(routes, { useHash: true, onSameUrlNavigation: 'reload' })],
    exports: [RouterModule],
    providers: [],
  })
  export class AppRoutingModule { }