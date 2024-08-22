import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable, Subject, take } from 'rxjs';
import { environment } from '../../../../environment';
import { Role } from '../../interfaces/user';

@Injectable({
  providedIn: 'root',
})
export class AccountService {
  private readonly _url = `${environment.apiUrl}`;

  role$ = new BehaviorSubject<Role | null>(null);
  isAuthenticated$ = new Subject<boolean>();

  constructor(private http: HttpClient) {}

  login(credentials: { email: string; password: string }): Observable<boolean> {
    return this.http.post<boolean>(`${this._url}/login`, credentials, {
      withCredentials: true,
    });
  }

  logout(): Observable<boolean> {
    return this.http.post<boolean>(
      `${this._url}/logout`,
      {},
      { withCredentials: true }
    );
  }

  checkAuthenticationState(): void {
    this.http
      .get<{ isAuthenticated: boolean; role: string }>(
        `${this._url}/isAuthenticated`,
        { withCredentials: true }
      )
      .pipe(take(1))
      .subscribe((result) => {
        this.role$.next(Role[result.role]);
        this.isAuthenticated$.next(result.isAuthenticated);
      });
  }
}
