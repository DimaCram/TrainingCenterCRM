import { Material } from "./metirial.model";
import { Student } from "./student.model";

export class StudentMark{
    public id: number;
    public mark: number;
    public comment: string;

    public materialId: number;
    public material: Material;

    public studentId: number;
    public student: Student;
    constructor(){}
}