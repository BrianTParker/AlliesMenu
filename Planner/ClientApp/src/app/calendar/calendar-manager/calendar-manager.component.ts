import { Component, OnInit, ViewChild } from "@angular/core";
import { CalendarComponent } from "ng-fullcalendar";
import { Options } from "fullcalendar";
import { data } from "jquery";

@Component({
  selector: "app-calendar-manager",
  templateUrl: "./calendar-manager.component.html",
  styleUrls: ["./calendar-manager.component.css"]
})
export class CalendarManagerComponent implements OnInit {
  calendarOptions: Options;
  @ViewChild(CalendarComponent) ucCalendar: CalendarComponent;
  constructor() {}
  ngOnInit() {
    this.calendarOptions = {
      editable: true,
      eventLimit: false,
      header: {
        left: "prev,next today",
        center: "title",
        right: "month,agendaWeek,agendaDay,listMonth"
      },
      selectable: true,
      events: []
    };
  }

  dayClick(something: any) {
    console.log(something.date);
  }
}
