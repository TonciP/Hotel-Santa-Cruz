import { IntersectionType, PartialType, PickType } from '@nestjs/mapped-types';
import { Credit_Card } from '../../../../domain/models/credit_card.model';
import { CreateCredit_CardDto } from './create-credit_card.dto';

export class UpdateCredit_CardDto extends IntersectionType(
  PickType(Credit_Card, ['id']),
  PartialType(CreateCredit_CardDto),
) {}
