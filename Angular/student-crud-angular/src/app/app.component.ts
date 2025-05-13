import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { StudentCrudComponent } from '../student/student-crud/student-crud.component';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet,
    StudentCrudComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'student-crud-angular';
}
