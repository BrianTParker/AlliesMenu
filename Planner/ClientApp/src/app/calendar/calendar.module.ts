import { NgModule } from "@angular/core";
import { CommonModule } from "@angular/common";
import { ManageCalendarComponent } from "./manage-calendar/manage-calendar.component";
import { Routes, RouterModule } from "@angular/router";

const routes: Routes = [{ path: "", component: ManageCalendarComponent }];
@NgModule({
  declarations: [ManageCalendarComponent],
  imports: [CommonModule, RouterModule.forChild(routes)]
})
export class CalendarModule {}
