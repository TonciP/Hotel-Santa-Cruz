import {
  Column,
  Entity,
  PrimaryGeneratedColumn,
} from 'typeorm';

@Entity({ name: 'huespedes' })
export class HuespedesEntity {
  @PrimaryGeneratedColumn('uuid')
  id: string;

  @Column()
  dni: string;

  @Column({ type: 'datetime', default: '2022-08-11' })
  created_at: Date;

}
