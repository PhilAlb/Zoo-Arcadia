export interface ServiceDto {
    id ?:number;
    title: string;
    description: string;
    schedules: string;
    image?: File,
    imageUrl?: string;  
}