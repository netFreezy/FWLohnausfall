namespace Lohnausfall.Components.Models
{
    public class PrinterModel (int id, string name, bool isDefaultPrinter = false)
    {
        public int Id { get; set; } = id;
        public string Name { get; set; } = name;
        public bool IsDefaultPrinter { get; set; } = isDefaultPrinter;
    }
}