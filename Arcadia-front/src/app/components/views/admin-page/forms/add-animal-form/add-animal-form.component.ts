import { HabitatService } from '../../../../../services/habitat/habitat.service';
import { Component, Output, EventEmitter } from '@angular/core';
import { AnimalDto } from '../../../../../interfaces/admin/animal';
import {
  FormBuilder,
  FormControl,
  FormGroup,
  FormsModule,
  ReactiveFormsModule,
  Validators,
} from '@angular/forms';
import { HabitatDto } from '../../../../../interfaces/admin/habitat';

@Component({
  selector: 'app-add-animal-form',
  standalone: true,
  imports: [FormsModule, ReactiveFormsModule],
  templateUrl: './add-animal-form.component.html',
  styleUrl: './add-animal-form.component.scss',
})
export class AddAnimalFormComponent {
  createForm: FormGroup;
  readonly formControls = {
    name: 'name',
    race: 'race',
    comment: 'comment',
  };

  @Output() onSubmit = new EventEmitter<AnimalDto>();
  habitats: HabitatDto[] = [];
  selectedHabitat?: HabitatDto;
  selectedImage: File;

  constructor(
    private formBuilder: FormBuilder,
    private habitatService: HabitatService
  ) {
    this.createForm = this.formBuilder.group({
      [this.formControls.name]: new FormControl('', {
        validators: Validators.compose([Validators.required]),
      }),
      [this.formControls.race]: new FormControl('', {
        validators: Validators.compose([Validators.required]),
      }),
      [this.formControls.comment]: new FormControl(''),
    });
  }

  ngOnInit(): void {
    this.habitatService
      .getHabitats()
      .subscribe((data) => (this.habitats = data));
  }

  addImage(event: any): void {
    this.selectedImage = event.target.files[0];
  }

  save(): void {
    const get = (x: string) => this.createForm.get(x)?.value;

    const animal: AnimalDto = {
      name: get(this.formControls.name).trim(),
      race: get(this.formControls.race).trim(),
      comment: get(this.formControls.comment).trim(),
      associatedHabitatId: this.selectedHabitat?.id,
      views: 0,
      image: this.selectedImage,
    };
    this.resetForm();

    this.onSubmit.emit(animal);
  }

  resetForm() {
    this.createForm.reset();
    this.selectedHabitat = undefined;
  }
}
