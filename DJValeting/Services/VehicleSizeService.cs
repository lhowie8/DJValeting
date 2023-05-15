using DJValeting.Data;
using DJValeting.Model;
using Microsoft.EntityFrameworkCore;

namespace DJValeting.Services
{
    public class VehicleSizeService : IVehicleSizeService
    {
        private readonly BusinessDbContext _context;
        public VehicleSizeService(BusinessDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<VehicleSize>> GetVehicleSizeList()
        {
            return await _context.VehicleSizes.OrderBy(x => x.DisplayOrder).ToListAsync();
        }
    }
}
