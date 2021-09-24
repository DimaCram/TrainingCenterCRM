import { Component } from "@angular/core";
import { Group } from "src/app/models/group.model";
import { GroupService } from "src/app/services/group.service";
import { TeacherService } from "src/app/services/teacher.service";

@Component({
    selector: 'manager-group-all',
    templateUrl: './group-all.component.html'
})


export class GroupAllComponent{
    public groups: Group[];

    constructor(private groupService: GroupService){}

    ngOnInit(): void {
      this.groupService.getGroups().subscribe(result => {
        this.groups = result;
        console.log(result)
      },
      error => {console.error(error);});
    }

    deleteGroup(id: number){

      this.groupService.deleteGroup(id).subscribe(result => {
        const removeIndex = this.groups.findIndex( item => item.id === id );
        this.groups.splice( removeIndex, 1 );
      },
      error => {console.error(error);});
    }
}