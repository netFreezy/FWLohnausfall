using Lohnausfall.Core.Models;

namespace Lohnausfall.Components.Interfaces
{
    public interface IResidencesInterface
    {
        public List<Residence> GetAll();
        public Task AddAsync(Residence residence);
        public Task UpdateAsync(Residence residence);
        public Task RemoveAsync(Residence residence);
        public Task SaveChangesAsync();
    }
}