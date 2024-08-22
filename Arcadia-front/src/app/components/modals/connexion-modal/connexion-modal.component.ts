import {
  FormGroup,
  FormBuilder,
  FormControl,
  Validators,
  FormsModule,
  ReactiveFormsModule,
} from '@angular/forms';
import { AccountService } from './../../../services/account/account.service';
import { Component, OnInit } from '@angular/core';
import { RouteLinks } from '../../../app.routes';

@Component({
  selector: 'app-connexion-modal',
  standalone: true,
  imports: [FormsModule, ReactiveFormsModule],
  templateUrl: './connexion-modal.component.html',
  styleUrl: './connexion-modal.component.scss',
})
export class ConnexionModalComponent implements OnInit {
  loginForm: FormGroup;
  readonly formControls = {
    email: 'email',
    password: 'password',
  };

  isUserLoggedIn = false;

  constructor(
    private service: AccountService,
    private formBuilder: FormBuilder
  ) {
    this.loginForm = this.formBuilder.group({
      [this.formControls.email]: new FormControl('', {
        validators: Validators.compose([Validators.required, Validators.email]),
      }),
      [this.formControls.password]: new FormControl('', {
        validators: Validators.compose([
          Validators.required,
          Validators.minLength(6),
        ]),
      }),
    });
  }

  ngOnInit(): void {
    this.service
      .isAuthenticated$
      .subscribe((result) => (this.isUserLoggedIn = result));
  }

  login(): void {
    const get = (x: string) => this.loginForm.get(x)?.value;

    const credentials = {
      email: get(this.formControls.email).trim(),
      password: get(this.formControls.password).trim(),
    };

    this.service.login(credentials).subscribe((result) => {
      if (result) location.reload();
    });
  }

  logout(): void {
    this.service.logout().subscribe(() => location.replace(RouteLinks.Home));
  }
}
