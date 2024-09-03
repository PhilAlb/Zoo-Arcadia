import { Component, EventEmitter, Output } from '@angular/core';
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
  selector: 'app-add-habitat-form',
  standalone: true,
  imports: [FormsModule, ReactiveFormsModule],
  templateUrl: './add-habitat-form.component.html',
  styleUrl: './add-habitat-form.component.scss',
})
export class AddHabitatFormComponent {
  createForm: FormGroup;
  readonly formControls = {
    title: 'title',
    description: 'description',
  };

  @Output() onSubmit = new EventEmitter<HabitatDto>();
  selectedImage: File;

  constructor(private formBuilder: FormBuilder) {
    this.createForm = this.formBuilder.group({
      [this.formControls.title]: new FormControl('', {
        validators: Validators.compose([Validators.required]),
      }),
      [this.formControls.description]: new FormControl('', {
        validators: Validators.compose([Validators.required]),
      }),
    });
  }

  addImage(event: any): void {
    this.selectedImage = event.target.files[0];
  }

  save(): void {
    const get = (x: string) => this.createForm.get(x)?.value;

    const habitat: HabitatDto = {
      title: get(this.formControls.title).trim(),
      description: get(this.formControls.description).trim(),
      image: this.selectedImage,
    };
    this.createForm.reset();

    this.onSubmit.emit(habitat);
  }
}
