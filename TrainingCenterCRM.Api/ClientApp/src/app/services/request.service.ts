import { HttpClient, HttpParams } from "@angular/common/http";
import { Inject, Injectable } from "@angular/core";
import { Request } from "../models/request.model";

Injectable()
export class RequestService{
    baseUrl: string;

    constructor(private http : HttpClient, @Inject('BASE_URL') baseUrl: string){
        this.baseUrl = baseUrl;
    }

    getRequests(){
        return this.http.get<Request[]>(this.baseUrl + 'api/studentrequests');
    }

    getRequest(id: number){
        return this.http.get<Request>(this.baseUrl + `api/studentrequests/${id}`);
    }

    egitRequest(student : Request){
        return this.http.post(this.baseUrl + 'api/studentrequests', student)
    }

    deleteRequest(id : number){
        return this.http.delete(`${this.baseUrl}api/studentrequests/${id}`)
    }

    getRequestStatuses(){
        return this.http.get<string[]>(this.baseUrl + `api/studentrequests/statuses`);
    }
    
}