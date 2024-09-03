import { CommonModule } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { environment } from '../../../../../environment';
import { IAnimalPerHabitat } from '../../../interfaces/animalList/IAnimalList';
import { ArcadiaService } from '../../../services/arcadia/arcadia.service';
import { CardHabitatsComponent } from '../../cards/card-model/card-habitats/card-habitats.component';

@Component({
  selector: 'app-habitats-page',
  standalone: true,
  imports: [CommonModule, CardHabitatsComponent],
  templateUrl: './habitats-page.component.html',
  styleUrl: './habitats-page.component.scss',
})
export class HabitatsPageComponent implements OnInit {
  readonly apiUrl = environment.apiUrl;
  animalListWithHabitat: IAnimalPerHabitat[] = [];

  constructor(private service: ArcadiaService) {}

  ngOnInit() {
    this.service
      .getAllAnimalList()
      .subscribe((data: IAnimalPerHabitat[]) => (this.animalListWithHabitat = data));
  }
}
