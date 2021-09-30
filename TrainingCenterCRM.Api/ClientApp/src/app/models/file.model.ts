import { Course } from "./course.model";
import { Material } from "./metirial.model";

export class File{
    id: number;
    name : string;
    fileType : string;
    files: any[];
    createDate: Date;
    hasMaterial: boolean;
    courseId : number;
    course : Course;
}