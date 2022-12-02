import { Module } from '@nestjs/common';
import { HuespedesController } from './controllers/huespedes/Huespedes.controller';
import { InfrastructureModule } from '../infrastructure/infrastructure.module';
import { Credit_CardController } from './controllers/huespedes/Credit_Card.controller';

@Module({
  imports: [InfrastructureModule],
  controllers: [
    HuespedesController,
    Credit_CardController
  ],
})
export class ApplicationModule {}
