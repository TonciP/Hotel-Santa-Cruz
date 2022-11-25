import {
    Body,
    Controller,
    Delete,
    Get,
    Param,
    Post,
    Put,
} from '@nestjs/common';
import { Credit_CardService } from 'src/infrastructure/persistance/services/credit_card/credit_card.service';
import { CreateCredit_CardDto } from 'src/infrastructure/persistance/dto/credit_card/create-credit_card.dto';
import { UpdateCredit_CardDto } from 'src/infrastructure/persistance/dto/credit_card/update-credit_card.dto';

@Controller('Credit_Card')
export class Credit_CardController {
    constructor(private readonly credit_cardService: Credit_CardService) { }

    @Post()
    async createCredit_Card(@Body() createCredit_CardDto: CreateCredit_CardDto) {
        return await this.credit_cardService.create(createCredit_CardDto);
    }

    @Put()
    async updateCredit_Card(@Body() updateCredit_CardDto: UpdateCredit_CardDto) {
        return await this.credit_cardService.update(updateCredit_CardDto);
    }

    @Get(':id')
    async getCredit_CardById(@Param('id') id: string) {
        return await this.credit_cardService.getById(id);
    }

    @Get()
    async getAllCredit_Card() {
        return await this.credit_cardService.getAll();
    }

    @Delete(':id')
    async deleteCredit_Card(@Param('id') id: string) {
        return await this.credit_cardService.delete(id);
    }
}
