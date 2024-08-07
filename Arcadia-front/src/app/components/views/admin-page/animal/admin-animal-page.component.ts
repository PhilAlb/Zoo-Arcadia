
import { Component, OnInit } from '@angular/core';
import { ICardLayout } from '../../../../interfaces/cardLayout/ICardLayout';
import { ArcadiaService } from '../../../../services/arcadia/arcadia.service';

@Component({
  selector: 'app-admin-animal-page',
  standalone: true,
  imports: [],
  templateUrl: './admin-animal-page.component.html',
  styleUrl: './admin-animal-page.component.scss',
})

export class AdminAnimalPageComponent implements OnInit {
  list: ICardLayout[] = [];

  constructor(private service: ArcadiaService) { }

  ngOnInit(): void {
    this.service
      .getAllHabitats()
      .subscribe((data: ICardLayout[]) => (this.list = data));
  }

  add(): void {
  }

  edit(): void {

  }

  delete(): void {

  }
}
