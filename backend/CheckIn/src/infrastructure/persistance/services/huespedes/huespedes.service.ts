import { BadRequestException, Injectable } from '@nestjs/common';
import { InjectRepository } from '@nestjs/typeorm';
import { Huespedes } from 'src/domain/models/huespedes.model';
import { HuespedesRepository } from '../../../../domain/persistance/huespedes.repo';
import { CreateHuespedesDto } from '../../dto/huespedes/create-huespedes.dto';
import { Repository } from 'typeorm';
import { HuespedesEntity } from '../../../database/huespedes.entity';
import { UpdateHuespedesDto } from '../../dto/huespedes/update-huespedes.dto';

@Injectable()
export class HuespedesService implements HuespedesRepository {
  constructor(
    @InjectRepository(HuespedesEntity)
    private readonly huespedesRepo: Repository<HuespedesEntity>,
  ) {}

  async create(dto: CreateHuespedesDto): Promise<Huespedes> {
    try {
      return await this.huespedesRepo.save(dto);
    } catch (error) {
      throw new BadRequestException(error);
    }
  }
  async update(dto: UpdateHuespedesDto): Promise<Huespedes> {
    try {
      return await this.huespedesRepo.save(dto);
    } catch (error) {
      throw new BadRequestException(error);
    }
  }
  async getById(id: string): Promise<Huespedes> {
    try {
      return await this.huespedesRepo.findOne(id);
    } catch (error) {
      throw new BadRequestException(error);
    }
  }
  async getAll(): Promise<Huespedes[]> {
    try {
      return await this.huespedesRepo.find();
    } catch (error) {
      throw new BadRequestException(error);
    }
  }
  async delete(id: string): Promise<Huespedes> {
    try {
      const toBeDeleted = await this.huespedesRepo.findOne(id);
      return await this.huespedesRepo.remove(toBeDeleted);
    } catch (error) {
      throw new BadRequestException(error);
    }
  }

}
