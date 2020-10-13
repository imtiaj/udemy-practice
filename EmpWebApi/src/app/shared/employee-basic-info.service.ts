import { Injectable } from '@angular/core';
import { EmployeeBasicInfo } from './employee-basic-info.model';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})

export class EmployeeBasicInfoService {
  formData: EmployeeBasicInfo
  baseUrl:string = 'http://localhost:12074/api/v1/';

  constructor(private http:HttpClient) { }

  postEmployeeDetail(formData:EmployeeBasicInfo){
    return this.http.post(this.baseUrl + 'Employee',formData);
  }

  getEmployeeDetail(){
    return this.http.get<EmployeeBasicInfo[]>(this.baseUrl + 'Employee');
  }

  deleteEmployee(email) {
    // debugger;
    return this.http.delete(this.baseUrl + "Employee/" + email);
  }
}
