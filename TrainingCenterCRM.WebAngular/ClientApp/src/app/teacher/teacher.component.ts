import { Component } from "@angular/core";
import { Teacher } from "./teacher.model";
import { TeacherService } from "./teacher.service";

@Component({
    selector: 'app-teacher',
    templateUrl: './teacher.component.html',
    styleUrls: ['./teacher.component.css']
})

export class TeachersComponent{
    public teachers: Teacher[];

    constructor(private teacherService : TeacherService){}

    ngOnInit(): void {
      this.teacherService.getTeachers().subscribe(result => {
        this.teachers = result;
        console.log(this.teachers);
      },
      error => {console.error(error);});
    }
}