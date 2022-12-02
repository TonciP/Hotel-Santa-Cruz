import { BadRequestException, Injectable } from '@nestjs/common';
import { InjectRepository } from '@nestjs/typeorm';
import { Repository } from 'typeorm';
import { Credit_CardEntity } from 'src/infrastructure/database/credit_card.entity';
import { Credit_CardRepository } from 'src/domain/persistance/credit_card.repo';
import { Credit_Card } from 'src/domain/models/credit_card.model';
import { CreateCredit_CardDto } from '../../dto/credit_card/create-credit_card.dto';
import { UpdateCredit_CardDto } from '../../dto/credit_card/update-credit_card.dto';

@Injectable()
export class Credit_CardService implements Credit_CardRepository {
    constructor(
        @InjectRepository(Credit_CardEntity)
        private readonly credit_cardRepo: Repository<Credit_CardEntity>,
    ) { }

    async create(dto: CreateCredit_CardDto): Promise<Credit_Card> {
        try {
            return await this.credit_cardRepo.save(dto);
        } catch (error) {
            throw new BadRequestException(error);
        }
    }
    async update(dto: UpdateCredit_CardDto): Promise<Credit_Card> {
        try {
            return await this.credit_cardRepo.save(dto);
        } catch (error) {
            throw new BadRequestException(error);
        }
    }
    async getById(id: string): Promise<Credit_Card> {
        try {
            return await this.credit_cardRepo.findOne(id);
        } catch (error) {
            throw new BadRequestException(error);
        }
    }
    async getAll(): Promise<Credit_Card[]> {
        try {
            return await this.credit_cardRepo.find();
        } catch (error) {
            throw new BadRequestException(error);
        }
    }
    async delete(id: string): Promise<Credit_Card> {
        try {
            const toBeDeleted = await this.credit_cardRepo.findOne(id);
            return await this.credit_cardRepo.remove(toBeDeleted);
        } catch (error) {
            throw new BadRequestException(error);
        }
    }

}
