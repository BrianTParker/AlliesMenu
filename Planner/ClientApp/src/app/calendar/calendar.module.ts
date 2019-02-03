import { NgModule } from "@angular/core";
import { CommonModule } from "@angular/common";
import { CalendarManagerComponent } from "./calendar-manager/calendar-manager.component";
import { Routes, RouterModule } from "@angular/router";
import { FullCalendarModule } from "ng-fullcalendar";
const routes: Routes = [{ path: "", component: CalendarManagerComponent }];
@NgModule({
  declarations: [CalendarManagerComponent],
  imports: [CommonModule, RouterModule.forChild(routes), FullCalendarModule]
})
export class CalendarModule {}
