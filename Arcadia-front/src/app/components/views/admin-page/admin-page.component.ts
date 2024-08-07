
import { Component } from '@angular/core';
import { RouterLink, RouterOutlet } from '@angular/router';
import { AdminAnimalPageComponent } from './animal/admin-animal-page.component';

@Component({
  selector: 'app-admin-page',
  standalone: true,
  imports: [RouterLink, RouterOutlet, AdminAnimalPageComponent],
  templateUrl: './admin-page.component.html',
  styleUrl: './admin-page.component.scss',
})
export class AdminPageComponent {
}
