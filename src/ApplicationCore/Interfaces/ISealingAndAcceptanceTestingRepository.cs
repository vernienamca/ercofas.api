using ERCOFAS.ApplicationCore.Entities.Security;
using System.Linq;
using System.Threading.Tasks;

namespace ERCOFAS.ApplicationCore.Interfaces
{
    public interface ISealingAndAcceptanceTestingRepository
    {
        /// <summary>
        /// Lists the roles.
        /// </summary>
        /// <returns></returns>
        IQueryable<SealingAndAcceptanceTesting> Get();
        /// <summary>
        /// Gets the role by identifier asynchronous.
        /// </summary>
        /// <param name="id">The role identifier.</param>
        /// <returns></returns>
        Task<SealingAndAcceptanceTesting> GetById(int id);
        /// <summary>
        /// Saves the role asynchronous.
        /// </summary>
        /// <param name="role">The role entity.</param>
        /// <returns></returns>
        Task<SealingAndAcceptanceTesting> Add(SealingAndAcceptanceTesting sealing_and_acceptance_testing);
        /// <summary>
        /// Updates the sealing asynchronous.
        /// </summary>
        /// <param name="sealing_and_acceptance_testing">The sealing entity.</param>
        /// <returns></returns>
        Task<SealingAndAcceptanceTesting> Update(SealingAndAcceptanceTesting sealing_and_acceptance_testing);
        /// <summary>
        /// Deletes the role asynchronous.
        /// </summary>
        /// <param name="sealing_and_acceptance_testing">The role entity.</param>
        /// <returns></returns>
        Task Delete(SealingAndAcceptanceTesting sealing_and_acceptance_testing);
    }
}
