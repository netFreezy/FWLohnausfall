using Lohnausfall.Components.Interfaces;
using Lohnausfall.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Lohnausfall.Components.Services
{
    public class MembersService (ApplicationDBContext context) : IMembersService
    {
        private readonly ApplicationDBContext _membersContext = context;

        public List<Member> GetAll()
        {
            return [.._membersContext.Members!.Include(member => member.Residence)];
        }

        public async Task AddAsync(Member member) 
        {
            await _membersContext.AddAsync(member);
            await SaveChangesAsync();
        }

        public async Task UpdateAsync(Member member)
        {
            _membersContext.Update(member);
            await SaveChangesAsync();
        }

        public async Task RemoveAsync(Member member)
        {
            _membersContext.Remove(member);
            await SaveChangesAsync();
        }

        public async Task SaveChangesAsync()
        {
            await _membersContext.SaveChangesAsync();
        }
    }
}