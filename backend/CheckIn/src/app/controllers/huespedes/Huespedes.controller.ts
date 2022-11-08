import {
  Body,
  Controller,
  Delete,
  Get,
  Param,
  Post,
  Put,
} from '@nestjs/common';
import { HuespedesService } from '../../../infrastructure/persistance/services/huespedes/huespedes.service';
import { CreateHuespedesDto } from '../../../infrastructure/persistance/dto/huespedes/create-huespedes.dto';
import { UpdateHuespedesDto } from 'src/infrastructure/persistance/dto/huespedes/update-huespedes.dto';

@Controller('Huespedes')
export class HuespedesController {
  constructor(private readonly huespedesService: HuespedesService) {}

  @Post()
  async createHuespedes(@Body() createHuespedesDto: CreateHuespedesDto) {
    return await this.huespedesService.create(createHuespedesDto);
  }

  @Put()
  async updateHuespedes(@Body() updateHuespedesDto: UpdateHuespedesDto) {
    return await this.huespedesService.update(updateHuespedesDto);
  }

  @Get(':id')
  async getHuespedById(@Param('id') id: string) {
    return await this.huespedesService.getById(id);
  }

  @Get()
  async getAllHuespedes() {
    return await this.huespedesService.getAll();
  }

  @Delete(':id')
  async deleteHuespedes(@Param('id') id: string) {
    return await this.huespedesService.delete(id);
  }
}
