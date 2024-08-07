import { Component } from '@angular/core';
import {
  FormBuilder,
  FormControl,
  FormGroup,
  FormsModule,
  ReactiveFormsModule,
  Validators,
} from '@angular/forms';
import { ICardTestimonyLayout } from '../../../interfaces/cardTestimonyLayout/ICardTestimonyLayout';
import { ArcadiaService } from '../../../services/arcadia/arcadia.service';

@Component({
  selector: 'app-testimony-modal',
  standalone: true,
  imports: [FormsModule, ReactiveFormsModule],
  templateUrl: './testimony-modal.component.html',
  styleUrl: './testimony-modal.component.scss',
})
export class TestimonyModalComponent {
  createTestimonyForm: FormGroup;
  readonly formControls = {
    pseudo: 'pseudo',
    message: 'message',
  };

  constructor(
    private formBuilder: FormBuilder,
    private service: ArcadiaService
  ) {
    this.createTestimonyForm = this.formBuilder.group({
      [this.formControls.pseudo]: new FormControl('', {
        validators: Validators.compose([Validators.required]),
      }),
      [this.formControls.message]: new FormControl('', {
        validators: Validators.compose([Validators.required]),
      }),
    });
  }

  save(): void {
    const get = (x: string) => this.createTestimonyForm.get(x)?.value;
    const testimony: ICardTestimonyLayout = {
      pseudo: get(this.formControls.pseudo).trim(),
      message: get(this.formControls.message).trim(),
    };

    this.createTestimonyForm.reset();
    
    this.service.addTestimonies(testimony).subscribe();
  }
}
