import { Test, TestingModule } from '@nestjs/testing';
import { HuespedesController } from '../huespedes/Huespedes.controller';

describe('HuespedesController', () => {
  let controller: HuespedesController;

  beforeEach(async () => {
    const module: TestingModule = await Test.createTestingModule({
      controllers: [HuespedesController],
    }).compile();

    controller = module.get<HuespedesController>(HuespedesController);
  });

  it('should be defined', () => {
    expect(controller).toBeDefined();
  });
});
