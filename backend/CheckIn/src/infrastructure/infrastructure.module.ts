import { Module } from '@nestjs/common';
import { TypeOrmModule } from '@nestjs/typeorm';
import { HuespedesEntity } from './database/huespedes.entity';
import { HuespedesService } from './persistance/services/huespedes/huespedes.service';


@Module({
  imports: [
    TypeOrmModule.forFeature([
      HuespedesEntity
    ])
  ],
  providers: [
    HuespedesService,
  ],
  exports: [
    TypeOrmModule,
    HuespedesService,
  ],
})
export class InfrastructureModule {}
