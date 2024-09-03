import { Component, OnInit } from '@angular/core';
import { Role, UserDto } from '../../../../interfaces/admin/user';
import { UserService } from '../../../../services/user/user.service';
import { ConfirmationModalComponent } from '../../../modals/confirmation-modal/confirmation-modal.component';
import { EditUserFormComponent } from '../forms/edit-user-form/edit-user-form.component';
import { AddUserFormComponent } from '../forms/add-user-form/add-user-form.component';

@Component({
  selector: 'app-admin-user-page',
  standalone: true,
  imports: [
    AddUserFormComponent,
    EditUserFormComponent,
    ConfirmationModalComponent,
  ],
  templateUrl: './admin-user-page.component.html',
  styleUrl: './admin-user-page.component.scss',
})
export class AdminUserPageComponent implements OnInit {
  list: UserDto[] = [];
  readonly roleEnum = Role;

  constructor(private service: UserService) {}

  ngOnInit(): void {
    this.getList();
  }

  getList(): void {
    this.service.getUsers().subscribe((data: UserDto[]) => (this.list = data));
  }

  add(user: UserDto): void {
    this.service.addUser(user).subscribe(() => this.getList());
  }

  edit(user: UserDto): void {
    this.service.updateUser(user).subscribe(() => this.getList());
  }

  delete(id: number): void {
    this.service
      .deleteUser(id)
      .subscribe(() => (this.list = this.list.filter((item) => item.id != id)));
  }
}
