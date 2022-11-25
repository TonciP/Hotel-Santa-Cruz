import { Module } from '@nestjs/common';
import { TypeOrmModule } from '@nestjs/typeorm';
import { HuespedesEntity } from './database/huespedes.entity';
import { HuespedesService } from './persistance/services/huespedes/huespedes.service';
import { Credit_CardService } from './persistance/services/credit_card/credit_card.service';
import { Credit_CardEntity } from './database/credit_card.entity';


@Module({
  imports: [
    TypeOrmModule.forFeature([
      HuespedesEntity,
      Credit_CardEntity
    ])
  ],
  providers: [
    HuespedesService,
    Credit_CardService
  ],
  exports: [
    TypeOrmModule,
    HuespedesService,
    Credit_CardService
  ],
})
export class InfrastructureModule {}
