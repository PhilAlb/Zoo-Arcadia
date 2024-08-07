
import { Component, OnInit } from '@angular/core';
import { ICardLayout } from '../../../../interfaces/cardLayout/ICardLayout';
import { ArcadiaService } from '../../../../services/arcadia/arcadia.service';

@Component({
  selector: 'app-admin-testimony-page',
  standalone: true,
  imports: [],
  templateUrl: './admin-testimony-page.component.html',
  styleUrl: './admin-testimony-page.component.scss',
})

export class AdminTestimonyPageComponent implements OnInit {
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
