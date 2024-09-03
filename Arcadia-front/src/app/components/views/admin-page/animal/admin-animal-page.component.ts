import { Component, OnInit } from '@angular/core';
import { AnimalDto } from '../../../../interfaces/admin/animal';
import { AnimalService } from '../../../../services/animal/animal.service';
import { ConfirmationModalComponent } from '../../../modals/confirmation-modal/confirmation-modal.component';
import { AddAnimalFormComponent } from '../forms/add-animal-form/add-animal-form.component';
import { EditAnimalFormComponent } from '../forms/edit-animal-form/edit-animal-form.component';
import { AccountService } from '../../../../services/account/account.service';
import { Role } from '../../../../interfaces/admin/user';

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
  readonly Roles = Role;
  currentRole: Role;
  list: AnimalDto[] = [];

  constructor(
    private service: AnimalService,
    private accountService: AccountService
  ) {}

  ngOnInit(): void {
    this.accountService.role$.subscribe((role) => {
      if (role != null) this.currentRole = role;
    });

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

  restartViews(animal: AnimalDto): void {
    animal.views = 0;
    this.service.updateAnimal(animal).subscribe(() => this.getList());
  }
}
