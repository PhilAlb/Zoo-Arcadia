import { Injectable } from '@angular/core';
import { environment } from '../../../../environment';
import { HttpClient } from '@angular/common/http';
import { Contact } from '../../interfaces/admin/contact';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class ContactService {
  private readonly _url = `${environment.apiUrl}/admin/contacts`;

  constructor(private http: HttpClient) {}

  getContacts(): Observable<Contact[]> {
    return this.http.get<Contact[]>(this._url, { withCredentials: true });
  }

  deleteContact(id: number): Observable<boolean> {
    return this.http.delete<boolean>(`${this._url}/${id}`, {
      withCredentials: true,
    });
  }
}
