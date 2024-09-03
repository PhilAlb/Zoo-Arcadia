import { Component, OnInit } from '@angular/core';
import { RouterLink, RouterOutlet } from '@angular/router';
import { AccountService } from '../../../services/account/account.service';
import { Role } from '../../../interfaces/user';

@Component({
  selector: 'app-admin-page',
  standalone: true,
  imports: [RouterLink, RouterOutlet],
  templateUrl: './admin-page.component.html',
  styleUrl: './admin-page.component.scss',
})
export class AdminPageComponent implements OnInit {
  readonly Roles = Role;
  currentRole: Role;

  constructor(private service: AccountService) {}

  ngOnInit(): void {
    this.service.role$.subscribe((res) => {
      if (res != null) this.currentRole = res;
    });
  }
}
