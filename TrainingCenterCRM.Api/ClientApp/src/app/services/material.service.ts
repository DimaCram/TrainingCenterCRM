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

    getMaterialTypes(){
        return this.http.get<string[]>(this.baseUrl + `api/materials/types`);
    }

    addFile(file : File){
        const formData = new FormData();

        formData.append("courseId" , file.courseId.toString());
        file.files.forEach(element => {
            formData.append("files" , element);
        });
        return this.http.post(this.baseUrl + 'api/materials/addFile', formData)
    }

    getFilesForGroup(courseId: number, materialId: number){
        let params = new HttpParams();
        params = params.append('courseId', courseId.toString());

        if(materialId)
            params = params.append('materialId', materialId.toString());

        return this.http.get<File[]>(this.baseUrl + `api/materials/filesForGroup`, {params: params});
    }

    getMaterialsByGroup(groupId: number){
        let params = new HttpParams();
        params = params.append('groupId', groupId.toString());

        return this.http.get<Material[]>(this.baseUrl + `api/materials/groupMaterials`, {params: params});
    }

    downloadFile(fileId: number){
        let params = new HttpParams().append('fileId', fileId.toString());

        return this.http.get(this.baseUrl + `api/materials/downloadFile`, {params: params , responseType: 'blob'});
    }
}