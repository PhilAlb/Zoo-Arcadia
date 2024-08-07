
import { Component, OnInit } from '@angular/core';
import { ICardLayout } from '../../../../interfaces/cardLayout/ICardLayout';
import { ArcadiaService } from '../../../../services/arcadia/arcadia.service';

@Component({
  selector: 'app-admin-service-page',
  standalone: true,
  imports: [],
  templateUrl: './admin-service-page.component.html',
  styleUrl: './admin-service-page.component.scss',
})

export class AdminServicePageComponent implements OnInit {
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
