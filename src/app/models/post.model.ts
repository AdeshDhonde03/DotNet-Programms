export interface Post {
    id: number;
    title: string;
    description: string;
    platform: 'Twitter' | 'LinkedIn' | 'Facebook';
    date: Date;
  }
  