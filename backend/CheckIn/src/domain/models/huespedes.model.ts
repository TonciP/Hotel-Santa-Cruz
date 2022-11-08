import { IsNotEmpty, IsString, IsUUID } from 'class-validator';
import { Entity } from 'src/core/entity.model';

export class Huespedes extends Entity {
  @IsNotEmpty()
  @IsUUID()
  id: string;

  @IsNotEmpty()
  @IsString()
  dni: string;

}
