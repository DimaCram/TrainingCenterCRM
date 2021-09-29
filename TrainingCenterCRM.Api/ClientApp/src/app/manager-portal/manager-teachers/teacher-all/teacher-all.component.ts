import { Component } from '@angular/core';
import { Title } from '@angular/platform-browser';
import { Teacher } from 'src/app/models/teacher.model';
import { TeacherService } from 'src/app/services/teacher.service';

@Component({
  selector: 'manager-teacher-all',
  templateUrl: './teacher-all.component.html',
})
export class TeacherAllComponent {
    public teachers: Teacher[] = [];
    public page = 1;
    public pageSize = 5;

    constructor(private teacherService : TeacherService,
                private titleService: Title){}

    ngOnInit(): void {
      this.titleService.setTitle("Teachers - Training Center")

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
