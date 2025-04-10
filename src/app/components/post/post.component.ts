import { Component } from '@angular/core';
import {Post} from '../../models/post.model';
import { PostService } from '../../services/post.service';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';


@Component({
  selector: 'app-post',
  standalone: true, // ✅ Standalone component
  templateUrl: './post.component.html',
  styleUrls: ['./post.component.css'],
  imports: [CommonModule, FormsModule] // ✅ Import necessary Angular modules
})
export class PostComponent {
  posts: Post[] = [];
  filteredPosts: Post[] = [];
  selectedPlatform: string = '';
  searchText: string = '';
  isEdit: boolean = false;
  currentPost: Post = this.resetPost();

  constructor(private postService: PostService) {}

  ngOnInit() {
    this.loadPosts();
  }

  loadPosts() {
    this.posts = this.postService.getPosts();
    this.filteredPosts = this.posts;
  }

  resetPost(): Post {
    return {
      id: 0,
      title: '',
      description: '',
      platform: 'Twitter',
      date: new Date()
    };
  }

  savePost() {
    if (this.isEdit) {
      this.postService.updatePost(this.currentPost);
    } else {
      this.postService.addPost(this.currentPost);
    }
    this.currentPost = this.resetPost();
    this.isEdit = false;
    this.loadPosts();
  }

  editPost(post: Post) {
    this.currentPost = { ...post };
    this.isEdit = true;
  }

  deletePost(id: number) {
    this.postService.deletePost(id);
    this.loadPosts();
  }

  filterPosts() {
    this.filteredPosts = this.posts.filter(post => {
      return (
        (!this.selectedPlatform || post.platform === this.selectedPlatform) &&
        (post.title.toLowerCase().includes(this.searchText.toLowerCase()) ||
         post.description.toLowerCase().includes(this.searchText.toLowerCase()))
      );
    });
  }
}
