import { HttpClient } from "@angular/common/http";
import { Inject, Injectable } from "@angular/core";
import { Teacher } from "./teacher.model";

Injectable()
export class TeacherService{
    baseUrl: string;

    constructor(private http : HttpClient, @Inject('BASE_URL') baseUrl: string){
        this.baseUrl = baseUrl;
    }

    getTeachers(){
        return this.http.get<Teacher[]>(this.baseUrl + 'api/teachers');
    }
}
