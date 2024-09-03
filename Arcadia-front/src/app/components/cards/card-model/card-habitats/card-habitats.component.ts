import { CommonModule } from '@angular/common';
import { Component, Input } from '@angular/core';
import { AnimalDto } from '../../../../interfaces/admin/animal';
import { ArcadiaService } from '../../../../services/arcadia/arcadia.service';
import { AnimalModalComponent } from '../../../modals/animal-modal/animal-modal.component';

@Component({
  selector: 'app-card-habitats',
  standalone: true,
  imports: [CommonModule, AnimalModalComponent],
  templateUrl: './card-habitats.component.html',
  styleUrls: ['./card-habitats.component.scss'],
})
export class CardHabitatsComponent {
  @Input() cardImage: string = '';
  @Input() cardTitle: string = '';
  @Input() cardMessage: string = '';
  @Input() verticalPosition?: string = '50%';

  @Input() animals: AnimalDto[];

  selectedAnimal: AnimalDto;
  showOverlay: boolean = false;

  constructor(private service: ArcadiaService) {}

  incrementViews(animal: AnimalDto): void {
    if (animal.id != null) {
      this.service.incrementAnimalViews(animal.id).subscribe();
      this.selectedAnimal = animal;
    }
  }
}
