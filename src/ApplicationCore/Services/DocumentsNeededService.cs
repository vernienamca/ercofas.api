using ERCOFAS.ApplicationCore.Interfaces;
using System.Linq;

namespace ERCOFAS.ApplicationCore.Services
{
    public class DocumentsNeededService : IDocumentsNeededService
    {
        #region Variables

        private readonly IDocumentsNeededRepository _repository;

        #endregion Variables

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentsNeededService"/> class.
        /// </summary>
        /// <param name="repository">The documents needed repository.</param>
        public DocumentsNeededService(IDocumentsNeededRepository repository)
        {
            _repository = repository;
        }

        #endregion Constructor

        #region Public

        public IQueryable<dynamic> Get(string purpose)
        {
            return _repository.Get(purpose);
        }

        #endregion Public
    }
}
