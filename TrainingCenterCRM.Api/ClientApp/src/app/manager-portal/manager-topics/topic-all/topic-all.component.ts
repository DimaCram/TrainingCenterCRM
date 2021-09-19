import { Component } from "@angular/core";
import { Router } from "@angular/router";
import { Topic } from "src/app/models/topic.model";
import { TopicService } from "src/app/services/topic.service";

@Component({
    selector: 'manager-topic-all',
    templateUrl: './topic-all.component.html',
  })
  export class TopicAllComponent {
    public topics: Topic[];

    constructor(private topicService : TopicService){}

    ngOnInit(): void {
      this.topicService.getTopics().subscribe(result => {
        this.topics = result;
      },
      error => {console.error(error);});
    }

      
    deleteTopic(id: number):void{
        this.topicService.deleteTopic(id).subscribe(result => {
            const removeIndex = this.topics.findIndex( item => item.id === id );
            this.topics.splice( removeIndex, 1 );
          },
          error => {console.error(error);});
    }
  }