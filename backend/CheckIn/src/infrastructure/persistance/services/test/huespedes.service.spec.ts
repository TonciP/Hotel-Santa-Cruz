import { Test, TestingModule } from '@nestjs/testing';
import { HuespedesService } from '../huespedes/huespedes.service';

describe('CitaService', () => {
  let service: HuespedesService;

  beforeEach(async () => {
    const module: TestingModule = await Test.createTestingModule({
      providers: [HuespedesService],
    }).compile();

    service = module.get<HuespedesService>(HuespedesService);
  });

  it('should be defined', () => {
    expect(service).toBeDefined();
  });
});
