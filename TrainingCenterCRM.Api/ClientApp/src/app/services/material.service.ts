import { HttpClient, HttpParams } from "@angular/common/http";
import { Inject, Injectable } from "@angular/core";
import { File } from "../models/file.model";
import { Material } from "../models/metirial.model";

@Injectable()
export class MaterialService{
    baseUrl: string;

    constructor(private http : HttpClient, @Inject('BASE_URL') baseUrl: string){
        this.baseUrl = baseUrl;
    }

    getMaterials(){
        return this.http.get<Material[]>(this.baseUrl + 'api/materials');
    }

    getMaterial(id: number){
        return this.http.get<Material>(this.baseUrl + `api/materials/${id}`);
    }

    egitMaterial(student : Material){
        return this.http.post(this.baseUrl + 'api/materials', student)
    }

    deleteMaterial(id : number){
        return this.http.delete(`${this.baseUrl}api/materials/${id}`)
    }

    getMaterialStatuses(){
        return this.http.get<string[]>(this.baseUrl + `api/materials/statuses`);
    }

    addFile(file : File){
        const formData = new FormData();

        formData.append("courseId" , file.CourseId.toString());
        file.files.forEach(element => {
            formData.append("files" , element);
        });
        return this.http.post(this.baseUrl + 'api/materials/addFile', formData)
    }
}