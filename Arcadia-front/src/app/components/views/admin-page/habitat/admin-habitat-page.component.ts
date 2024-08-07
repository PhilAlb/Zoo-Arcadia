
import { Component, OnInit } from '@angular/core';
import { ICardLayout } from '../../../../interfaces/cardLayout/ICardLayout';
import { ArcadiaService } from '../../../../services/arcadia/arcadia.service';

@Component({
  selector: 'app-admin-habitat-page',
  standalone: true,
  imports: [],
  templateUrl: './admin-habitat-page.component.html',
  styleUrl: './admin-habitat-page.component.scss',
})

export class AdminHabitatPageComponent implements OnInit {
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
