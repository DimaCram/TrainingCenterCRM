import { Component } from "@angular/core";
import { Title } from "@angular/platform-browser";
import { Request } from "src/app/models/request.model";
import { RequestService } from "src/app/services/request.service";

@Component({
    selector: 'app-manager-requests',
    templateUrl: './request-all.component.html'
})


export class RequestAllComponent{
    public requests: Request[] = [];
    public page = 1;
    public pageSize = 5;

    constructor(private courseService: RequestService,
                private titleService: Title){}

    ngOnInit(): void {
      this.titleService.setTitle("Requests - Training Center")

      this.courseService.getRequests().subscribe(result => {
        this.requests = result;
      },
      error => {console.error(error);});
    }

    deleteRequest(id: number){

      this.courseService.deleteRequest(id).subscribe(result => {
        const removeIndex = this.requests.findIndex( item => item.id === id );
        this.requests.splice( removeIndex, 1 );
      },
      error => {console.error(error);});
    }
}