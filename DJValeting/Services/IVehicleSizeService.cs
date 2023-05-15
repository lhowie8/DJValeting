using DJValeting.Model;
namespace DJValeting.Services
{
    /// <summary>
    /// Interface for vehicle size service
    /// </summary>
    public interface IVehicleSizeService
    {
        /// <summary>
        /// Get enumerable of vehicle sizes
        /// </summary>
        /// <returns>Enumarable vehicle sizes</returns>
        Task<IEnumerable<VehicleSize>> GetVehicleSizeList();
    }
}
