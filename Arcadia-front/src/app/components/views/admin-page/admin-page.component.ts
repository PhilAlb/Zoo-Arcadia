
import { Component, OnInit } from '@angular/core';
import { ICardLayout } from '../../../interfaces/cardLayout/ICardLayout';
import { ArcadiaService } from '../../../services/arcadia/arcadia.service';

@Component({
  selector: 'app-admin-page',
  standalone: true,
  imports: [],
  templateUrl: './admin-page.component.html',
  styleUrl: './admin-page.component.scss',
})
export class AdminPageComponent implements OnInit {
  cardHabitatLayout: ICardLayout[] = [];

  constructor(private service: ArcadiaService) {}

  ngOnInit(): void {
    this.service
      .getAllHabitats()
      .subscribe((data: ICardLayout[]) => (this.cardHabitatLayout = data));
  }

  delete(): void {}

  edit(): void {}
}
