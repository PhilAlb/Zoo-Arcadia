import { Component, Input } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CardModelComponent } from '../../cards/card-model/card-model.component';


@Component({
  selector: 'app-carousel-model',
  standalone: true,
  imports: [ CommonModule, CardModelComponent ],
  templateUrl: './carousel-model.component.html',
  styleUrl: './carousel-model.component.scss'
})
export class CarouselModelComponent {
  @Input() items: any[];
  @Input() interval: number = 3000;
  @Input() slideTemplate: any;  

  constructor() { }
}
