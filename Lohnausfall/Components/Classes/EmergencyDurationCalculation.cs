namespace Lohnausfall.Components.Classes
{
    public class EmergencyDurationCalculation (TimeSpan start, TimeSpan ende)
    {
        private readonly TimeSpan _start = start;
        private readonly TimeSpan _ende = ende;

        private double CalculateDurationInDecimal()
        {
            TimeSpan dauer;

            if (_ende < _start)  // Falls der Einsatz über Mitternacht geht, wird ein Tag hinzugefügt
                dauer = _ende + TimeSpan.FromDays(1) - _start;
            else dauer = _ende - _start;

            return dauer.TotalHours;
        }

        private static double RoundDuration(double dezimaleDauer)
        {
            // Rundet auf die nächste halbe oder ganze Stunde
            return Math.Ceiling(dezimaleDauer * 2) / 2.0;
        }

        public (double, TimeSpan) GetDuration() // Rückgabe gerundete Dauer und Endzeit
        {
            var dauerInDezimal = CalculateDurationInDecimal();
            var gerundet = RoundDuration(dauerInDezimal);

            return (gerundet, _start.Add(TimeSpan.FromHours(gerundet)));
        }
    }
}