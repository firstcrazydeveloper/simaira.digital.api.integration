namespace Ecolab.Simaira.Digital.CustomerPortal.Model.System
{
    using global::System.Collections.Generic;

    public class DishMachineTemperatureDataModel
    {
        public string Unit { get; set; }
        public int AvgRinse { get; set; }
        public int AvgWash { get; set; }
        public int AvgRinseCelsius { get; set; }
        public int AvgWashCelsius { get; set; }
        public List<TemperatureTrend> Trend { get; set; }
    }

    public class TemperatureTrend
    {
        public string Date { get; set; }
        public string Year { get; set; }
        public string Day { get; set; }
        public int Wash { get; set; }
        public int Rinse { get; set; }
        public int WashCelsius { get; set; }
        public int RinseCelsius { get; set; }
        public int AvgTemp { get; set; }
    }
}