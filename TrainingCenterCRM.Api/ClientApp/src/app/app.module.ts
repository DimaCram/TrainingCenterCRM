import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
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
import { GroupService } from './services/group.service';
import { LoginComponent } from './account/login/login.component';
import { JwtModule } from '@auth0/angular-jwt';
import { AccountService } from './services/account.service';
import { TeacherMainModule } from './teacher-portal/teacher-model/teacher-main.module';

export function tokenGetter(){
  return localStorage.getItem("jwt");
}

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    AppRoutingModule,
    ManagerMainModule,
    TeacherMainModule,
    JwtModule.forRoot({
      config: {
        tokenGetter: tokenGetter,
        allowedDomains: ["localhost:44378"],
        disallowedRoutes: []
      }
    }),
    ReactiveFormsModule
  ],
  providers: [
    DatePipe,
    StudentService,
    CourseService,
    TopicService,
    RequestService,
    TeacherService,
    GroupService,
    AccountService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
