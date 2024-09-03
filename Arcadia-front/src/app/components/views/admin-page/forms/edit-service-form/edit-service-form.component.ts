import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, FormsModule, ReactiveFormsModule, Validators } from '@angular/forms';
import { ServiceDto } from '../../../../../interfaces/admin/service';

@Component({
  selector: 'app-edit-service-form',
  standalone: true,
  imports: [FormsModule, ReactiveFormsModule],
  templateUrl: './edit-service-form.component.html',
  styleUrl: './edit-service-form.component.scss'
})
export class EditServiceFormComponent implements OnInit {
  editForm: FormGroup;
  readonly formControls = {
    title: 'title',
    description: 'description',
    schedules: 'schedules'
  };

  @Output() onSubmit = new EventEmitter<ServiceDto>();
  @Input() selectedService: ServiceDto;

  constructor(private formBuilder: FormBuilder) {}

  ngOnInit(): void {
    this.editForm = this.formBuilder.group({
      [this.formControls.title]: new FormControl(this.selectedService.title, {
        validators: Validators.compose([Validators.required]),
      }),
      [this.formControls.description]: new FormControl(this.selectedService.description, {
        validators: Validators.compose([Validators.required]),
      }),
      [this.formControls.schedules]: new FormControl(this.selectedService.schedules, {
        validators: Validators.compose([Validators.required]),
      }),
    });
  }
  
  save(): void {
    const get = (x: string) => this.editForm.get(x)?.value;

    const service: ServiceDto = {
      id: this.selectedService.id,
      title: get(this.formControls.title).trim(),
      description: get(this.formControls.description).trim(),
      schedules: get(this.formControls.schedules).trim(),
      imageUrl: this.selectedService.imageUrl,
    };

    this.onSubmit.emit(service);
  }
}
