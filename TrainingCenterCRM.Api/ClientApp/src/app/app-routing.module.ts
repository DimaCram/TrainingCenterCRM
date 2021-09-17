import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import { ManagerMainComponent } from "./manager-portal/manager-main/manager-main.component";
import { StudentsAllComponent } from "./manager-portal/manager-students/students-all/students-all.component";
import { StudentsEditComponent } from "./manager-portal/manager-students/students-edit/students-edit.component";

const routes: Routes = [
    { path: 'manager', component: ManagerMainComponent, children: [{ path: 'students', component: StudentsAllComponent }]},
    { path: 'manager', component: ManagerMainComponent, children: [{ path: 'students/edit', component: StudentsEditComponent }]}
]

@NgModule({
    imports: [RouterModule.forRoot(routes, { useHash: true, onSameUrlNavigation: 'reload' })],
    exports: [RouterModule],
    providers: [],
  })
  export class AppRoutingModule { }