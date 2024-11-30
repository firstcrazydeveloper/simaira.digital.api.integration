using System;
using System.Collections.Generic;
using System.Text;

namespace Ecolab.Simaira.Digital.CustomerPortal.Model.System
{
    public class KustoAvgTemperatureDataModel
    {
        public string LocalDate { get; set; }
        public string DayofWeek { get; set; }
        public DateTime PeriodAxis { get; set; }

        public double RinseTempAverage { get; set; }
        public double WashTempAverage { get; set; }
    }
}