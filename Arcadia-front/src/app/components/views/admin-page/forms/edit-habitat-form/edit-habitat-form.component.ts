import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, FormsModule, ReactiveFormsModule, Validators } from '@angular/forms';
import { HabitatDto } from '../../../../../interfaces/habitat';

@Component({
  selector: 'app-edit-habitat-form',
  standalone: true,
  imports: [FormsModule, ReactiveFormsModule],
  templateUrl: './edit-habitat-form.component.html',
  styleUrl: './edit-habitat-form.component.scss',
})
export class EditHabitatFormComponent implements OnInit {
  editForm: FormGroup;
  readonly formControls = {
    title: 'title',
    description: 'description',
  };

  @Output() onSubmit = new EventEmitter<HabitatDto>();
  @Input() selectedHabitat: HabitatDto;

  constructor(private formBuilder: FormBuilder) {}

  ngOnInit(): void {
    this.editForm = this.formBuilder.group({
      [this.formControls.title]: new FormControl(this.selectedHabitat.title, {
        validators: Validators.compose([Validators.required]),
      }),
      [this.formControls.description]: new FormControl(this.selectedHabitat.description, {
        validators: Validators.compose([Validators.required]),
      }),
    });
  }
  
  save(): void {
    const get = (x: string) => this.editForm.get(x)?.value;

    const habitat: HabitatDto = {
      id: this.selectedHabitat.id,
      title: get(this.formControls.title).trim(),
      description: get(this.formControls.description).trim(),
      imageUrl: this.selectedHabitat.imageUrl,
    };

    this.onSubmit.emit(habitat);
  }
}
