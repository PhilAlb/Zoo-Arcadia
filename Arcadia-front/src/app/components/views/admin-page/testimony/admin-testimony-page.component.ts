import { Component, OnInit } from '@angular/core';
import { TestimonyDto } from '../../../../interfaces/admin/testimony';
import { TestimonyService } from '../../../../services/testimony/testimony.service';
import { ConfirmationModalComponent } from '../../../modals/confirmation-modal/confirmation-modal.component';
import { AddTestimonyFormComponent } from '../forms/add-testimony-form/add-testimony-form.component';
import { EditTestimonyFormComponent } from '../forms/edit-testimony-form/edit-testimony-form.component';
import { Role } from './../../../../interfaces/admin/user';
import { AccountService } from './../../../../services/account/account.service';

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
  readonly Roles = Role;
  currentRole: Role;
  list: TestimonyDto[] = [];

  constructor(
    private service: TestimonyService,
    private accountService: AccountService
  ) {}

  ngOnInit(): void {
    this.accountService.role$.subscribe((role) => {
      if (role != null) this.currentRole = role;
    });

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
