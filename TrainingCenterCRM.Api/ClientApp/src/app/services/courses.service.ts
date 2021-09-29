import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Inject, Injectable } from "@angular/core";
import { Course } from "../models/course.model";

Injectable()
@Injectable()
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

        const formData = new FormData();
        for (const prop in course) {
            if (!course.hasOwnProperty(prop)) { continue; }
            formData.append(prop , course[prop]);
        }

        return this.http.post(this.baseUrl + 'api/courses', formData)
    }

    deleteCourse(id : number){
        return this.http.delete(`${this.baseUrl}api/courses/${id}`)
    }
}
