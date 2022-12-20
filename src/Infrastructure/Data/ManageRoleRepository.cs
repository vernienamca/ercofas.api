using ERCOFAS.ApplicationCore.DTOs;
using ERCOFAS.ApplicationCore.Entities.Security;
using ERCOFAS.ApplicationCore.Interfaces;
using ERCOFAS.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERCOFAS.Api.Infrastructure.Data
{
    public class ManageRoleRepository : EFRepository<PageAccess, int>, IManageRoleRepository
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="ManageRoleRepository"/> class.
        /// </summary>
        /// <param name="context">The database context.</param>
        public ManageRoleRepository(ERCOFASContext context) : base(context)
        {
        }

        #endregion Constructor

        #region Public

        public IQueryable<PageAccess> List()
        {
            return _context.PageAccess;
        }

        public List<ManageRoleDTO> Get(int pageId)
        {
            var data = (from pac in _context.PageAccess
                        join rol in _context.Roles on pac.RoleId equals rol.Id
                        select new ManageRoleDTO()
                        {
                            Id = pac.Id,
                            PageId = pac.PageId,
                            RoleId = pac.RoleId,
                            RoleName = rol.RoleName,
                            CanCreate = pac.CanCreate,
                            CanRead = pac.CanRead,
                            CanUpdate = pac.CanUpdate,
                            CanDelete = pac.CanDelete
                        }).Where(x => x.PageId == pageId).ToList();

            return data;
        }

        public async Task<PageAccess> GetById(int id, int pageId, int roleId)
        {
            return await _context.PageAccess.FirstOrDefaultAsync(x => x.Id == id && x.PageId == pageId && x.RoleId == roleId);
        }

        public async Task<PageAccess> Add(PageAccess manageRole)
        {
            return await AddAsync(manageRole);
        }

        public async Task<PageAccess> Update(PageAccess manageRole)
        {
            return await UpdateAsync(manageRole);
        }

        public Task Delete(PageAccess manageRole)
        {
            return DeleteAsync(manageRole);
        }

        public Task DeleteRange(int pageId, int[] manageRoleIds)
        {
            var rolesToRemove = _context.PageAccess.Where(x => x.PageId == pageId && !manageRoleIds.Contains(x.Id)).ToList();

            return DeleteRangeAsync(rolesToRemove);
        }

        #endregion Public
    }
}
