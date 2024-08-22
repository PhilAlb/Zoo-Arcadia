import { Component, OnInit } from '@angular/core';
import { AddTestimonyFormComponent } from '../forms/add-testimony-form/add-testimony-form.component';
import { EditTestimonyFormComponent } from '../forms/edit-testimony-form/edit-testimony-form.component';
import { ConfirmationModalComponent } from '../../../modals/confirmation-modal/confirmation-modal.component';
import { TestimonyDto } from '../../../../interfaces/testimony';
import { TestimonyService } from '../../../../services/testimony/testimony.service';

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
  list: TestimonyDto[] = [];

  constructor(private service: TestimonyService) {}

  ngOnInit(): void {
    this.getList();
  }

  getList(): void {
    this.service
      .getTestimonies()
      .subscribe((data: TestimonyDto[]) => (this.list = data));
  }

  add(testimony: TestimonyDto): void {
    this.service.addTestimony(testimony).subscribe(() => this.getList());
  }

  edit(testimony: TestimonyDto): void {
    this.service.updateTestimony(testimony).subscribe(() => this.getList());
  }

  delete(id: number): void {
    this.service
      .deleteTestimony(id)
      .subscribe(() => (this.list = this.list.filter((item) => item.id != id)));
  }
}
