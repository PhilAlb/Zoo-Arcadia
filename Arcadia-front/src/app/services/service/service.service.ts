import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ServiceDto } from '../../interfaces/service';
import { HttpClient } from '@angular/common/http';
import { environment } from '../../../../environment';

@Injectable({
  providedIn: 'root',
})
export class ServiceService {
  private readonly _url = `${environment.apiUrl}/admin/services`;

  constructor(private http: HttpClient) {}

  getServices(): Observable<ServiceDto[]> {
    return this.http.get<ServiceDto[]>(this._url, { withCredentials: true });
  }

  addService(service: ServiceDto): Observable<boolean> {
    let s = new FormData();

    s.append('title', service.title);
    s.append('description', service.description);
    s.append('schedules', service.schedules);
    if (service.image) s.append('image', service.image);

    return this.http.post<boolean>(this._url, s, { withCredentials: true });
  }

  updateService(service: ServiceDto): Observable<boolean> {
    return this.http.put<boolean>(`${this._url}/${service.id}`, service, {
      withCredentials: true,
    });
  }

  deleteService(id: number): Observable<boolean> {
    return this.http.delete<boolean>(`${this._url}/${id}`, {
      withCredentials: true,
    });
  }
}
