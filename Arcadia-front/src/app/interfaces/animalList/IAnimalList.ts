import { AnimalDto } from "../admin/animal";
import { ICardHabitatsLayout } from "../cardLayout/cardHabitatsLayout/ICardHabitatsLayout";

export interface IAnimalPerHabitat {
  habitat: ICardHabitatsLayout;
  animals: AnimalDto[];  
}
