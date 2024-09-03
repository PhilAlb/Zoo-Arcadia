import { Component, OnInit } from '@angular/core';
import { AnimalDto } from '../../../../interfaces/admin/animal';
import { AnimalService } from '../../../../services/animal/animal.service';
import { ConfirmationModalComponent } from '../../../modals/confirmation-modal/confirmation-modal.component';
import { AddAnimalFormComponent } from '../forms/add-animal-form/add-animal-form.component';
import { EditAnimalFormComponent } from '../forms/edit-animal-form/edit-animal-form.component';

@Component({
  selector: 'app-admin-animal-page',
  standalone: true,
  imports: [
    AddAnimalFormComponent,
    EditAnimalFormComponent,
    ConfirmationModalComponent,
  ],
  templateUrl: './admin-animal-page.component.html',
  styleUrl: './admin-animal-page.component.scss',
})
export class AdminAnimalPageComponent implements OnInit {
  list: AnimalDto[] = [];

  constructor(private service: AnimalService) {}

  ngOnInit(): void {
    this.getList();
  }

  getList(): void {
    this.service
      .getAnimals()
      .subscribe((data: AnimalDto[]) => (this.list = data));
  }

  add(animal: AnimalDto): void {
    this.service.addAnimal(animal).subscribe(() => this.getList());
  }

  edit(animal: AnimalDto): void {
    this.service.updateAnimal(animal).subscribe(() => this.getList());
  }

  delete(id: number): void {
    this.service
      .deleteAnimal(id)
      .subscribe(() => (this.list = this.list.filter((item) => item.id != id)));
  }
}
