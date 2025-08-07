import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Product } from '../product';
import { CommonModule } from '@angular/common';
@Component({
  selector: 'app-view-products',
  imports: [CommonModule],
  templateUrl: './view-products.html',
  styleUrl: './view-products.css'
})
export class ViewProducts implements OnInit {
  products: Product[] = [];

  constructor(private http: HttpClient) {

  }
  ngOnInit(): void {
    this.http.get<Product[]>('http://localhost:5197/api/Product/GetAllProducts',
      { headers: { 'Authorization': `Bearer ${localStorage.getItem('jwt')} ` } }) // Replace YOUR_JWT_TOKEN with your actual JWT token)
      .subscribe((response) => {
        this.products = response;
      });
  }
}
