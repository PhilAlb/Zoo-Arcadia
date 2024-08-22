import { Component, EventEmitter, Output } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, FormsModule, ReactiveFormsModule, Validators } from '@angular/forms';
import { TestimonyDto } from '../../../../../interfaces/testimony';

@Component({
  selector: 'app-add-testimony-form',
  standalone: true,
  imports: [FormsModule, ReactiveFormsModule],
  templateUrl: './add-testimony-form.component.html',
  styleUrl: './add-testimony-form.component.scss'
})
export class AddTestimonyFormComponent {
  createForm: FormGroup;
  readonly formControls = {
    pseudo: 'pseudo',
    message: 'message',
  };

  @Output() onSubmit = new EventEmitter<TestimonyDto>();

  constructor(private formBuilder: FormBuilder) {
    this.createForm = this.formBuilder.group({
      [this.formControls.pseudo]: new FormControl('', {
        validators: Validators.compose([Validators.required]),
      }),
      [this.formControls.message]: new FormControl('', {
        validators: Validators.compose([Validators.required]),
      }),
    });
  }

  save(): void {
    const get = (x: string) => this.createForm.get(x)?.value;

    const testimony: TestimonyDto = {
      pseudo: get(this.formControls.pseudo).trim(),
      message: get(this.formControls.message).trim(),
    };
    this.createForm.reset();

    this.onSubmit.emit(testimony);
  }
}
