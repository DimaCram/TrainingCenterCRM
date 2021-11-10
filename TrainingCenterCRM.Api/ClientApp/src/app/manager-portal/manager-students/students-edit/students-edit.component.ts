import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Title } from '@angular/platform-browser';
import { ActivatedRoute, Router } from '@angular/router';
import { ToastService } from 'src/app/components/toast/toast.service';
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
              private router: Router,
              private titleService: Title,
              private toastService: ToastService){

                this.id = this.route.snapshot.params['id'];
              }

  ngOnInit(): void {
    this.titleService.setTitle("Edit student - Training Center")

    if (this.id) {
      this.studentSevice.getStudent(this.id).subscribe(res => {
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
    let student : Student = new Student();
    if(!this.id){
      student.email = this.form.value.email;
      student.password = this.form.value.password;
    }
    else{
      student.id = +this.id;
      student.userId = this.form.value.userId;
    }
    student.name = this.form.value.name
    student.surname = this.form.value.surname
    student.age = this.form.value.age

    this.studentSevice.egitStudent(student).subscribe(result => {

      if(this.id){
        this.toastService.showSuccess("Student edited");
        this.router.navigate(['../../'], { relativeTo: this.route });
      }
      else{
        this.toastService.showSuccess("Student added");
        this.router.navigate(['../'], { relativeTo: this.route });
      }
    });
  }
}
