import { Injectable } from '@angular/core';
import { environment } from '../../../../environment';
import { HttpClient } from '@angular/common/http';
import { UserDto } from '../../interfaces/admin/user';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class UserService {
  private readonly _url = `${environment.apiUrl}/admin/users`;

  constructor(private http: HttpClient) {}

  getUsers(): Observable<UserDto[]> {
    return this.http.get<UserDto[]>(this._url, { withCredentials: true });
  }

  addUser(user: UserDto): Observable<boolean> {
    return this.http.post<boolean>(this._url, user, { withCredentials: true });
  }

  updateUser(user: UserDto): Observable<boolean> {
    return this.http.put<boolean>(`${this._url}/${user.id}`, user, {
      withCredentials: true,
    });
  }

  deleteUser(id: number): Observable<boolean> {
    return this.http.delete<boolean>(`${this._url}/${id}`, {
      withCredentials: true,
    });
  }
}
