namespace Lohnausfall.Components.Models
{
    public class FWMemberModel (int id, string name, string residence)
    {
        public int Id { get; set; } = id;
        public string Name { get; set; } = name;
        public string Residence { get; set; } = residence;
    }
}