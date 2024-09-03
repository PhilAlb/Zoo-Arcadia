export interface HabitatDto {
    id ?:number;
    title: string;
    description: string;
    comment?: string;
    image?: File,
    imageUrl?: string;  
}