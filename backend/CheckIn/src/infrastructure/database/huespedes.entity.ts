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

  @Column({ type: 'datetime', default: '1980-01-01' })
  created_at: Date;

}
