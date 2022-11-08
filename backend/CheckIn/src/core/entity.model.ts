import { IsUUID } from "class-validator";

export class Entity {

  @IsUUID()
  readonly id: string;
  dni: string;
}
