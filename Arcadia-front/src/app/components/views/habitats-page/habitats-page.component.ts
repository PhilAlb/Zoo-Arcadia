import { Component, OnInit } from '@angular/core';
import { ArcadiaService } from '../../../services/arcadia/arcadia.service';
import { CommonModule } from '@angular/common';
import { ICardHabitatsLayout } from '../../../interfaces/cardLayout/cardHabitatsLayout/ICardHabitatsLayout';
import { environment } from '../../../../../environment';
import { CardHabitatsComponent } from '../../cards/card-model/card-habitats/card-habitats.component';
import { IAnimalList } from '../../../interfaces/animalList/IAnimalList';

@Component({
  selector: 'app-habitats-page',
  standalone: true,
  imports: [CommonModule, CardHabitatsComponent],
  templateUrl: './habitats-page.component.html',
  styleUrl: './habitats-page.component.scss',
})
export class HabitatsPageComponent implements OnInit {
  readonly apiUrl = environment.apiUrl;

  cardHabitatsLayout: ICardHabitatsLayout[] = [];

  animals: any[][] = [];

  constructor(private service: ArcadiaService) {
    this.animals = [
      [
        {
          id: 1,
          name: 'Mufasa',
          race: 'Lion',
          imageUrl: 'assets/images/animals/lion1.jpg',
          habitatId: 1,
        },
        {
          id: 4,
          name: 'Po',
          race: 'Panda',
          imageUrl: 'assets/images/animals/panda1.jpg',
          habitatId: 1,
        },
      ],
      [
        {
          id: 3,
          name: 'Louis',
          race: 'Singe',
          imageUrl: 'assets/images/animals/monkey1.jpg',
          habitatId: 2,
        },
        {
          id: 2,
          name: 'Shere Khan',
          race: 'Tigre',
          imageUrl: 'assets/images/animals/tiger1.jpg',
          habitatId: 2,
        },
      ],
      [
        {
          id: 5,
          name: 'Angèle',
          race: 'Loutre',
          imageUrl: 'assets/images/animals/outter1.jpg',
          habitatId: 3,
        },
      ],
    ];
  }

  ngOnInit() {
    this.service
      .getAllHabitats()
      .subscribe(
        (data: ICardHabitatsLayout[]) => (this.cardHabitatsLayout = data)
      );
  }
}
