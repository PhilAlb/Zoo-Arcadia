import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from '../../../../environment';
import { AnimalDto } from '../../interfaces/admin/animal';

@Injectable({
  providedIn: 'root',
})
export class AnimalService {
  private readonly _url = `${environment.apiUrl}/admin/animals`;

  constructor(private http: HttpClient) {}

  getAnimals(): Observable<AnimalDto[]> {
    return this.http.get<AnimalDto[]>(this._url, { withCredentials: true });
  }

  addAnimal(animal: AnimalDto): Observable<boolean> {
    let a = new FormData();

    a.append('name', animal.name);
    a.append('race', animal.race);
    a.append('comment', animal.comment ?? "");
    if (animal.associatedHabitatId)
      a.append('associatedHabitatId', animal.associatedHabitatId.toString());
    if (animal.image) a.append('image', animal.image);

    return this.http.post<boolean>(this._url, a, { withCredentials: true });
  }

  updateAnimal(animal: AnimalDto): Observable<boolean> {
    return this.http.put<boolean>(`${this._url}/${animal.id}`, animal, {
      withCredentials: true,
    });
  }

  deleteAnimal(id: number): Observable<boolean> {
    return this.http.delete<boolean>(`${this._url}/${id}`, {
      withCredentials: true,
    });
  }
}
