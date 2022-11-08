import { Module } from '@nestjs/common';
import { HuespedesController } from './controllers/huespedes/Huespedes.controller';
import { InfrastructureModule } from '../infrastructure/infrastructure.module';

@Module({
  imports: [InfrastructureModule],
  controllers: [
    HuespedesController,
  ],
})
export class ApplicationModule {}
