import { Component } from '@angular/core';
import { Student } from 'src/app/models/studentmodel';
import { StudentService } from 'src/app/services/student.service';

@Component({
  selector: 'app-manager-main',
  templateUrl: './students-all.component.html',
})
export class StudentsAllComponent {
    public students: Student[];

    constructor(private teacherService : StudentService){}

    ngOnInit(): void {
      this.teacherService.getStudents().subscribe(result => {
        this.students = result;
      },
      error => {console.error(error);});
    }
}
