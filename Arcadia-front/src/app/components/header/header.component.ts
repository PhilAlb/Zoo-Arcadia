import { Component } from '@angular/core';
import { RouterLink } from '@angular/router';
import { RouteLinks } from '../../app.routes';
import { ConnexionModalComponent } from "../modals/connexion-modal/connexion-modal.component";
import { ContactModalComponent } from "../modals/contact-modal/contact-modal.component";

@Component({
  selector: 'app-header',
  standalone: true,
  imports: [RouterLink, ConnexionModalComponent, ContactModalComponent],
  templateUrl: './header.component.html',
  styleUrl: './header.component.scss',
})
export class HeaderComponent {
  readonly links = [
    { label: 'Accueil', url: `/${RouteLinks.Home}` },
    { label: 'Services', url: `/${RouteLinks.Services}` },
    { label: 'Habitats', url: `/${RouteLinks.Habitats}` },
  ];

  openContactModal(): void {}
  login(): void {}
}
