using Lohnausfall.Components.Interfaces;
using Lohnausfall.Core.Models;

namespace Lohnausfall.Components.Services
{
    public class ResidencesService (ApplicationDBContext context) : IResidencesInterface
    {
        private readonly ApplicationDBContext _residencesContext = context;

        public List<Residence> GetAll()
        {
            return [.. _residencesContext.Residences];
        }

        public async Task AddAsync(Residence residence) 
        {
            await _residencesContext.AddAsync(residence);
            await SaveChangesAsync();
        }

        public async Task UpdateAsync(Residence residence)
        {
            _residencesContext.Update(residence);
            await SaveChangesAsync();
        }

        public async Task RemoveAsync(Residence residence)
        {
            _residencesContext.Remove(residence);
            await SaveChangesAsync();
        }

        public async Task SaveChangesAsync()
        {
            await _residencesContext.SaveChangesAsync();
        }
    }
}