import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, FormsModule, ReactiveFormsModule, Validators } from '@angular/forms';
import { Role, UserDto } from '../../../../../interfaces/admin/user';

@Component({
  selector: 'app-edit-user-form',
  standalone: true,
  imports: [FormsModule, ReactiveFormsModule],
  templateUrl: './edit-user-form.component.html',
  styleUrl: './edit-user-form.component.scss'
})
export class EditUserFormComponent implements OnInit {
  editForm: FormGroup;
  readonly formControls = {
    name: 'pseudo',
    surname: 'message',
    mailAddress: 'mailAddress',
    password: 'password',
    role: 'role',
  };
  readonly Roles = Role;

  @Output() onSubmit = new EventEmitter<UserDto>();
  @Input() selectedUser: UserDto;

  constructor(private formBuilder: FormBuilder) {}

  ngOnInit(): void {
    this.editForm = this.formBuilder.group({
      [this.formControls.name]: new FormControl(this.selectedUser.name, {
        validators: Validators.compose([Validators.required]),
      }),
      [this.formControls.surname]: new FormControl(this.selectedUser.surname, {
        validators: Validators.compose([Validators.required]),
      }),
      [this.formControls.mailAddress]: new FormControl(this.selectedUser.email, {
        validators: Validators.compose([Validators.required, Validators.email]),
      }),
      [this.formControls.password]: new FormControl(this.selectedUser.password, {
        validators: Validators.compose([
          Validators.required,
          Validators.minLength(6),
        ]),
      }),
      [this.formControls.role]: new FormControl(this.selectedUser.role, {
        validators: Validators.compose([Validators.required]),
      })
    });
  }
  
  save(): void {
    const get = (x: string) => this.editForm.get(x)?.value;

    const user: UserDto = {
      id: this.selectedUser.id,
      name: get(this.formControls.name).trim(),
      surname: get(this.formControls.surname).trim(),
      email: get(this.formControls.mailAddress).trim(),
      password: get(this.formControls.password).trim(),
      role: get(this.formControls.role),
    };

    this.onSubmit.emit(user);
  }

}
