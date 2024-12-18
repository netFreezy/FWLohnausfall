using System.ComponentModel.DataAnnotations.Schema;

namespace Lohnausfall.Core.Models
{
    [Table("residences")]
    public class Residence
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public ICollection<Member> Members { get; } = [];
    }
}