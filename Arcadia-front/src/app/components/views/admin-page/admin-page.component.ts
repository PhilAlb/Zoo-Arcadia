import { Component, OnInit } from '@angular/core';
import { RouterLink, RouterOutlet } from '@angular/router';
import { AccountService } from '../../../services/account/account.service';
import { Role } from './../../../interfaces/admin/user';
import { RouteLinks } from '../../../app.routes';

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

  links = [
    {
      label: 'Animaux',
      url: `/${RouteLinks.Admin}/${RouteLinks.Animals}`,
      allowedRoles: [Role.Admin, Role.Veterinarian],
    },
    {
      label: 'Habitats',
      url: `/${RouteLinks.Admin}/${RouteLinks.Habitats}`,
      allowedRoles: [Role.Admin, Role.Veterinarian],
    },
    {
      label: 'Services',
      url: `/${RouteLinks.Admin}/${RouteLinks.Services}`,
      allowedRoles: [Role.Admin],
    },
    {
      label: 'Témoignages',
      url: `/${RouteLinks.Admin}/${RouteLinks.Testimonies}`,
      allowedRoles: [Role.Admin, Role.Employee],
    },
    {
      label: 'Contact',
      url: `/${RouteLinks.Admin}/${RouteLinks.Contact}`,
      allowedRoles: [Role.Admin, Role.Employee],
    },
    {
      label: 'Utilisateurs',
      url: `/${RouteLinks.Admin}/${RouteLinks.Users}`,
      allowedRoles: [Role.Admin],
    },
  ];

  constructor(private service: AccountService) {}

  ngOnInit(): void {
    this.service.role$.subscribe((res) => {
      if (res != null) this.currentRole = res;
    });
  }
}
