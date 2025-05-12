export class VideoDetails{
    tittle:string;
    description:string;
    thumbnailUrl:string;
    videoUrl:string;

    constructor(tittle:string,
        description:string,
        thumbnailUrl:string,
        videoUrl:string){
            this.tittle=tittle;
            this.description = description;
            this.thumbnailUrl = thumbnailUrl;
            this.videoUrl = videoUrl;
    }


}