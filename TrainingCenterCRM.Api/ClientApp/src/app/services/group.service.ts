import { HttpClient } from "@angular/common/http";
import { Inject, Injectable } from "@angular/core";
import { Group } from "../models/group.model";

Injectable()
@Injectable()
export class GroupService{
    baseUrl: string;

    constructor(private http : HttpClient, @Inject('BASE_URL') baseUrl: string){
        this.baseUrl = baseUrl;
    }

    getGroups(){
        return this.http.get<Group[]>(this.baseUrl + 'api/groups');
    }

    getGroup(id: number){
        return this.http.get<Group>(this.baseUrl + `api/groups/${id}`);
    }

    egitGroup(student : Group){
        return this.http.post(this.baseUrl + 'api/groups', student)
    }

    deleteGroup(id : number){
        return this.http.delete(`${this.baseUrl}api/groups/${id}`)
    }

    getGroupStatuses(){
        return this.http.get<string[]>(this.baseUrl + `api/groups/statuses`);
    }
    
    getTeacherGroups(){
        return this.http.get<Group[]>(this.baseUrl + `api/groups/teacherGroups`);
    }
}