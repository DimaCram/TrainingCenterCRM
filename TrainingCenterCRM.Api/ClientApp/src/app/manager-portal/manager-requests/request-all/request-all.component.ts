import { Component } from "@angular/core";
import { Title } from "@angular/platform-browser";
import { NgxUiLoaderService } from "ngx-ui-loader";
import { ToastService } from "src/app/components/toast/toast.service";
import { Request } from "src/app/models/request.model";
import { RequestService } from "src/app/services/request.service";

@Component({
    selector: 'app-manager-requests',
    templateUrl: './request-all.component.html'
})


export class RequestAllComponent{
    private requests: Request[] = [];
    public filteredRequests: Request[] = [];

    public page = 1;
    public pageSize = 5;

    constructor(private courseService: RequestService,
                private titleService: Title,
                private ngxService: NgxUiLoaderService,
                private toastService: ToastService){}

    ngOnInit(): void {
      this.titleService.setTitle("Requests - Training Center")

      this.ngxService.startLoader("requestsLoader");
      this.courseService.getRequests().subscribe(result => {
        this.ngxService.stopLoader("requestsLoader");
        this.requests = result;
        this.filteredRequests = result;
      });
    }

    deleteRequest(id: number){

      this.courseService.deleteRequest(id).subscribe(result => {
        const removeIndex = this.requests.findIndex( item => item.id === id );
        this.requests.splice( removeIndex, 1 );

        this.toastService.showSuccess("Request deleted");
      });
    }

    search(searchText: string){
      this.filteredRequests = this.requests.filter(request => {
        const term = searchText.toLowerCase();
        return request.course.title.toLowerCase().includes(term)
            || request.student.name.toLowerCase().includes(term)
            || request.student.surname.toLowerCase().includes(term)
            || request.readyToStartDate.toString().toLowerCase().includes(term);
      });
    }
}