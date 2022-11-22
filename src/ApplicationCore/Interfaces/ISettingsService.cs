using ERCOFAS.ApplicationCore.DTOs;
using ERCOFAS.ApplicationCore.Entities.Structure;
using System.Linq;
using System.Threading.Tasks;

namespace ERCOFAS.ApplicationCore.Interfaces
{
    public interface ISettingsService
    {
        IQueryable<Settings> Get();
        Task<Settings> GetById(int id);
        Task<Settings> Add(SettingsDTO settingsDTO);
        Task<Settings> Update(SettingsDTO settingsDTO);
    }
}
