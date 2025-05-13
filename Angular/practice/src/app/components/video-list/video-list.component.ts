import { Component } from '@angular/core';
import { VideoDetails } from '../../Models/VideoDetails';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-video-list',
  imports: [VideoListComponent,CommonModule],
  templateUrl: './video-list.component.html',
  styleUrl: './video-list.component.css'
})
export class VideoListComponent {
  videoList: VideoDetails[] = [
    new VideoDetails("Video1","Java Vudeo lecture for placement","https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcTXTh1kw62UR14WlTAPhUKuYDDjXZ2DZlOG8VYIVsqVOWklo8p-OXhYkuSN26sPXQei5btq54L8wAS0YKZOWbme_g","C:\Users\hp\OneDrive\Desktop\Angular\practice\public\assets\WIN_20250222_10_34_51_Pro.mp4")
  ]

}
