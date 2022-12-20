using ERCOFAS.ApplicationCore.Entities.Structure;
using ERCOFAS.ApplicationCore.Interfaces;
using System.Linq;

namespace ERCOFAS.ApplicationCore.Services
{
    public class RERClassificationService : IRERClassificationService
    {
        #region Variables

        private readonly IRERClassificationRepository _repository;

        #endregion Variables

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="RERClassificationService"/> class.
        /// </summary>
        /// <param name="repository">The RER classification repository.</param>
        public RERClassificationService(IRERClassificationRepository repository)
        {
            _repository = repository;
        }

        #endregion Constructor

        #region Public

        public IQueryable<RERClassification> GetRERClassifications(byte? userTypeId)
        {
            return _repository.GetRERClassifications(userTypeId);
        }

        #endregion Public
    }
}
