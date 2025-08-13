import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-image-download',
  imports: [CommonModule],
  templateUrl: './image-download.html',
  styleUrl: './image-download.css'
})
export class ImageDownload implements OnInit {
  imageUrls: any[] = []
  constructor(private http: HttpClient) { }
  ngOnInit(): void {
    this.http.get<any[]>('http://localhost:5199/api/Storage/GetImageUrls').subscribe(
      (data: any[]) => {
        this.imageUrls = data;
        console.log(this.imageUrls);
      }
    );
  }
}
