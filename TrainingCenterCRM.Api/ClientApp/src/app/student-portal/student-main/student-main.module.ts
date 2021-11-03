import { NgModule } from "@angular/core";
import { FormsModule, ReactiveFormsModule } from "@angular/forms";
import { BrowserModule } from "@angular/platform-browser";
import { RouterModule } from "@angular/router";
import { NgbModule } from "@ng-bootstrap/ng-bootstrap";
import { NgxUiLoaderModule } from "ngx-ui-loader";
import { SharedModule } from "src/app/shared.module";
import { StudentGroupComponent } from "../student-group/student-group.component";
import { StudentGroupsComponent } from "../student-groups/student-groups.component";
import { StudentMainComponent } from "./student-main.component";

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
        StudentMainComponent,
        StudentGroupsComponent,
        StudentGroupComponent
    ],
    exports: [ StudentMainComponent ]
})
export class StudentMainModule { }