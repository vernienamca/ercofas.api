using ERCOFAS.ApplicationCore.DTOs;
using ERCOFAS.ApplicationCore.Entities.Security;
using ERCOFAS.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERCOFAS.ApplicationCore.Services
{
    public class RoleService : IRoleService
    {
        #region Variables

        private readonly IRoleRepository _repository;

        #endregion Variables

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="RoleRepository"/> class.
        /// </summary>
        /// <param name="context">The database context.</param>
        public RoleService(IRoleRepository repository)
        {
            _repository = repository;
        }

        #endregion Constructor

        #region Public

        public IQueryable<Role> Get()
        {
            return _repository.Get();
        }

        public async Task<Role> GetById(int id)
        {
            return await _repository.GetById(id);
        }

        public async Task<Role> Add(RoleDTO roleDTO)
        {
            var role = new Role()
            {
                RoleName = roleDTO.RoleName,
                Description = roleDTO.Description,
                CreatedBy = roleDTO.CreatedBy,
                DateCreated = DateTime.Now
            };

            try
            {
                return await _repository.Add(role);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Role> Update(RoleDTO roleDTO)
        {
            var role = _repository.GetById(roleDTO.Id).Result;
            role.RoleName = roleDTO.RoleName;
            role.Description = roleDTO.Description;
            role.UpdatedBy = roleDTO.UpdatedBy;
            role.DateUpdated = roleDTO.DateUpdated;

            return await _repository.Update(role);
        }

        #endregion Public
    }
}
