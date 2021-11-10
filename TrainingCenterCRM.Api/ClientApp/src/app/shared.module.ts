import { NgModule } from "@angular/core";
import { NgxUiLoaderModule } from "ngx-ui-loader";
import { DndDirective } from "./directives/drag-and-drop.directive";
import { NavMenuComponent } from "./nav-menu/nav-menu.component";

@NgModule({
    imports: [
        NgxUiLoaderModule,
      ],
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