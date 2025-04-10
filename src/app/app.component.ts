import { Component } from '@angular/core';
import { PostComponent } from './components/post/post.component'; // ✅ Import your component here

@Component({
  selector: 'app-root',
  standalone: true, // 👈 Since you're using standalone
  imports: [PostComponent], // ✅ You MUST import other components
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {}
