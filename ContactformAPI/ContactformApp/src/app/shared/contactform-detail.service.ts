import { Injectable } from '@angular/core';
import { ContactformDetail } from './contactform-detail.model';
import { HttpClient } from "@angular/common/http";
import { ThrowStmt } from '@angular/compiler';

@Injectable({
  providedIn: 'root'
})
export class ContactformDetailService {

  constructor(private http: HttpClient) { }

  readonly baseURL = 'http://abobus-001-site1.itempurl.com/api/ContactformDb'
  formData: ContactformDetail = new ContactformDetail();
  list: ContactformDetail[];

  postContactformDetail() {
    return this.http.post(this.baseURL, this.formData);
  }

  }
