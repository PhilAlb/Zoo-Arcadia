import { Component, Input } from '@angular/core';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-testimonies',
  standalone: true,
  imports: [ CommonModule ],
  templateUrl: './testimonies.component.html',
  styleUrls: ['./testimonies.component.css']
})
export class CarouselTestimoniesComponent {
  @Input() testimonyChunk: any[];
  @Input() isFirst: boolean;

  constructor() { }
}
