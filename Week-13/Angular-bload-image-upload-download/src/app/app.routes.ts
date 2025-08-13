import { Routes } from '@angular/router';
import { ImageUpload } from './image-upload/image-upload';
import { ImageDownload } from './image-download/image-download';

export const routes: Routes = [
    { path: 'upload', component: ImageUpload },
    { path: 'download', component: ImageDownload },
];
