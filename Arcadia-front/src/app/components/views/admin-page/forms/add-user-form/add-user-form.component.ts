import { Component, EventEmitter, Output } from '@angular/core';
import {
  FormBuilder,
  FormControl,
  FormGroup,
  FormsModule,
  ReactiveFormsModule,
  Validators,
} from '@angular/forms';
import { Role, UserDto } from '../../../../../interfaces/user';

@Component({
  selector: 'app-add-user-form',
  standalone: true,
  imports: [FormsModule, ReactiveFormsModule],
  templateUrl: './add-user-form.component.html',
  styleUrl: './add-user-form.component.scss',
})
export class AddUserFormComponent {
  createForm: FormGroup;
  readonly formControls = {
    name: 'pseudo',
    surname: 'message',
    mailAddress: 'mailAddress',
    password: 'password',
    isAdmin: 'isAdmin',
  };

  @Output() onSubmit = new EventEmitter<UserDto>();

  constructor(private formBuilder: FormBuilder) {
    this.createForm = this.formBuilder.group({
      [this.formControls.name]: new FormControl('', {
        validators: Validators.compose([Validators.required]),
      }),
      [this.formControls.surname]: new FormControl('', {
        validators: Validators.compose([Validators.required]),
      }),
      [this.formControls.mailAddress]: new FormControl('', {
        validators: Validators.compose([Validators.required, Validators.email]),
      }),
      [this.formControls.password]: new FormControl('', {
        validators: Validators.compose([
          Validators.required,
          Validators.minLength(6),
        ]),
      }),
      [this.formControls.isAdmin]: new FormControl(false),
    });
  }

  save(): void {
    const get = (x: string) => this.createForm.get(x)?.value;

    const user: UserDto = {
      name: get(this.formControls.name).trim(),
      surname: get(this.formControls.surname).trim(),
      email: get(this.formControls.mailAddress).trim(),
      password: get(this.formControls.password).trim(),
      role: get(this.formControls.isAdmin) == true ? Role.Admin : Role.User,
    };

    this.createForm.reset();

    this.onSubmit.emit(user);
  }
}
