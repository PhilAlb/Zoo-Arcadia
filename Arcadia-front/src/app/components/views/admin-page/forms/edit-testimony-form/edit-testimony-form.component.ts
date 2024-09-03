import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, FormsModule, ReactiveFormsModule, Validators } from '@angular/forms';
import { TestimonyDto } from '../../../../../interfaces/testimony';
import { Role } from '../../../../../interfaces/user';

@Component({
  selector: 'app-edit-testimony-form',
  standalone: true,
  imports: [FormsModule, ReactiveFormsModule],
  templateUrl: './edit-testimony-form.component.html',
  styleUrl: './edit-testimony-form.component.scss'
})
export class EditTestimonyFormComponent implements OnInit {
  editForm: FormGroup;
  readonly formControls = {
    pseudo: 'pseudo',
    message: 'message',
    isValidated: 'isValidated'
  };

  @Output() onSubmit = new EventEmitter<TestimonyDto>();
  @Input() selectedTestimony: TestimonyDto;
  @Input() currentRole: Role;

  constructor(private formBuilder: FormBuilder) {}

  ngOnInit(): void {
    this.editForm = this.formBuilder.group({
      [this.formControls.pseudo]: new FormControl(this.selectedTestimony.pseudo, {
        validators: Validators.compose([Validators.required]),
      }),
      [this.formControls.message]: new FormControl(this.selectedTestimony.message, {
        validators: Validators.compose([Validators.required]),
      }),
      [this.formControls.isValidated]: new FormControl(this.selectedTestimony.isValidated),
    });

    if (this.currentRole != Role.Admin){
      this.editForm.get("pseudo")?.disable();
      this.editForm.get("message")?.disable();
    }
  }
  
  save(): void {
    const get = (x: string) => this.editForm.get(x)?.value;

    const testimony: TestimonyDto = {
      id: this.selectedTestimony.id,
      pseudo: get(this.formControls.pseudo).trim(),
      message: get(this.formControls.message).trim(),
      isValidated: get(this.formControls.isValidated) ?? false
    };

    this.onSubmit.emit(testimony);
  }
}
