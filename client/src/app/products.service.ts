import { HttpClient } from "@angular/common/http"
import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ProductsService {
apiUrl = "https://localhost:7141/api/products?pageSize=50";
products : any[];
  constructor(private http: HttpClient) { }

   getProducts(){
    return this.http.get(this.apiUrl);
  }
}
