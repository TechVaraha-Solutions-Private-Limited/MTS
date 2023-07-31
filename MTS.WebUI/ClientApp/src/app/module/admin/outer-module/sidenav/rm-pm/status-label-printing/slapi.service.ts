import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class SLApiService {
  constructor(private http: HttpClient) { }

  getDynamicData(apiUrl: string): Observable<any> {
    return this.http.get<any>(apiUrl);
  }
}
