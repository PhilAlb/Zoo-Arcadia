import { Component, OnInit } from "@angular/core";
import { ArcadiaService } from "../../../services/arcadia/arcadia.service";
import { CommonModule } from "@angular/common";
import { ICardHabitatsLayout } from "../../../interfaces/cardLayout/cardHabitatsLayout/ICardHabitatsLayout";
import { environment } from "../../../../../environment";
import { CardHabitatsComponent } from "../../cards/card-model/card-habitats/card-habitats.component";

@Component({
    selector: 'app-habitats-page',
    standalone: true,
    imports: [ CommonModule, CardHabitatsComponent ],
    templateUrl: './habitats-page.component.html',
    styleUrl: './habitats-page.component.scss'
  })
  export class HabitatsPageComponent implements OnInit {
    readonly apiUrl = environment.apiUrl;

    cardHabitatsLayout: ICardHabitatsLayout[] = [];

    constructor(private service: ArcadiaService) {}

    ngOnInit() {
      this.service
      .getAllHabitats()
      .subscribe((data: ICardHabitatsLayout[]) => (this.cardHabitatsLayout = data));
    }
  }  