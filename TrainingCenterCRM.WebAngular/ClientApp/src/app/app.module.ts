import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { StudentComponent } from './student/student.component';
import { FilterPipe } from './pipes/filter.pipe';
import { StudentService } from './student/student.service';
import { FooterComponent } from './footer/footer.component';
import { CourseComponent } from './course/course.component';
import { TeachersComponent } from './teacher/teacher.component';
import { CourseService } from './course/course.service';
import { TeacherService } from './teacher/teacher.service';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    StudentComponent,
    FooterComponent,
    CourseComponent,
    TeachersComponent,
    FilterPipe
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'courses', component: CourseComponent },
      { path: 'teachers', component: TeachersComponent }
    ])
  ],
  providers: [StudentService, CourseService, TeacherService],
  bootstrap: [AppComponent]
})
export class AppModule { }
