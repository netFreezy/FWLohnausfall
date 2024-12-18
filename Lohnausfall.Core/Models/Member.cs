using System.ComponentModel.DataAnnotations.Schema;

namespace Lohnausfall.Core.Models
{
    [Table("members")]
    public class Member
    {
        public int Id { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public int? ResidenceId { get; set; }
        public Residence? Residence { get; set; } = null;
    }
}