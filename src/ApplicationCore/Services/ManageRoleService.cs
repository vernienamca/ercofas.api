using ERCOFAS.ApplicationCore.DTOs;
using ERCOFAS.ApplicationCore.Entities.Security;
using ERCOFAS.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERCOFAS.ApplicationCore.Services
{
    public class ManageRoleService : IManageRoleService
    {
        #region Variables

        private readonly IManageRoleRepository _repository;

        #endregion Variables

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="ManageRoleService"/> class.
        /// </summary>
        /// <param name="repository">The page access repository.</param>
        public ManageRoleService(IManageRoleRepository repository)
        {
            _repository = repository;
        }

        #endregion Constructor

        #region Public

        public IQueryable<PageAccess> List()
        {
            return _repository.List();
        }

        public List<ManageRoleDTO> Get(int pageId)
        {
            return _repository.Get(pageId);
        }

        public async Task<PageAccess> GetById(int id, int pageId, int roleId)
        {
            return await _repository.GetById(id, pageId, roleId);
        }

        public async Task<PageAccess> Add(ManageRoleDTO manageRoleDTO)
        {
            var manageRole = new PageAccess()
            {
                PageId = manageRoleDTO.PageId,
                RoleId = manageRoleDTO.RoleId,
                CanCreate = manageRoleDTO.CanCreate,
                CanRead = manageRoleDTO.CanRead,
                CanDelete = manageRoleDTO.CanDelete,
                CanUpdate = manageRoleDTO.CanUpdate,
                CreatedBy = 1,
                DateCreated = DateTime.Now
            };

            try
            {
                return await _repository.Add(manageRole);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<PageAccess> Update(ManageRoleDTO manageRoleDTO, PageAccess manageRole)
        {
            manageRole.CanCreate = manageRoleDTO.CanCreate;
            manageRole.CanRead = manageRoleDTO.CanRead;
            manageRole.CanUpdate = manageRoleDTO.CanUpdate;
            manageRole.CanDelete = manageRoleDTO.CanDelete;
            manageRole.UpdatedBy = 1;
            manageRole.DateUpdated = DateTime.Now;

            return await _repository.Update(manageRole);
        }

        public async Task Delete(PageAccess manageRole)
        {
            await _repository.Delete(manageRole);
        }

        public async Task DeleteRange(int pageId, int[] manageRoleIds)
        {
            await _repository.DeleteRange(pageId, manageRoleIds);
        }

        #endregion Public
    }
}
