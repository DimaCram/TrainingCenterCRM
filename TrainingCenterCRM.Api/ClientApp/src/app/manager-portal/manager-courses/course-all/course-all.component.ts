import { Component } from "@angular/core";
import { Course } from "src/app/models/course.model";
import { CourseService } from "src/app/services/courses.service";

@Component({
    selector: 'app-manager-courses',
    templateUrl: './course-all.component.html'
})

export class CourseAllComponent{
    public courses: Course[];

    constructor(private courseService: CourseService){}

    ngOnInit(): void {
      this.courseService.getCourses().subscribe(result => {
        this.courses = result;
      },
      error => {console.error(error);});
    }

    deleteCourse(id: number){
      
      this.courseService.deleteCourse(id).subscribe(result => {
        const removeIndex = this.courses.findIndex( item => item.id === id );
        this.courses.splice( removeIndex, 1 );
      },
      error => {console.error(error);});
    }
}