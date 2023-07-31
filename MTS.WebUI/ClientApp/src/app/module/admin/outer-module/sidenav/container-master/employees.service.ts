import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Employees } from './employee.model';
import { environment } from '../../../../../../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class EmployeesService { 
  baseApiUrl: string = environment.baseApiUrl;
  constructor(private http: HttpClient) { }

  getAllEmployees1(): Observable<Employees[]> {
    return this.http.get<Employees[]>(this.baseApiUrl + '/api/v1/employees')
  }

}
