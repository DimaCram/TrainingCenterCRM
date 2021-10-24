import { Component } from "@angular/core";
import { FormBuilder, FormGroup } from "@angular/forms";
import { Course } from "../course/course.model";
import { CourseService } from "../course/course.service";
import { SearchFilter } from "../models/search-filter.model";

@Component({
    selector: 'app-course',
    templateUrl: './search.component.html',
    styleUrls: ['./search.component.css']
})
export class SearchComponent{
    public searchFilter: SearchFilter;
    public searchValue: string;
    public courses: Course[];
    public courseLevels: string[];
    form: FormGroup;

    constructor(private fb: FormBuilder,
                private courseService : CourseService){

      this.form = this.fb.group({
        title: [''],
        description: [''],
        topicName: [''],
        courseLevel: [''],
        priceFrom: [''],
        priceTo: ['']
      });
    }

    ngOnInit(): void {
      this.courseService.getCourses().subscribe(result => {
        this.courses = result;
      },
      error => {console.error(error);});

      
      this.courseService.getCourseLevels().subscribe(result => {
        this.courseLevels = result;
      },
      error => {console.error(error);});
    }

    onSubmit(){
      this.searchFilter = new SearchFilter();


        this.searchFilter.title = this.form.value.title;
        this.searchFilter.description = this.form.value.description;
        this.searchFilter.topicName = this.form.value.topicName;
        this.searchFilter.priceFrom = +this.form.value.priceFrom;
        this.searchFilter.priceTo = +this.form.value.priceTo;
        this.searchFilter.level = this.form.value.courseLevel;

        console.log(this.searchFilter);

        this.courseService.getCoursesByFilter(this.searchFilter).subscribe(result => {
          this.courses = result;
        },
        error => {console.error(error);});
    }

    search(){
      console.log(this.searchValue)
      this.courseService.searchCourses(this.searchValue).subscribe(result => {
        this.courses = result;
      },
      error => {console.error(error);});
    }
}