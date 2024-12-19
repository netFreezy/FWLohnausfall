using System.Drawing;

namespace Lohnausfall.Core.Models
{
    public class WindowsPrinter (int id, string name, bool isDefaultPrinter = false)
    {
        public int Id { get; set; } = id;
        public string Name { get; set; } = name;
        public bool IsDefaultPrinter { get; set; } = isDefaultPrinter;
        public bool IsOnline { get; set; } = false;
        public string Status { get; set; } = "";
    }
}