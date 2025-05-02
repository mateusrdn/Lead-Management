import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from '../../../environments/environment';
import { Lead } from '../models/lead';

@Injectable({
  providedIn: 'root',
})
export class LeadService {

  private readonly apiUrl = environment.API_URL;

  constructor(private http: HttpClient) {}

  getLeads(status: number) {
    return this.http.get<Lead[]>(`${this.apiUrl}/lead/${status}`);
  }

  putAccept(id: number) {
    return this.http.put(`${this.apiUrl}/lead/accept/${id}`, {});
  }

  putDecline(id: number){
    return this.http.put(`${this.apiUrl}/lead/decline/${id}`, {});
  }
  
}