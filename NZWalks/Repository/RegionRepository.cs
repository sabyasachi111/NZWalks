using NZWalks.Data;
using NZWalks.Models.Domain;

namespace NZWalks.Repository
{
    public class RegionRepository : IRegionRepository
    {
        private readonly NZWalksDbContext nZWalksDbContext;
        public RegionRepository(NZWalksDbContext nZWalksDbContext)
        {
            this.nZWalksDbContext = nZWalksDbContext;
        }
        public IEnumerable<Region> GetAll()
        {
            return nZWalksDbContext.Regions.ToList();
        }
    }
}
