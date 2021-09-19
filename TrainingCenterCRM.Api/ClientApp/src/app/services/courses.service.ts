import { HttpClient } from "@angular/common/http";
import { Inject, Injectable } from "@angular/core";
import { Course } from "../models/course.model";

Injectable()
export class CourseService{
    baseUrl: string;

    constructor(private http : HttpClient, @Inject('BASE_URL') baseUrl: string){
        this.baseUrl = baseUrl;
    }

    getCourses(){
        return this.http.get<Course[]>(this.baseUrl + 'api/courses');
    }

    getCourse(id: number){
        return this.http.get<Course>(this.baseUrl + `api/courses/${id}`);
    }

    egitCourse(course : Course){
        return this.http.post(this.baseUrl + 'api/courses', course)
    }
    
    deleteCourse(id : number){
        return this.http.delete(`${this.baseUrl}api/courses/${id}`)
    }
}