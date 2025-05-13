import { Component, Input } from '@angular/core';
import { VideoDetails } from '../../Models/VideoDetails';

@Component({
  selector: 'app-video',
  imports: [VideoComponent],
  templateUrl: './video.component.html',
  styleUrl: './video.component.css'
})
export class VideoComponent {
 @Input() videoDetails:VideoDetails = new VideoDetails("","","","");

}
