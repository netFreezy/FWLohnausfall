using Lohnausfall.Core.Models;

namespace Lohnausfall.Components.Interfaces
{
    public interface IMembersService
    {
        public List<Member> GetAll();
        public Task AddAsync(Member member);
        public Task UpdateAsync(Member member);
        public Task RemoveAsync(Member member);
        public Task SaveChangesAsync();
    }
}