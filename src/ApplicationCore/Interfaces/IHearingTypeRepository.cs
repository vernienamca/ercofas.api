using ERCOFAS.ApplicationCore.Entities.Structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERCOFAS.ApplicationCore.Interfaces
{
    public interface IHearingTypeRepository
    {
        /// <summary>
        /// Lists the hearing types.
        /// </summary>
        /// <returns></returns>
        IQueryable<HearingType> Get();
        /// <summary>
        /// Gets the hearing type by identifier asynchronous.
        /// </summary>
        /// <param name="id">The hearing type identifier.</param>
        /// <returns></returns>
        Task<HearingType> GetById(byte id);
        /// <summary>
        /// Saves the hearing type asynchronous.
        /// </summary>
        /// <param name="hearingType">The hearing type entity.</param>
        /// <returns></returns>
        Task<HearingType> Add(HearingType hearingType);
        /// <summary>
        /// Updates the hearing type asynchronous.
        /// </summary>
        /// <param name="hearingType">The hearing type entity.</param>
        /// <returns></returns>
        Task<HearingType> Update(HearingType hearingType);
        /// <summary>
        /// Deletes the hearing type asynchronous.
        /// </summary>
        /// <param name="hearingType">The hearding type entity.</param>
        /// <returns></returns>
        Task Delete(HearingType hearingType);
    }
}
