import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { CounterComponent } from '../components/counter/counter.component';
import { EmployeeTableComponent } from '../employee-table/employee-table.component';
CounterComponent
@Component({
  selector: 'app-root',
  imports: [
    RouterOutlet,
    EmployeeTableComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'angular-app';

  count:number=111;
}
