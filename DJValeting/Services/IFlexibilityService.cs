using DJValeting.Model;

namespace DJValeting.Services
{

    /// <summary>
    /// Interface for flexibility service
    /// </summary>
    public interface IFlexibilityService
    {
        /// <summary>
        /// Get enumerable of flexibilites
        /// </summary>
        /// <returns>Enumarable flexibilities</returns>
        Task<IEnumerable<Flexibility>> GetFlexibilityList();
    }
}
