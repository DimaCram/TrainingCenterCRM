import { HttpClient } from "@angular/common/http";
import { Inject, Injectable } from "@angular/core";
import { Student } from "../models/studentmodel";


Injectable()
export class StudentService{
    baseUrl: string;

    constructor(private http : HttpClient, @Inject('BASE_URL') baseUrl: string){
        this.baseUrl = baseUrl;
    }

    getStudents(){
        return this.http.get<Student[]>(this.baseUrl + 'api/students');
    }
}
