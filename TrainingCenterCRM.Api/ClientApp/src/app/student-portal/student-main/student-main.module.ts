import { NgModule } from "@angular/core";
import { FormsModule, ReactiveFormsModule } from "@angular/forms";
import { BrowserModule } from "@angular/platform-browser";
import { RouterModule } from "@angular/router";
import { NgbModule } from "@ng-bootstrap/ng-bootstrap";
import { ChartsModule } from "ng2-charts";
import { NgxUiLoaderModule } from "ngx-ui-loader";
import { SharedModule } from "src/app/shared.module";
import { StudentGroupMarksComponent } from "../student-group-marks/student-group-marks.component";
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
        ChartsModule,
        NgxUiLoaderModule
    ],
    declarations:
    [
        StudentMainComponent,
        StudentGroupsComponent,
        StudentGroupComponent,
        StudentGroupMarksComponent
    ],
    exports: [ StudentMainComponent ]
})
export class StudentMainModule { }