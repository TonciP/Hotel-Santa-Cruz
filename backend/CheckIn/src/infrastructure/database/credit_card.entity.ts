import {
    Column,
    Entity,
    PrimaryGeneratedColumn,
} from 'typeorm';

@Entity({ name: 'credit_card' })

export class Credit_CardEntity {
    @PrimaryGeneratedColumn('uuid')
    id: string;

    @Column()
    tipo: string;

    @Column()
    number_card: string;

    @Column({ type: 'datetime', default: '2022-08-11' })
    created_at: Date;

}
