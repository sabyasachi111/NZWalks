using NZWalks.Data;
using NZWalks.Models.Domain;

namespace NZWalks.Repository
{
    public interface IRegionRepository
    {
        IEnumerable<Region> GetAll();
    }
}
