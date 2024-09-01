import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ICarouselAnimalsLayout } from '../../../interfaces/carouselAnimalsLayout/ICarouselAnimalsLayout';
import { CarouselAnimalsComponent } from '../../carousels/carousel-animals/carousel-animals.component';
import { ICardTestimonyLayout } from '../../../interfaces/cardLayout/cardTestimonyLayout/ICardTestimonyLayout';
import { ArcadiaService } from '../../../services/arcadia/arcadia.service';
import { ICardServicesLayout } from '../../../interfaces/cardLayout/cardServicesLayout/ICardServicesLayout';
import { ICardHabitatsLayout } from '../../../interfaces/cardLayout/cardHabitatsLayout/ICardHabitatsLayout';
import { TestimonyModalComponent } from '../../modals/testimony-modal/testimony-modal.component';
import { environment } from '../../../../../environment';
import { CardTestimonyComponent } from '../../cards/card-model/card-testimony/card-testimony.component';
import { CardModelComponent } from '../../cards/card-model/card-model.component';

@Component({
  selector: 'app-home-page',
  standalone: true,
  imports: [
    CommonModule,
    CardModelComponent,
    CarouselAnimalsComponent,
    CardTestimonyComponent,
    TestimonyModalComponent,
  ],
  templateUrl: './home-page.component.html',
  styleUrl: './home-page.component.scss',
})
export class HomePageComponent implements OnInit {
  readonly apiUrl = environment.apiUrl;

  cardHabitatLayout: ICardHabitatsLayout[] = [];
  cardServiceLayout: ICardServicesLayout[] = [];
  carouselLayout: ICarouselAnimalsLayout[] = [];
  cardTestimonyLayout: ICardTestimonyLayout[] = [];
  carouselAnimalsLayout: ICarouselAnimalsLayout[];

  constructor(private service: ArcadiaService) {}

  ngOnInit() {
    this.service
      .getAllHabitats()
      .subscribe(
        (data: ICardHabitatsLayout[]) => (this.cardHabitatLayout = data)
      );

    this.service
      .getAllServices()
      .subscribe(
        (data: ICardServicesLayout[]) => (this.cardServiceLayout = data)
      );

    this.service
      .getCarouselAnimals()
      .subscribe(
        (data: ICarouselAnimalsLayout[]) => (this.carouselLayout = data)
      );

    this.service
      .getTestimonies()
      .subscribe(
        (data: ICardTestimonyLayout[]) => (this.cardTestimonyLayout = data)
      );
  }
}
