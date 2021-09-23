import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { Student } from 'src/app/models/student.model';
import { StudentService } from 'src/app/services/student.service';

@Component({
  selector: 'app-manager-main',
  templateUrl: './students-edit.component.html',
})
export class StudentsEditComponent {

  form: FormGroup;
  id: number;

  constructor(private fb: FormBuilder,
              private studentSevice: StudentService,
              private route: ActivatedRoute,
              private router: Router){

                this.id = this.route.snapshot.params['id'];
              }

  ngOnInit(): void {
    if (this.id) {
      this.studentSevice.getStudent(this.id)
      .subscribe(res => {
        console.log(res);
        this.form.patchValue(res);
      });

      this.form = this.fb.group({
       name: ['', Validators.required],
       surname: ['', Validators.required],
       age: ['', [Validators.required]],
       userId: ['']
      });

    }else{
      this.form = this.fb.group({
        name: ['', Validators.required],
        surname: ['', Validators.required],
        age: ['', [Validators.required]],
        email: ['', Validators.compose([
                      Validators.email,
                      Validators.required])
        ],
        password: ['', Validators.compose([
          Validators.required,
          Validators.pattern('(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[$@$!%*?&.])[A-Za-z\d$@$!%*?&].{8,}')])
        ],
        userId: ['']
      });
    }
  }

  onSubmit(){
    this.editStudent();
  }


  editStudent(): void{
    let student : Student = new Student(this.form.value.name, this.form.value.surname, this.form.value.age);
    if(!this.id){
      student.email = this.form.value.email;
      student.password = this.form.value.password;
    }
    else{
      student.id = +this.id;
      student.userId = this.form.value.userId;
    }
    console.log(student);

    this.studentSevice.egitStudent(student).subscribe(result => {

      if(this.id)
        this.router.navigate(['../../'], { relativeTo: this.route });
       else
        this.router.navigate(['../'], { relativeTo: this.route });
    },
    error => {console.error(error);});
  }
}
