export interface AnimalDto {
  id?: number;
  name: string;
  race: string;
  image?: File,
  imageUrl?: string;
  associatedHabitatTitle?: string;
  associatedHabitatId?: number;
}
