import { Component } from '@angular/core';
import { RouterLink } from '@angular/router';
import { RouteLinks } from '../../app.routes';
import { ContactModalComponent } from "../modals/contact-modal/contact-modal.component";

@Component({
  selector: 'app-footer',
  standalone: true,
  imports: [RouterLink, ContactModalComponent],
  templateUrl: './footer.component.html',
  styleUrl: './footer.component.scss'
})
export class FooterComponent {
  readonly links = [
    { label: 'Accueil', url: `/${RouteLinks.Home}` },
    { label: 'Services', url: `/${RouteLinks.Services}` },
    { label: 'Habitats', url: `/${RouteLinks.Habitats}` },
  ];
}
