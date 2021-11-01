import { Component } from "@angular/core";
import { Title } from "@angular/platform-browser";
import { Router } from "@angular/router";
import { NgxUiLoaderService } from "ngx-ui-loader";
import { ToastService } from "src/app/components/toast/toast.service";
import { Topic } from "src/app/models/topic.model";
import { TopicService } from "src/app/services/topic.service";

@Component({
    selector: 'manager-topic-all',
    templateUrl: './topic-all.component.html',
  })
  export class TopicAllComponent {
    public topics: Topic[] = [];
    public page = 1;
    public pageSize = 5;

    constructor(private topicService : TopicService,
                private titleService: Title,
                private ngxService: NgxUiLoaderService,
                private toastService: ToastService){}

    ngOnInit(): void {
      this.titleService.setTitle("Topics - Training Center")

      this.ngxService.startLoader("topicsLoader");
      this.topicService.getTopics().subscribe(result => {
        this.ngxService.stopLoader("topicsLoader");
        this.topics = result;
      });
    }


    deleteTopic(id: number):void{
        this.topicService.deleteTopic(id).subscribe(result => {
            const removeIndex = this.topics.findIndex( item => item.id === id );
            this.topics.splice( removeIndex, 1 );

            this.toastService.showSuccess("Topic deleted");
          });
    }
  }