import { Injectable } from '@angular/core';
import { Post } from '../models/post.model';

@Injectable({
  providedIn: 'root'
})
export class PostService {
  private posts: Post[] = [
    {
      id: 1,
      title: 'Product Launch',
      description: 'Excited to announce our new AI-powered automation tool #ProductLaunch #AI',
      platform: 'Twitter',
      date: new Date('2025-04-10T09:00:00')
    },
    {
      id: 2,
      title: 'Customer Success Story',
      description: 'Company XYZ improved efficiency by 40% using our platform!',
      platform: 'LinkedIn',
      date: new Date('2025-04-12T14:00:00')
    },
    {
      id: 3,
      title: 'Weekend Promotion',
      description: 'Get 20% off! Use code WEEKEND20 at checkout.',
      platform: 'Facebook',
      date: new Date('2025-04-12T10:00:00')
    }
  ];

  getPosts(): Post[] {
    return this.posts;
  }

  addPost(post: Post) {
    post.id = this.posts.length + 1;
    this.posts.push(post);
  }

  updatePost(updatedPost: Post) {
    const index = this.posts.findIndex(p => p.id === updatedPost.id);
    if (index !== -1) {
      this.posts[index] = { ...updatedPost };
    }
  }

  deletePost(id: number) {
    this.posts = this.posts.filter(post => post.id !== id);
  }
}
