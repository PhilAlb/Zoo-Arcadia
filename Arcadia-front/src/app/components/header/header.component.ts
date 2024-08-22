import { AccountService } from './../../services/account/account.service';
import { Component, OnInit } from '@angular/core';
import { RouterLink } from '@angular/router';
import { RouteLinks } from '../../app.routes';
import { ConnexionModalComponent } from '../modals/connexion-modal/connexion-modal.component';
import { ContactModalComponent } from '../modals/contact-modal/contact-modal.component';
import { Role } from '../../interfaces/user';

@Component({
  selector: 'app-header',
  standalone: true,
  imports: [RouterLink, ConnexionModalComponent, ContactModalComponent],
  templateUrl: './header.component.html',
  styleUrl: './header.component.scss',
})
export class HeaderComponent implements OnInit {
  readonly links = [
    { label: 'Accueil', url: `/${RouteLinks.Home}` },
    { label: 'Services', url: `/${RouteLinks.Services}` },
    { label: 'Habitats', url: `/${RouteLinks.Habitats}` },
  ];

  constructor(private service: AccountService) {}

  ngOnInit() {
    this.service.checkAuthenticationState();

    this.service.role$.subscribe((role) => {
      if (role == Role.Admin)
        this.links.push({ label: 'Admin', url: `/${RouteLinks.Admin}` });
    });
  }
}
