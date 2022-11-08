import { OmitType } from '@nestjs/mapped-types';
import { Huespedes } from 'src/domain/models/huespedes.model';

export class CreateHuespedesDto extends OmitType(Huespedes, ['id', 'dni']) {}
