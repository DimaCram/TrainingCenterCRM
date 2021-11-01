import { Component } from "@angular/core";
import { FormBuilder, FormGroup, Validators } from "@angular/forms";
import { Title } from "@angular/platform-browser";
import { ActivatedRoute, Router } from "@angular/router";
import { ToastService } from "src/app/components/toast/toast.service";
import { Topic } from "src/app/models/topic.model";
import { TopicService } from "src/app/services/topic.service";

@Component({
    selector: 'app-manager-main',
    templateUrl: './topic-edit.component.html',
})
export class TopicEditComponent {
    id: number;
    form: FormGroup;

    constructor(private fb: FormBuilder,
                private topicSevice: TopicService,
                private route: ActivatedRoute,
                private router: Router,
                private titleService: Title,
                private toastService: ToastService){}


    ngOnInit(): void {
        this.titleService.setTitle("Edit topic - Training Center")

        this.id = this.route.snapshot.params['id'];

        this.form = this.fb.group({
            title: ['', Validators.required],
            description: ['']
        });

        if (this.id) {
            this.topicSevice.getTopic(this.id)
                            .subscribe(res => {this.form.patchValue(res)});
        }
    }

    onSubmit(){
      this.editTopic();
    }


    editTopic(): void{
      let topic : Topic = new Topic();

      if(this.id)
        topic.id = +this.id;

      topic.title = this.form.value.title;
      topic.description = this.form.value.description;

      this.topicSevice.egitTopic(topic).subscribe(result => {
            if(this.id)
            {
              this.router.navigate(['../../'], { relativeTo: this.route });
              this.toastService.showSuccess("Topic edited");
            }
            else
            {
              this.router.navigate(['../'], { relativeTo: this.route });
              this.toastService.showSuccess("Topic added");
            }
      });
    }
  }