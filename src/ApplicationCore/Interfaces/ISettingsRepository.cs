using ERCOFAS.ApplicationCore.Entities.Structure;
using System.Linq;
using System.Threading.Tasks;

namespace ERCOFAS.ApplicationCore.Interfaces
{
    public interface ISettingsRepository
    {
        /// <summary>
        /// Lists the settings.
        /// </summary>
        /// <returns></returns>
        IQueryable<Settings> Get();
        /// <summary>
        /// Gets the settings by identifier asynchronous.
        /// </summary>
        /// <param name="id">The settings identifier.</param>
        /// <returns></returns>
        Task<Settings> GetById(int id);
        /// <summary>
        /// Saves the settings asynchronous.
        /// </summary>
        /// <param name="settings">The settings entity.</param>
        /// <returns></returns>
        Task<Settings> Add(Settings settings);
        /// <summary>
        /// Updates the settings asynchronous.
        /// </summary>
        /// <param name="settings">The settings entity.</param>
        /// <returns></returns>
        Task<Settings> Update(Settings settings);
    }
}
