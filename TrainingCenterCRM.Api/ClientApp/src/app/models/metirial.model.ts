import { File } from "./file.model";
import { Group } from "./group.model";

export class Material{
    id: number;
    name : string;
    materialType : string;
    files: File[];
    groupId : number;
    group : Group;
}