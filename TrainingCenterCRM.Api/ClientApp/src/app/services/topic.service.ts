import { HttpClient, HttpParams } from "@angular/common/http";
import { Inject, Injectable } from "@angular/core";
import { Topic } from "../models/topic.model";

Injectable()
@Injectable()
export class TopicService{
    baseUrl: string;

    constructor(private http : HttpClient, @Inject('BASE_URL') baseUrl: string){
        this.baseUrl = baseUrl;
    }

    getTopics(){
        return this.http.get<Topic[]>(this.baseUrl + 'api/topics');
    }

    getTopic(id: number){
        return this.http.get<Topic>(this.baseUrl + `api/topics/${id}`);
    }

    egitTopic(topic : Topic){
        return this.http.post(this.baseUrl + 'api/topics', topic)
    }
    
    deleteTopic(id : number){
        return this.http.delete(`${this.baseUrl}api/topics/${id}`)
    }
}
