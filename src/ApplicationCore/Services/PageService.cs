using ERCOFAS.ApplicationCore.DTOs;
using ERCOFAS.ApplicationCore.Entities.Security;
using ERCOFAS.ApplicationCore.Interfaces;
using System.Linq;
using System.Threading.Tasks;

namespace ERCOFAS.ApplicationCore.Services
{
    public class PageService : IPageService
    {
        #region Variables

        private readonly IPageRepository _repository;

        #endregion Variables

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="PageService"/> class.
        /// </summary>
        /// <param name="repository">The page repository.</param>
        public PageService(IPageRepository repository)
        {
            _repository = repository;
        }

        #endregion Constructor

        #region Public

        public IQueryable<Page> Get()
        {
            return _repository.Get();
        }

        public async Task<Page> GetById(int id)
        {
            return await _repository.GetById(id);
        }

        public async Task<Page> Update(PageDTO pageDTO)
        {
            var page = _repository.GetById(pageDTO.Id).Result;
            page.PageName = pageDTO.PageName;
            page.Description = pageDTO.Description;
            page.UrlPath = pageDTO.UrlPath;
            page.AccessibleByAll = pageDTO.AccessibleByAll;
            page.IsActive = pageDTO.IsActive;

            return await _repository.Update(page);
        }

        #endregion Public
    }
}
