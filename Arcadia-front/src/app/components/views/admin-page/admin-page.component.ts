
import { Component } from '@angular/core';
import { RouterLink, RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-admin-page',
  standalone: true,
  imports: [RouterLink, RouterOutlet],
  templateUrl: './admin-page.component.html',
  styleUrl: './admin-page.component.scss',
})
export class AdminPageComponent {
}
