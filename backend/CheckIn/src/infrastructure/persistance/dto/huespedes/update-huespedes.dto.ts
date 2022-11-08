import { IntersectionType, PartialType, PickType } from '@nestjs/mapped-types';
import { Huespedes } from 'src/domain/models/huespedes.model';
import { CreateHuespedesDto } from './create-huespedes.dto';
export class UpdateHuespedesDto extends IntersectionType(
  PickType(Huespedes, ['id', 'dni']),
  PartialType(CreateHuespedesDto),
) {}
