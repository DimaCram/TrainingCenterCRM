import { Component } from "@angular/core";
import { Title } from "@angular/platform-browser";
import { Router } from "@angular/router";
import { group } from "console";
import { NgxUiLoaderService } from "ngx-ui-loader";
import { Group } from "src/app/models/group.model";
import { GroupService } from "src/app/services/group.service";

@Component({
    selector: 'student-groups',
    templateUrl: './student-groups.component.html'
})

export class StudentGroupsComponent{
    private studentGroups: Group[] = [];
    public filteredStudentGroups: Group[] = [];

    public page = 1;
    public pageSize = 5;

    constructor(private titleService: Title,
                private groupService: GroupService,
                private ngxService: NgxUiLoaderService,
                private router: Router){}

    ngOnInit(): void {
        this.titleService.setTitle("Student groups - Training Center")

        this.ngxService.startLoader("groupsLoader");

        this.groupService.getStudentGroups().subscribe(res => {
            this.ngxService.stopLoader("groupsLoader");
            this.studentGroups = res;
            this.filteredStudentGroups = res;
        })
    }

    search(searchText: string){
        this.filteredStudentGroups = this.studentGroups.filter(group => {
          const term = searchText.toLowerCase();
          return group.name.toLowerCase().includes(term)
              || group.startDate.toString().includes(term)
              || group.course.title.toLowerCase().includes(term);
        });
    }

    goToGroup(groupId){
        localStorage.setItem("groupId", groupId);
        this.router.navigate(['student/group'])
    }
}