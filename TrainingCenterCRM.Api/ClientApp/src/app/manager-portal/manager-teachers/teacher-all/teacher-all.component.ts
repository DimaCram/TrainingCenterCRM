import { Component } from '@angular/core';
import { Teacher } from 'src/app/models/teacher.model';
import { TeacherService } from 'src/app/services/teacher.service';

@Component({
  selector: 'manager-teacher-all',
  templateUrl: './teacher-all.component.html',
})
export class TeacherAllComponent {
    public teachers: Teacher[];

    constructor(private teacherService : TeacherService){}

    ngOnInit(): void {
      this.teacherService.getTeachers().subscribe(result => {
        this.teachers = result;
      },
      error => {console.error(error);});
    }

    deleteTeacher(id): void{
      this.teacherService.deleteTeacher(id).subscribe(result => {
        const removeIndex = this.teachers.findIndex( item => item.id === id );
        this.teachers.splice( removeIndex, 1 );
      },
      error => {console.error(error);});
    }
}
