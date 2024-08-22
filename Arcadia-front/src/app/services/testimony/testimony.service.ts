import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { environment } from '../../../../environment';
import { TestimonyDto } from '../../interfaces/testimony';

@Injectable({
  providedIn: 'root',
})
export class TestimonyService {
  private readonly _url = `${environment.apiUrl}/admin/testimonies`;

  constructor(private http: HttpClient) {}

  getTestimonies(): Observable<TestimonyDto[]> {
    return this.http.get<TestimonyDto[]>(this._url, { withCredentials: true });
  }

  addTestimony(testimony: TestimonyDto): Observable<boolean> {
    return this.http.post<boolean>(this._url, testimony, {
      withCredentials: true,
    });
  }

  updateTestimony(testimony: TestimonyDto): Observable<boolean> {
    return this.http.put<boolean>(`${this._url}/${testimony.id}`, testimony, {
      withCredentials: true,
    });
  }

  deleteTestimony(id: number): Observable<boolean> {
    return this.http.delete<boolean>(`${this._url}/${id}`, {
      withCredentials: true,
    });
  }
}
