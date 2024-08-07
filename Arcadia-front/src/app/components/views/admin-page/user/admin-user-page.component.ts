
import { Component, OnInit } from '@angular/core';
import { ICardLayout } from '../../../../interfaces/cardLayout/ICardLayout';
import { ArcadiaService } from '../../../../services/arcadia/arcadia.service';

@Component({
  selector: 'app-admin-user-page',
  standalone: true,
  imports: [],
  templateUrl: './admin-user-page.component.html',
  styleUrl: './admin-user-page.component.scss',
})

export class AdminUserPageComponent implements OnInit {
  cardHabitatLayout: ICardLayout[] = [];

  constructor(private service: ArcadiaService) { }

  ngOnInit(): void {
    this.service
      .getAllHabitats()
      .subscribe((data: ICardLayout[]) => (this.cardHabitatLayout = data));
  }

  edit(): void {

  }

  delete(): void {

  }
}
