import { Component } from '@angular/core';
import {
  FormGroup,
  FormsModule,
  ReactiveFormsModule,
  FormBuilder,
  FormControl,
  Validators,
} from '@angular/forms';
import { ArcadiaService } from '../../../services/arcadia/arcadia.service';
import { Contact } from '../../../interfaces/admin/contact';

@Component({
  selector: 'app-contact-modal',
  standalone: true,
  imports: [FormsModule, ReactiveFormsModule],
  templateUrl: './contact-modal.component.html',
  styleUrl: './contact-modal.component.scss',
})
export class ContactModalComponent {
  contactForm: FormGroup;
  readonly formControls = {
    email: 'email',
    title: 'title',
    message: 'message',
  };

  constructor(
    private formbuilder: FormBuilder,
    private service: ArcadiaService
  ) {
    this.contactForm = this.formbuilder.group({
      [this.formControls.email]: new FormControl('', {
        validators: Validators.compose([Validators.required]),
      }),
      [this.formControls.title]: new FormControl('', {
        validators: Validators.compose([Validators.required]),
      }),
      [this.formControls.message]: new FormControl('', {
        validators: Validators.compose([Validators.required]),
      }),
    });
  }

  send(): void {
    const get = (x: string) => this.contactForm.get(x)?.value;

    const contact: Contact = {
      email: get(this.formControls.email).trim(),
      title: get(this.formControls.title).trim(),
      message: get(this.formControls.message).trim(),
    };

    this.contactForm.reset();    

    this.service.addContacts(contact).subscribe();
  }
}
