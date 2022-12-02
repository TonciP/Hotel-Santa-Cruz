import { IRespository } from '../../core/irepository';
import { Huespedes } from '../models/huespedes.model';

export interface HuespedesRepository extends IRespository<Huespedes> {

    //getHuespedByCreditCardId: (credit_cardId: string) => Promise<Huespedes[]>;
}
