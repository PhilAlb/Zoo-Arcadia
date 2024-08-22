import { Component, Input } from '@angular/core';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-carousel-animals',
  standalone: true,
  imports: [ CommonModule ],
  templateUrl: './carousel-animals.component.html',
  styleUrl: './carousel-animals.component.scss'
})
export class CarouselAnimalsComponent {
  @Input() carouselImage: string="";
  @Input() animalName: string="";
  @Input() isFirst: boolean;

  constructor() { }
}
