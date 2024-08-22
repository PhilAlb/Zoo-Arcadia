import { Component, EventEmitter, Output } from '@angular/core';
import {
  FormBuilder,
  FormControl,
  FormGroup,
  FormsModule,
  ReactiveFormsModule,
  Validators,
} from '@angular/forms';
import { ServiceDto } from '../../../../../interfaces/service';

@Component({
  selector: 'app-add-service-form',
  standalone: true,
  imports: [FormsModule, ReactiveFormsModule],
  templateUrl: './add-service-form.component.html',
  styleUrl: './add-service-form.component.scss'
})
export class AddServiceFormComponent {
  createForm: FormGroup;
  readonly formControls = {
    title: 'title',
    description: 'description',
    schedules: 'schedules'
  };

  @Output() onSubmit = new EventEmitter<ServiceDto>();
  selectedImage: File;

  constructor(private formBuilder: FormBuilder) {
    this.createForm = this.formBuilder.group({
      [this.formControls.title]: new FormControl('', {
        validators: Validators.compose([Validators.required]),
      }),
      [this.formControls.description]: new FormControl('', {
        validators: Validators.compose([Validators.required]),
      }),
      [this.formControls.schedules]: new FormControl('', {
        validators: Validators.compose([Validators.required]),
      }),
    });
  }

  addImage(event: any): void {
    this.selectedImage = event.target.files[0];
  }

  save(): void {
    const get = (x: string) => this.createForm.get(x)?.value;

    const service: ServiceDto = {
      title: get(this.formControls.title).trim(),
      description: get(this.formControls.description).trim(),
      schedules: get(this.formControls.schedules).trim(),
      image: this.selectedImage,
    };
    this.createForm.reset();

    this.onSubmit.emit(service);
  }
}
