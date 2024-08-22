import { Component, Input } from '@angular/core';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-card-model',
  standalone: true,
  imports: [ CommonModule ],
  templateUrl: './card-model.component.html',
  styleUrl: './card-model.scss'
})
export class CardModelComponent {
  @Input() cardImage: string="";
  @Input() cardTitle: string="";
  @Input() index: number=0;
  @Input() verticalPosition?: string="50%";
}

