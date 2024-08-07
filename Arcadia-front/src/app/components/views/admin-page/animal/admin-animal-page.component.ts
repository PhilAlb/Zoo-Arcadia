
import { Component, OnInit } from '@angular/core';
import { ICardLayout } from '../../../../interfaces/cardLayout/ICardLayout';
import { ArcadiaService } from '../../../../services/arcadia/arcadia.service';
import { TestimonyModalComponent } from '../../../modals/testimony-modal/testimony-modal.component';
import { ConfirmationModalComponent } from '../../../modals/confirmation-modal/confirmation-modal.component';

@Component({
  selector: 'app-admin-animal-page',
  standalone: true,
  imports: [TestimonyModalComponent, ConfirmationModalComponent],
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

  delete(id: string): void {
    console.log(id);
  }
}
