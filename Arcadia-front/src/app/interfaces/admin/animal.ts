export interface AnimalDto {
  id?: number;
  name: string;
  race: string;
  views: number;
  comment?: string;
  image?: File,
  imageUrl?: string;
  associatedHabitatTitle?: string;
  associatedHabitatId?: number;
}
