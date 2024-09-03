import { Component, Input } from '@angular/core';
import { environment } from '../../../../../environment';
import { AnimalDto } from '../../../interfaces/admin/animal';

@Component({
  selector: 'app-animal-modal',
  standalone: true,
  imports: [],
  templateUrl: './animal-modal.component.html',
  styleUrl: './animal-modal.component.scss',
})
export class AnimalModalComponent {
  readonly apiUrl = environment.apiUrl;
  @Input() animal: AnimalDto;
  @Input() title: string;
}
