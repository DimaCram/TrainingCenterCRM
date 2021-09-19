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
  providers: [StudentService, CourseService, TopicService],
  bootstrap: [AppComponent]
})
export class AppModule { }