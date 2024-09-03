import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HabitatDto } from '../../interfaces/admin/habitat';
import { environment } from '../../../../environment';

@Injectable({
  providedIn: 'root',
})
export class HabitatService {
  private readonly _url = `${environment.apiUrl}/admin/habitats`;

  constructor(private http: HttpClient) {}

  getHabitats(): Observable<HabitatDto[]> {
    return this.http.get<HabitatDto[]>(this._url, { withCredentials: true });
  }

  addHabitat(habitat: HabitatDto): Observable<boolean> {
    let h = new FormData();

    h.append('title', habitat.title);
    h.append('description', habitat.description);
    if (habitat.image) h.append('image', habitat.image);

    return this.http.post<boolean>(this._url, h, { withCredentials: true });
  }

  updateHabitat(habitat: HabitatDto): Observable<boolean> {
    return this.http.put<boolean>(`${this._url}/${habitat.id}`, habitat, {
      withCredentials: true,
    });
  }

  deleteHabitat(id: number): Observable<boolean> {
    return this.http.delete<boolean>(`${this._url}/${id}`, {
      withCredentials: true,
    });
  }
}
