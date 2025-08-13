import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
@Component({
  selector: 'app-image-upload',
  imports: [FormsModule, CommonModule],
  templateUrl: './image-upload.html',
  styleUrl: './image-upload.css'
})
export class ImageUpload {
  selectedFile?: File;
  uploadResponse: any;
  constructor(private http: HttpClient) { }
  onFileSelected(event: any): void {
    this.selectedFile = event.target.files[0];
  }
  onUpload() {
    if (this.selectedFile) {
      const formData = new FormData();
      formData.append('file', this.selectedFile);
      this.http.post('http://localhost:5199/api/Storage/Upload', formData).subscribe(
        {
          next: (res) => {
            this.uploadResponse = res;
            console.log('Upload success:', res);
          },
          error: (err) => {
            console.error('Upload failed:', err);
          }
        });
    }

  }
}