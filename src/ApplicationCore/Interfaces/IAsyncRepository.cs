﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace ERCOFAS.ApplicationCore.Interfaces
{
    public interface IAsyncRepository<EntityType, IdType> where EntityType : BaseEntity<IdType>
    {
        Task<List<EntityType>> ListAllAsync();
        Task<EntityType> AddAsync(EntityType entity);
        Task<EntityType> UpdateAsync(EntityType entity);
        Task DeleteAsync(EntityType entity);
    }
}
