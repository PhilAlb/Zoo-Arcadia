import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from '../../../../environment';
import { ICardHabitatsLayout } from '../../interfaces/cardLayout/cardHabitatsLayout/ICardHabitatsLayout';
import { ICardServicesLayout } from '../../interfaces/cardLayout/cardServicesLayout/ICardServicesLayout';
import { ICardTestimonyLayout } from '../../interfaces/cardLayout/cardTestimonyLayout/ICardTestimonyLayout';
import { ICarouselAnimalsLayout } from '../../interfaces/carouselAnimalsLayout/ICarouselAnimalsLayout';
import { Contact } from '../../interfaces/admin/contact';
import { IAnimalList } from '../../interfaces/animalList/IAnimalList';

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

  getCarouselAnimals(): Observable<ICarouselAnimalsLayout[]> {
    return this.http.get<ICarouselAnimalsLayout[]>(this._url + '/animals');
  }

  getTestimonies(): Observable<ICardTestimonyLayout[]> {
    return this.http.get<ICardTestimonyLayout[]>(this._url + '/testimonies');
  }

  getAllAnimalList(): Observable<IAnimalList[]> {
    return this.http.get<IAnimalList[]>(this._url + '/habitats/animals');
  }

  addTestimonies(testimony: ICardTestimonyLayout): Observable<boolean> {
    return this.http.post<boolean>(this._url + '/testimonies', testimony);
  }

  addContacts(contact: Contact): Observable<boolean> {
    return this.http.post<boolean>(this._url + '/contacts', contact);
  }
}
