import { IsInt, IsNotEmpty, IsString, IsUUID } from 'class-validator';
import { Entity } from 'src/core/entity.model';

export class Credit_Card extends Entity {
    @IsNotEmpty()
    @IsUUID()
    id: string;

    @IsNotEmpty()
    @IsString()
    tipo: string;

    @IsNotEmpty()
    @IsString()
    number_card: string;

}
