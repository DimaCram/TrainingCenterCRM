import { Component } from "@angular/core";
import { FormBuilder, FormGroup, Validators } from "@angular/forms";
import { ActivatedRoute, Router } from "@angular/router";
import { Course } from "src/app/models/course.model";
import { Topic } from "src/app/models/topic.model";
import { CourseService } from "src/app/services/courses.service";
import { TopicService } from "src/app/services/topic.service";

@Component({
    selector: 'manager-course-edit',
    templateUrl: './course-edit.component.html'
})

export class CourseEditComponent{
    topics : Topic[];
    form: FormGroup;
    id: number;

    constructor(private fb: FormBuilder,
                private courseSevice: CourseService,
                private topicService: TopicService,
                private route: ActivatedRoute,
                private router: Router){}


    ngOnInit(): void {
        this.id = this.route.snapshot.params['id'];

        if (this.id) {
            this.courseSevice.getCourse(this.id)
                             .subscribe(res => {this.form.patchValue(res)});
        }

        this.topicService.getTopics().subscribe(res => this.topics = res);


        this.form = this.fb.group({
            title: ['', Validators.required],
            description: [''],
            topicId: ['', Validators.required]
        });
    }

    onSubmit(){
        this.editCourse();
    }


    editCourse(): void{
        let course : Course = new Course();
        
        if(this.id)
            course.id = +this.id;
        
        course.title = this.form.value.title;
        course.description = this.form.value.description;
        course.topicId = +this.form.value.topicId

        console.log(course);


        this.courseSevice.egitCourse(course).subscribe(result => {
            if(this.id)
                this.router.navigate(['../../'], { relativeTo: this.route });
            else
                this.router.navigate(['../'], { relativeTo: this.route });
        },
        error => {console.error(error);});}
    }