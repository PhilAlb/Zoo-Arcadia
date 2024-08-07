import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { environment } from '../../../../environment';
import { Testimony } from '../../interfaces/testimony';

@Injectable({
  providedIn: 'root'
})
export class TestimonyService {
  private readonly _url = `${environment.apiUrl}/admin/testimonies`;

  constructor(private http: HttpClient) {}

  getTestimonies(): Observable<Testimony[]> {
    return this.http.get<Testimony[]>(this._url);
  }

  addTestimony(testimony: Testimony): Observable<boolean> {
    return this.http.post<boolean>(this._url, testimony);
  }

  updateTestimony(testimony: Testimony): Observable<boolean> {
    return this.http.put<boolean>(`${this._url}/${testimony.id}`, testimony);
  }

  deleteTestimony(id: number): Observable<boolean> {
    return this.http.delete<boolean>(`${this._url}/${id}`);
  }

}
