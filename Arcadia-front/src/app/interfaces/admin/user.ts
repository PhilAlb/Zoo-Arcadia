export interface UserDto {
  id?: number;
  name: string;
  surname: string;
  email: string;
  password: string;
  role: Role;
}

export enum Role {
  Admin,
  Employee,
  Veterinarian
}
