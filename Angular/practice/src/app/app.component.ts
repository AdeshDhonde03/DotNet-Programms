import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { VideoComponent } from './components/video/video.component';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet,VideoComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'practice';
}
