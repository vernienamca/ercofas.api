using ERCOFAS.ApplicationCore.DTOs;
using ERCOFAS.ApplicationCore.Entities.Structure;
using System.Linq;
using System.Threading.Tasks;

namespace ERCOFAS.ApplicationCore.Interfaces
{
    public interface IHearingRepository
    {
        /// <summary>
        /// Lists the hearing by user id.
        /// </summary>
        /// <param name="id">The user id identifier.</param>
        /// <returns></returns>
        IQueryable<HearingDTO> Get(int? userId = null);
        /// <summary>
        /// Lists the hearings.
        /// </summary>
        /// <returns></returns>
        IQueryable<Hearing> Get();
        /// <summary>
        /// Gets the hearing record by identifier asynchronous.
        /// </summary>
        /// <param name="id">The hearing record identifier.</param>
        /// <returns></returns>
        Task<Hearing> GetById(int id);
        /// <summary>
        /// Saves the hearing record asynchronous.
        /// </summary>
        /// <param name="hearing">The hearing record entity.</param>
        /// <returns></returns>
        Task<Hearing> Add(Hearing hearing);
        /// <summary>
        /// Updates the hearing record asynchronous.
        /// </summary>
        /// <param name="hearing">The hearing record entity.</param>
        /// <returns></returns>
        Task<Hearing> Update(Hearing hearing);
        /// <summary>
        /// Deletes the hearing record asynchronous.
        /// </summary>
        /// <param name="hearing">The hearding record entity.</param>
        /// <returns></returns>
        Task Delete(Hearing hearing);
    }
}
