import { Course } from "./course.model"
import { Student } from "./student.model"

export class Request{

    public id: number
    public readyToStartDate : Date
    public comments : string
    public status : string
    public courseId : number
    public course : Course
    public student : Student
    public studentId : number

    constructor(){}
}