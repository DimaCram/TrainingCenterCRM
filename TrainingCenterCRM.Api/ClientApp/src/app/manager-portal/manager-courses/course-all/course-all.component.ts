import { Component } from "@angular/core";
import { Title } from "@angular/platform-browser";
import { NgxUiLoaderService } from "ngx-ui-loader";
import { Course } from "src/app/models/course.model";
import { CourseService } from "src/app/services/courses.service";
import { saveAs } from 'file-saver';
import { ToastService } from "src/app/components/toast/toast.service";

@Component({
    selector: 'app-manager-courses',
    templateUrl: './course-all.component.html'
})

export class CourseAllComponent{
    public courses: Course[] = [];
    public page = 1;
    public pageSize = 5;

    constructor(private courseService: CourseService,
                private titleService: Title,
                private ngxService: NgxUiLoaderService,
                private toastService: ToastService){}

    ngOnInit(): void {
      this.titleService.setTitle("Courses - Training Center")
      this.ngxService.startLoader("loader");

      this.courseService.getCourses().subscribe(result => {
        this.courses = result;
        this.ngxService.stopLoader("loader");
      });
    }

    deleteCourse(id: number){

      this.courseService.deleteCourse(id).subscribe(result => {
        const removeIndex = this.courses.findIndex( item => item.id === id );
        this.courses.splice( removeIndex, 1 );

        this.toastService.showSuccess("Course deleted");
      });
    }

    download(){

      this.courseService.download().subscribe(result => {

        var FileSaver = require('file-saver');
        var blob = new Blob([result], {type: "text/plain;charset=utf-8"});
        FileSaver.saveAs(blob, "courses.csv");
      });
    }
}