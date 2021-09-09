import { Component } from "@angular/core";
import { Course } from "./course.model";
import { CourseService } from "./course.service";

@Component({
    selector: 'app-course',
    templateUrl: './course.component.html',
    styleUrls: ['./course.component.css']
})
export class CourseComponent{
    public courses: Course[];

    constructor(private courseService : CourseService){}

    ngOnInit(): void {
      this.courseService.getCourses().subscribe(result => {
        this.courses = result;
      },
      error => {console.error(error);});
    }
}