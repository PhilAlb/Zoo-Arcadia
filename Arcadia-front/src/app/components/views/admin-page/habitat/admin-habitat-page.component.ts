import { EditHabitatFormComponent } from './../forms/edit-habitat-form/edit-habitat-form.component';
import { Component, OnInit } from '@angular/core';
import { HabitatDto } from '../../../../interfaces/admin/habitat';
import { HabitatService } from '../../../../services/habitat/habitat.service';
import { ConfirmationModalComponent } from '../../../modals/confirmation-modal/confirmation-modal.component';
import { AddHabitatFormComponent } from '../forms/add-habitat-form/add-habitat-form.component';
import { AccountService } from '../../../../services/account/account.service';
import { Role } from '../../../../interfaces/admin/user';

@Component({
  selector: 'app-admin-habitat-page',
  standalone: true,
  imports: [
    AddHabitatFormComponent,
    EditHabitatFormComponent,
    ConfirmationModalComponent,
  ],
  templateUrl: './admin-habitat-page.component.html',
  styleUrl: './admin-habitat-page.component.scss',
})
export class AdminHabitatPageComponent implements OnInit {
  readonly Roles = Role;
  currentRole: Role;
  list: HabitatDto[] = [];

  constructor(
    private service: HabitatService,
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
      .getHabitats()
      .subscribe((data: HabitatDto[]) => (this.list = data));
  }

  add(habitat: HabitatDto): void {
    this.service.addHabitat(habitat).subscribe(() => this.getList());
  }

  edit(habitat: HabitatDto): void {
    this.service.updateHabitat(habitat).subscribe(() => this.getList());
  }

  delete(id: number): void {
    this.service
      .deleteHabitat(id)
      .subscribe(() => (this.list = this.list.filter((item) => item.id != id)));
  }
}
