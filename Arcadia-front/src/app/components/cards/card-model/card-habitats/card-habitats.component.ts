import { Component, Input, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ArcadiaService } from '../../../../services/arcadia/arcadia.service';
import { IAnimalList } from '../../../../interfaces/animalList/IAnimalList';

@Component({
  selector: 'app-card-habitats',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './card-habitats.component.html',
  styleUrls: ['./card-habitats.component.scss'],  
})
export class CardHabitatsComponent implements OnInit {
  @Input() cardImage: string = '';
  @Input() cardTitle: string = '';
  @Input() cardMessage: string = '';
  @Input() verticalPosition?: string = '50%';

  @Input() animals: IAnimalList[];

  showOverlay: boolean = false;

  // Liste des animaux par carte
  // private cardAnimalLists: { [key: string]: string[] } = {
  //  'Savane': ['Lion'],
  //  'Jungle': ['Tigre', 'Singe', 'Panda'],
  //  'Marais': ['Loutre']
  // };

  //get animals(): string[] {
  //  return this.cardAnimalLists[this.cardTitle] || [];
  // };

  animalList: any = [];

  constructor(private service: ArcadiaService) {
  }

  ngOnInit() {
    this.service
      .getAllAnimalList()
      .subscribe((data) => (this.animalList = data));
  }
}
