using DJValeting.Data;
using DJValeting.Model;
using Microsoft.EntityFrameworkCore;

namespace DJValeting.Services
{
    public class FlexibilityService : IFlexibilityService
    {
        private readonly BusinessDbContext _context;

        public FlexibilityService(BusinessDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Flexibility>> GetFlexibilityList()
        {
            return await _context.Flexibilities.OrderBy(x => x.DisplayOrder).ToListAsync();
        }
    }
}
