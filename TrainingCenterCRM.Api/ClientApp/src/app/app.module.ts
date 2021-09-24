import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { AppRoutingModule } from './app-routing.module';
import { ManagerMainModule } from './manager-portal/manager-main/manager-main.module';
import { StudentService } from './services/student.service';
import { CourseService } from './services/courses.service';
import { TopicService } from './services/topic.service';
import { DndDirective } from './directives/drag-and-drop.directive';
import { RequestService } from './services/request.service';
import { DatePipe } from '@angular/common';
import { TeacherService } from './services/teacher.service';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    AppRoutingModule,
    ManagerMainModule
  ],
  providers: [
    DatePipe,
    StudentService,
    CourseService,
    TopicService,
    RequestService,
    TeacherService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
