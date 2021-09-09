import { HttpClient } from "@angular/common/http";
import { Inject, Injectable } from "@angular/core";
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
}
