import { Component, OnInit } from '@angular/core';
import { AddTestimonyFormComponent } from '../forms/add-testimony-form/add-testimony-form.component';
import { EditTestimonyFormComponent } from '../forms/edit-testimony-form/edit-testimony-form.component';
import { ConfirmationModalComponent } from '../../../modals/confirmation-modal/confirmation-modal.component';

@Component({
  selector: 'app-admin-testimony-page',
  standalone: true,
  imports: [
    AddTestimonyFormComponent,
    EditTestimonyFormComponent,
    ConfirmationModalComponent,
  ],
  templateUrl: './admin-testimony-page.component.html',
  styleUrl: './admin-testimony-page.component.scss',
})
export class AdminTestimonyPageComponent implements OnInit {
  constructor() {}

  ngOnInit(): void {}

  add(): void {}

  edit(): void {}

  delete(): void {}
}
