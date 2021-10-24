import { HttpClient, HttpParams } from "@angular/common/http";
import { Inject, Injectable } from "@angular/core";
import { SearchFilter } from "../models/search-filter.model";
import { Course } from "./course.model";

Injectable()
export class CourseService{
    baseUrl: string;

    constructor(private http : HttpClient, @Inject('BASE_URL') baseUrl: string){
        this.baseUrl = baseUrl;
    }

    getCourses(){
        return this.http.get<Course[]>(this.baseUrl + 'api/courses');
    }

    getCoursesByFilter(filter: SearchFilter){

        let params = new HttpParams();
        for(let key in filter){
            if(filter[key])
                params = params.append(key, filter[key]) 
        }

        console.log(params);

        return this.http.get<Course[]>(this.baseUrl + 'api/courses/filter', {params: params});
    }

    searchCourses(search: string){
        let params = new HttpParams().append("search", search);
        return this.http.get<Course[]>(this.baseUrl + 'api/courses/search', {params: params});
    }

    getCourseLevels(){
        return this.http.get<string[]>(this.baseUrl + 'api/courses/levels');
    }
}
