import { Course } from "./course.model";
import { Student } from "./student.model";
import { Teacher } from "./teacher.model";

export class Group{
    id: number;
    name : string;
    startDate : Date;
    groupStatus: string;
    students : Student[];
    teacher : Teacher;
    teacherId : number;
    courseId : number;
    course : Course;
}