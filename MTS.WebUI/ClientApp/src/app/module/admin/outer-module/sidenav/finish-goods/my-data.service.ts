import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class MyDataService {
  url = 'https://dummyjson.com/products/1';
  constructor(private http: HttpClient) { }
  getData1() {
    return this.http.get(this.url);
  }
}
