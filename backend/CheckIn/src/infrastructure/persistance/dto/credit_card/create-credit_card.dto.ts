import { OmitType } from '@nestjs/mapped-types';
import { Credit_Card } from '../../../../domain/models/credit_card.model';

export class CreateCredit_CardDto extends OmitType(Credit_Card, ['id','created_at']) {}
