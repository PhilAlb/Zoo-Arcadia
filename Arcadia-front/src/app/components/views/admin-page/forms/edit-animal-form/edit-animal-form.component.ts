import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import {
  FormBuilder,
  FormControl,
  FormGroup,
  FormsModule,
  ReactiveFormsModule,
  Validators,
} from '@angular/forms';
import { AnimalDto } from '../../../../../interfaces/admin/animal';
import { HabitatDto } from '../../../../../interfaces/admin/habitat';
import { HabitatService } from '../../../../../services/habitat/habitat.service';
import { Role } from '../../../../../interfaces/admin/user';

@Component({
  selector: 'app-edit-animal-form',
  standalone: true,
  imports: [FormsModule, ReactiveFormsModule],
  templateUrl: './edit-animal-form.component.html',
  styleUrl: './edit-animal-form.component.scss',
})
export class EditAnimalFormComponent implements OnInit {
  readonly Roles = Role;

  editForm: FormGroup;
  readonly formControls = {
    name: 'name',
    race: 'race',
    comment: 'comment',
  };

  @Output() onSubmit = new EventEmitter<AnimalDto>();
  @Input() selectedAnimal: AnimalDto;
  @Input() currentRole: Role;

  habitats: HabitatDto[] = [];
  selectedHabitat?: HabitatDto;

  constructor(
    private formBuilder: FormBuilder,
    private habitatService: HabitatService
  ) {}

  ngOnInit(): void {
    this.editForm = this.formBuilder.group({
      [this.formControls.name]: new FormControl(this.selectedAnimal.name, {
        validators: Validators.compose([Validators.required]),
      }),
      [this.formControls.race]: new FormControl(this.selectedAnimal.race, {
        validators: Validators.compose([Validators.required]),
      }),
      [this.formControls.comment]: new FormControl(this.selectedAnimal.comment),
    });

    if (this.currentRole != Role.Admin) {
      this.editForm.get('name')?.disable();
      this.editForm.get('race')?.disable();
    }

    this.habitatService.getHabitats().subscribe((data) => {
      this.habitats = data;
      this.selectedHabitat = this.habitats.find(
        (element) => element.title == this.selectedAnimal.associatedHabitatTitle
      );
    });
  }

  save(): void {
    const get = (x: string) => this.editForm.get(x)?.value;

    const animal: AnimalDto = {
      id: this.selectedAnimal.id,
      name: get(this.formControls.name).trim(),
      race: get(this.formControls.race).trim(),
      comment: get(this.formControls.comment).trim(),
      associatedHabitatId: this.selectedHabitat?.id,
      views: this.selectedAnimal.views,
      imageUrl: this.selectedAnimal.imageUrl,
    };

    this.onSubmit.emit(animal);
  }
}
