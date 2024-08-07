import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from '../../../../environment';
import { ICardHabitatsLayout } from '../../interfaces/cardLayout/cardHabitatsLayout/ICardHabitatsLayout';
import { ICardServicesLayout } from '../../interfaces/cardLayout/cardServicesLayout/ICardServicesLayout';
import { ICardTestimonyLayout } from '../../interfaces/cardTestimonyLayout/ICardTestimonyLayout';
import { ICarouselLayout } from '../../interfaces/carouselLayout/ICarouselLayout';

@Injectable({
  providedIn: 'root',
})
export class ArcadiaService {
  private readonly _url = environment.apiUrl;

  constructor(private http: HttpClient) {}
  getAllHabitats(): Observable<ICardHabitatsLayout[]> {
    return this.http.get<ICardHabitatsLayout[]>(this._url + '/habitats');
  }

  getAllServices(): Observable<ICardServicesLayout[]> {
    return this.http.get<ICardServicesLayout[]>(this._url + '/services');
  }

  getCarouselAnimals(): Observable<ICarouselLayout[]> {
    return this.http.get<ICarouselLayout[]>(this._url + '/animals');
  }

  getTestimonies(): Observable<ICardTestimonyLayout[]> {
    return this.http.get<ICardTestimonyLayout[]>(this._url + '/testimonies');
  }

  addTestimonies(testimony: ICardTestimonyLayout): Observable<boolean> {
    return this.http.post<boolean>(this._url + '/testimonies', testimony);
  }
}
