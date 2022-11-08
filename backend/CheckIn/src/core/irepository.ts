import { Entity } from './entity.model';

export interface IRespository<T extends Entity> {
  create: (dto: T) => Promise<T>;
  update: (dto: T) => Promise<T>;
  getById: (id: string) => Promise<T>;
  getAll: () => Promise<T[]>;
  delete: (id: string) => Promise<T>;
}
