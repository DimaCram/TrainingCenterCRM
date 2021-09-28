import { HttpClient } from "@angular/common/http";
import { Inject, Injectable } from "@angular/core";
import { Teacher } from "../models/teacher.model";

Injectable()
@Injectable()
export class TeacherService{
    baseUrl: string;

    constructor(private http : HttpClient, @Inject('BASE_URL') baseUrl: string){
        this.baseUrl = baseUrl;
    }

    getTeachers(){
        return this.http.get<Teacher[]>(this.baseUrl + 'api/teachers');
    }

    getTeacher(id: number){
        return this.http.get<Teacher>(this.baseUrl + `api/teachers/${id}`);
    }

    egitTeacher(teacher : Teacher){

        const formData = new FormData();
        for (const prop in teacher) {
            if (!teacher.hasOwnProperty(prop)) { continue; }
            formData.append(prop , teacher[prop]);
        }

        return this.http.post(this.baseUrl + 'api/teachers', formData)
    }

    deleteTeacher(id : number){
        return this.http.delete(`${this.baseUrl}api/teachers/${id}`)
    }
}