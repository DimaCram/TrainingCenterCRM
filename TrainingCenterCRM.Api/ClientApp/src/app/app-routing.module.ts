import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import { AuthGuard } from "./account/guards/auth-guard.service";
import { LoginComponent } from "./account/login/login.component";
import { StatusErrorComponent } from "./components/statusError/status-error.component";
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
import { GroupControlComponent } from "./teacher-portal/teacher-groups/group-control/group-control.component";
import { TeacherGroupsComponent } from "./teacher-portal/teacher-groups/teacher-groups.component";
import { MaterialEditComponent } from "./teacher-portal/teacher-materials/material-edit/material-edit.component";
import { MaterialFileAddComponent } from "./teacher-portal/teacher-materials/material-file-add/material-file-add.component";
import { TeacherMainComponent } from "./teacher-portal/teacher-model/teacher-main.component";

const routes: Routes = [
    { path: '', redirectTo: '/login', pathMatch: 'full' },
    { path: 'login', component: LoginComponent},

    { path: 'manager', redirectTo: 'manager/students', pathMatch: 'full' },
    { path: 'manager', component: ManagerMainComponent,
        children: [
            { path: 'students', component: StudentsAllComponent },
            { path: 'students/edit', component: StudentsEditComponent },
            { path: 'students/edit/:id', component: StudentsEditComponent },

            { path: 'courses', component: CourseAllComponent },
            { path: 'courses/edit', component: CourseEditComponent },
            { path: 'courses/edit/:id', component: CourseEditComponent },

            { path: 'topics', component: TopicAllComponent },
            { path: 'topics/edit', component: TopicEditComponent },
            { path: 'topics/edit/:id', component: TopicEditComponent },

            { path: 'requests', component: RequestAllComponent },
            { path: 'requests/edit', component: RequestEditComponent },
            { path: 'requests/edit/:id', component: RequestEditComponent },

            { path: 'teachers', component: TeacherAllComponent },
            { path: 'teachers/edit', component: TeacherEditComponent },
            { path: 'teachers/edit/:id', component: TeacherEditComponent },

            { path: 'groups', component: GroupAllComponent },
            { path: 'groups/edit', component: GroupEditComponent },
            { path: 'groups/edit/:id', component: GroupEditComponent }
        ],
        canActivate: [AuthGuard],
        canActivateChild: [AuthGuard],
        data: { role: 'manager' }
    },

    { path: 'teacher', redirectTo: 'teacher/groups', pathMatch: 'full' },
    { path: 'teacher', component: TeacherMainComponent,
        children: [
            { path: 'materials/edit', component: MaterialEditComponent },
            { path: 'materials/edit/:id', component: MaterialEditComponent },
            { path: 'materials/addFile', component: MaterialFileAddComponent },
            { path: 'groups', component: TeacherGroupsComponent },
            { path: 'groupControl', component: GroupControlComponent },
        ],
        canActivate: [AuthGuard],
        canActivateChild: [AuthGuard],
        data: { role: 'teacher' }
    },

    { path: 'error/:code', component: StatusErrorComponent},
    { path: '**', redirectTo: '/error/404'},
]

@NgModule({
    imports: [RouterModule.forRoot(routes, { useHash: true, onSameUrlNavigation: 'reload' })],
    exports: [RouterModule],
    providers: [],
  })
  export class AppRoutingModule { }