import { HttpClient, HttpParams } from "@angular/common/http";
import { Inject, Injectable } from "@angular/core";
import { StudentMark } from "../models/student-mark.model";

@Injectable()
export class StudentMarkService{
    baseUrl: string;

    constructor(private http : HttpClient, @Inject('BASE_URL') baseUrl: string){
        this.baseUrl = baseUrl;
    }

    getMarks(){
        return this.http.get<StudentMark[]>(this.baseUrl + 'api/studentMarks');
    }

    getMark(id: number){
        return this.http.get<StudentMark>(this.baseUrl + `api/studentMarks/${id}`);
    }

    editMark(mark : StudentMark){
        return this.http.post(this.baseUrl + 'api/studentMarks', mark)
    }

    deleteMark(id : number){
        return this.http.delete(`${this.baseUrl}api/studentMarks/${id}`)
    }

    getGroupMarks(groupId: number){
        let httpParams = new HttpParams().append('groupId', groupId.toString());

        return this.http.get<StudentMark[]>(`${this.baseUrl}api/studentMarks/groupMarks`, {params: httpParams})
    }

    getStudentAverageByGroup(groupId: number){
        let httpParams = new HttpParams().append('groupId', groupId.toString());

        return this.http.get<number>(`${this.baseUrl}api/studentMarks/studentAverageByGroup`, {params: httpParams})
    }
}