import { NgModule } from "@angular/core";
import { DndDirective } from "./directives/drag-and-drop.directive";
import { NavMenuComponent } from "./nav-menu/nav-menu.component";

@NgModule({
    declarations: [ 
        NavMenuComponent,
        DndDirective
    ],
    exports: [ 
        NavMenuComponent,
        DndDirective
    ]
})
export class SharedModule { }