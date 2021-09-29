import { Course } from "./course.model";
import { Material } from "./metirial.model";

export class File{
    id: number;
    name : string;
    fileType : string;
    files: any[];
    CreateDate: Date;
    HasMaterial: boolean;
    CourseId : number;
    Course : Course;
    Materials : Material[];
}