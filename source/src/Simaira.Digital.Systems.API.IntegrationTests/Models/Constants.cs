namespace Ecolab.Simaira.Digital.CustomerPortal.Model
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Globalization;
    using global::System.IO;
    using global::System.Linq;
    using Newtonsoft.Json.Linq;

    public class Constants
    {
        /// <summary>
        /// Brand standards categories are of Service and Lodging type
        /// </summary>
        public enum BrandStandardCategory
        {
            service,
            lodging
        }

        /// <summary>
        //PageComponent ID added for DishmachineGoals
        /// </summary>
        public enum PageComponentName
        {
            unknown,
            dishmachinegoals,
            overallperformance,
            dishracksusage,
            benchmarking,
            benchmarkingbyaccount,
            optimalproductsforunit,
            outstandingcategories,
            visualalerts,
            topfilter,
            alertactivitytracking,
            useralignment,
            temperaturetrend,
            optimalproductsforcorporate,
            hierarchylevel,
            areatofocusbubble,
            locationdetails,
            accountdetails,
            devicesalerttrends,
            accountdetailsbyaccount,
            hierarchybyh7,
            hhbenchmarking,
            hhoverallperformance,
            ssoverallperformance,
            ssoverallperformance_overview,
            dispenserlevel,
            shiftlevel,
            dmgoalperformanceshift,
            hhoverallperformancenew,
            hhlocationoverallperformance,
            useralignmentsperuser,
            hhshiftwiseoverallperformance,
            purchasingcategoriescompliance,
            optimalproductsaccess,
            purchasingoverallperformancebycategories
        }

        /// <summary>
        /// Program Category is the name of the category come from pageLoad request like DishMachine/Handcare/Surface sanitizer
        /// </summary>
        public enum ProgramCategory
        {
            unknown,
            DM,
            HH,
            SS,
            HSO,
            HSA
        }

        /// <summary>
        /// Default Fileter come from pageLoad request based on alert filter will work
        /// </summary>
        public enum BubbleTypes
        {
            shiftweekday,
            shiftservice,
            alertshift,
            alertservice,
            alertweekday,
            serviceweekday,
            AlertType,
            Shift,
            Day,
            ServiceArea
        }

        /// <summary>
        /// PageContextName is the name of the context come from pageLoad request
        /// </summary>
        public enum PageContextName
        {
            unknown,
            brandstandards,
            products,
            aggregatedinsights,
            insightsubscription,
            dishmachinedetails,
            purchasing,
            alertdetail,
            topfilter,
            landingoverview,
            corporatelocations,
            pulsecheck,
            accountdetails,
            hierarchy,
            hhdetails,
            ssdetails,
            pulsecheckoverview
        }

        public static string[] ShortWeekDays = { "Su", "Mo", "Tu", "We", "Th", "Fr", "Sa" };
        public static string[] ShiftDayOfWeekAry = { "Su", "M", "Tu", "W", "Th", "F", "Sa" };
        public static string ShiftDayOfWeek(DateTime date) => ShiftDayOfWeekAry[(int)date.DayOfWeek];
        public static string TimeFormat = @"hh\:mm\:ss";
        public static string SFDCTokenInvalid = "Token Expired";

        public static string[] FilterAccounts = { "10", "30" };

        public static string KustoDMBenchmarking(string DeviceId) => $"declare query_parameters(EventTimeSpan:timespan =30d);mvw_Simaira.DigitalDailyEvents| where deviceID has_any({$@"{DeviceId}"}) and PeriodAxis >= ago(EventTimeSpan)|summarize pctgoodracks = 100 * (sum(RackCount) - sum(AllAlertSum)) / sum(RackCount)";

        public static string GetServiceAreasForDM(string AccountNo) => $"SELECT+Asset.LocationId,Location.Name,Linked_Asset_Serial_Number__c,Name,Account.AccountNumber,Linked_Asset_ID__r.Application_Type__c+FROM+Asset+WHERE+Asset_Type__c+IN+('DMSG',+'DMCV','DMFT')+AND+Linked_Asset_Serial_Number__c!=+null+AND+Connected__c=+true+AND+Account.AccountNumber+in({$@"{AccountNo}"})";

        public static string GetServiceAreasForHH(string AccountNumbers) => $"SELECT+Asset.LocationId,Asset.Device_Serial_Number__c,Location.Name,Name,Account.AccountNumber,Dispenser_Product__c+FROM+Asset+WHERE+Asset_Type__c+IN+('HCTF','HCM')+AND+Connected__c=+true+AND+Account.AccountNumber+in({$@"{AccountNumbers}"})";

        public static string GetServiceAreasForSS(string AccountNumbers) => $"SELECT+Asset.LocationId,Asset.Device_Serial_Number__c,Location.Name,Name,Account.AccountNumber+FROM+Asset+WHERE+Asset_Type__c+IN+('CD')+AND+Connected__c=+true+AND+Dispenser_Product__c LIKE '%sanitizer%'+AND+Account.AccountNumber+in({$@"{AccountNumbers}"})";

        public static string GetServiceAreasForSSDevice(string DeviceIds) => $"SELECT+Asset.LocationId,Asset.Device_Serial_Number__c,Name,Account.AccountNumber+FROM+Asset+WHERE+Asset.Device_Serial_Number__c+in({$@"{DeviceIds}"})";

        public static string GetServiceAreasForDMDevice(string DeviceIds) => $"SELECT+Asset.LocationId,Asset.Device_Serial_Number__c,Account.AccountNumber+FROM+Asset+WHERE+Asset.Device_Serial_Number__c+in({$@"{DeviceIds}"})";

        public static string GetServiceAreasForHHDevice(string DeviceIds) => $"SELECT+Asset.LocationId,Asset.Device_Serial_Number__c,Name,Account.AccountNumber+FROM+Asset+WHERE+Asset.Device_Serial_Number__c+in({$@"{DeviceIds}"})";

        public static string GetServiceAreasForHSO(string AccountNumbers) => $"SELECT+Asset.LocationId,Asset.Device_Serial_Number__c,Location.Name,Name,Account.AccountNumber+FROM+Asset+WHERE+Asset_Type__c+IN+('HCM','HCTF')+AND+Connected__c=+true+AND+Dispenser_Product__c LIKE '%soap%'+AND+Account.AccountNumber+in({$@"{AccountNumbers}"})";

        public static string GetServiceAreasForHSA(string AccountNumbers) => $"SELECT+Asset.LocationId,Asset.Device_Serial_Number__c,Location.Name,Name,Account.AccountNumber+FROM+Asset+WHERE+Asset_Type__c+IN+('HCM','HCTF')+AND+Connected__c=+true+AND+Dispenser_Product__c LIKE '%sanitizer%'+AND+Account.AccountNumber+in({$@"{AccountNumbers}"})";

        public static string GetViewConditionStatement(string viewName) => string.Format("TableName = '{0}'", viewName);
        public static string GetViewConditionStatementForSS(string viewName, bool selectDelta) => string.Format("TableName = '{0}' AND IsDelta = {1}", viewName, selectDelta);

        public static string KustoQueryParameters(int days)
        {
            return $"declare query_parameters(EventTimeSpan:timespan = {days}d);" + "\n"; ;
        }
        public static string GetDeviceIdsInQueryFormat(IEnumerable<string> deviceIds)
        {
            return string.Format("'{0}'", string.Join("','", deviceIds.Select(id => id.Replace("'", "''"))));
        }

        public static string KustoCommomDateTimeVariableParameters()
        {
            return $"let _start = startofday(now(-EventTimeSpan));" + "\n" +
            $"let _end = _start + EventTimeSpan;" + "\n" +
            $"let _halfTimeSpan = totimespan(EventTimeSpan / 2);" + "\n";
        }

        public static string KustoViewsName(string viewsName)
        {
            return @"union withsource = TableName " + viewsName + "\n"; ;
        }


        public static string KustoDMVisualTemperatureTrend(string deviceIds, string groupName)
        {
            return $" let {groupName} = view() {specialLeftChar} materialized_view(\"mvw_Simaira.DigitalDailyEvents\", 1h)" + "\n" +
                    $" | where deviceID has_any({deviceIds}) and PeriodAxis >= ago(EventTimeSpan)" + "\n" +
                    $" |summarize" + "\n" +
                    $" RinseTempAverage = avg(RinseTempAvg)" + "\n" +
                    $" ,WashTempAverage = avg(WashTempAvg)" + "\n" +
                    $" by  LocalDate, DayofWeek, PeriodAxis {specialRightChar};" + "\n";
        }

        public static string specialLeftChar = @"{";
        public static string specialRightChar = @"}";

        public static string KustoOverallPerformance(string deviceIds, string groupName)
        {
            return
            $" let {groupName} = view() {specialLeftChar} " +
            $" materialized_view(\"mvw_Simaira.DigitalDailyEvents\", 1h)" + "\n" +
            $"| where deviceID has_any({ deviceIds} ) and PeriodAxis >= ago(EventTimeSpan)" + "\n" +
            $"| extend _bin = bin_at(PeriodAxis, 1d, _start)" + "\n" +
            $"| extend _endRange = iif(_bin + _halfTimeSpan > _end, _end," + "\n" +
            $"                iff(_bin + _halfTimeSpan - 1d < _start, _start," + "\n" +
            $"                   iff(_bin + _halfTimeSpan - 1d < _bin, _bin, _bin + _halfTimeSpan - 1d)))" + "\n" +
            $"| extend _range = range(_bin, _endRange, 1d)" + "\n" +
            $"| mv-expand _range to typeof(datetime) limit 10000" + "\n" +
            $"| summarize" + "\n" +
            $"  AllAllertAgg = sum(AllAlertSum)," + "\n" +
            $"  RackCountAgg = sum(RackCount), " + "\n" +
            $"  pctgoodracksagg = 100 * (sum(RackCount) - sum(AllAlertSum)) / sum(RackCount) by PeriodAxis = bin_at(_range, 1d, _start)" + "\n" +
            $"| where PeriodAxis >= _start + _halfTimeSpan" + "\n" +
            $"| extend LocalDate = format_datetime(PeriodAxis, 'MM/dd'),DayofWeek = dayofweek(PeriodAxis) {specialRightChar};" + "\n";
        }

        public static string KustoDevicesAlertTrends(string deviceIds, string groupName)
        {
            return
            $" let {groupName} = view() {specialLeftChar} " +
            $" materialized_view(\"mvw_Simaira.DigitalDailyEvents\", 1h)" + "\n" +
            $"| where deviceID has_any({ deviceIds} ) and PeriodAxis >= ago(EventTimeSpan)" + "\n" +
            $"| summarize" + "\n" +
            $"  goodRackCountDaily = sum(RackCount) - sum(AllAlertSum)," + "\n" +
            $"  badRackCountDaily = sum(AllAlertSum)," + "\n" +
            $"  goodRackPercentageDaily = 100*(sum(RackCount) - sum(AllAlertSum))/sum(RackCount), " + "\n" +
            $"  rackCountDaily = sum(RackCount)," + "\n" +
            $"  allAlertCountDaily= sum(AllAlertSum)" + "\n" +
            $"  by  LocalDate, DayofWeek, PeriodAxis {specialRightChar};" + "\n";
        }

        public static string KustoDishRackUsage(string DeviceID, string groupName)
        {
            return $" let {groupName} = view() {specialLeftChar} materialized_view(\"mvw_Simaira.DigitalDailyEvents\",1h)| where deviceID has_any({DeviceID}) and PeriodAxis >= ago(EventTimeSpan)" + "\n" +
            $"| extend _bin = bin_at(PeriodAxis, 1d, _start)" + "\n" +
            $"| extend _endRange = iif(_bin + _halfTimeSpan > _end, _end," + "\n" +
            $"                            iff(_bin + _halfTimeSpan - 1d < _start, _start," + "\n" +
            $"                                iff(_bin + _halfTimeSpan - 1d < _bin, _bin, _bin + _halfTimeSpan - 1d)))" + "\n" +
            $"| extend _range = range(_bin, _endRange, 1d)" + "\n" +
            $"| mv-expand _range to typeof(datetime) limit 60" + "\n" +
            $"| summarize RackCountAgg = sum(RackCount) by PeriodAxis = bin_at(_range, 1d, _start)" + "\n" +
            $"| where PeriodAxis >= _start + _halfTimeSpan + 1d" + "\n" +
            $"| extend LocalDate=format_datetime(PeriodAxis,'MM/dd'),DayofWeek = dayofweek(PeriodAxis)" + "\n" +
            $"| join kind = inner(materialized_view(\"mvw_Simaira.DigitalDailyEvents\", 1h)| where deviceID has_any({ DeviceID}) and PeriodAxis >= ago(EventTimeSpan)" + "\n" +
            $"| summarize" + "\n" +
            $"IssuesDaily = sum(AllAlertSum)" + "\n" +
            $", NoIssuesDaily = sum(RackCount) - sum(AllAlertSum)" + "\n" +
            $", RackCountDaily = sum(RackCount)" + "\n" +
            $"by LocalDate, DayofWeek, PeriodAxis" + "\n" +
            $") on PeriodAxis" + "\n" +
            $"|project-away DayofWeek1, PeriodAxis1, LocalDate1" + "\n" +
            $"|order by PeriodAxis desc {specialRightChar};" + "\n";
        }

        public static string KustoSSOverallPerformance(string deviceIds, string groupName)
        {
            return
            $" let {groupName} = view() {specialLeftChar} vw_SSEvents" +
            $"| where MACAddressString has_any({ deviceIds} ) and startofday(dateTimeLocal) >= ago(EventTimeSpan)" + "\n" +
            $"| summarize RefilCount = count() by MACAddressString, startofday(dateTimeLocal)," + "\n" +
            $"IsDelta = iff(startofday(dateTimeLocal) < ago(_halfTimeSpan), true , false)" + "\n" +
            $"| summarize AvgRefilCount = avg(RefilCount) by dateTimeLocal,IsDelta {specialRightChar};";
        }

        public static string KustoSSEventsQueryV2(string viewName, string deviceIds)
        {
            return
            $"mvw_WirelessAggregatorSensorEvents \n" +
            $"| where EventCode == 1 and SubEventCode == 1 \n" +
            $"and EventDateTimeUtc > now(-60d) and EventDateTimeUtc<now() \n" +
            $"| sort by MACAddress desc, InputCounter desc, EventDateTimeUtc desc \n" +
            $"| extend count1 = iff(prev(MACAddress) == MACAddress, \n" +
            $"iff(prev(InputCounter) == InputCounter, \n" +
            $"iff(datetime_diff('day', prev(EventDateTimeUtc), (EventDateTimeUtc)) < 1, 0, 1), \n" +
            $"1), \n" +
            $"1) \n" +
            $"| where ['count1'] == 1 and DataOne between(1...1799) and startofday(EventDateTimeLocal) >= ago(EventTimeSpan) and MACAddressString in({ deviceIds}) \n" +
            $"| project-away['count1'] \n" +
            $"| project MACAddressString,EventDateTimeLocal,EventDateTimeUtc;";
        }

        public static string KustoHHEventsQueryV2(string viewName, string deviceIds)
        {
            return
           $"mvw_WirelessAggregatorSensorEvents\n" +
           $"| where MACAddressString in({ deviceIds})\n" +
           $"and EventCode == 1 and SubEventCode == 1 and EventDateTimeUtc > now(-60d)\n" +
           $"| sort by MACAddress desc, InputCounter desc, EventDateTimeUtc desc\n" +
           $"| extend count1=iff(prev(MACAddress) == MACAddress,\n" +
           $"iff(prev(InputCounter)==InputCounter,\n" +
           $"iff(datetime_diff('day', prev(EventDateTimeUtc), (EventDateTimeUtc)) < 1, 0, 1),\n" +
           $"1),\n" +
           $"1)\n" +
           $"| where['count1'] == 1\n" +
           $"| sort by MACAddress desc, EventDateTimeUtc desc\n" +
           $"| extend flag = iff(prev(MACAddress) == MACAddress,iff((prev(EventDateTimeUtc)-(EventDateTimeUtc)<time(00:00:20)), 0, 1), 1)\n" +
           $"| where flag == 1 and startofday(EventDateTimeLocal) >= ago(EventTimeSpan) | project-away  flag,['count1']\n" +
           $"| project  messageType,deviceID, dateTimeLocal, dateTimeUtc, EventProcessedUtcTime,PartitionId,\n" +
           $"EventEnqueuedUtcTime, DataOne,DataTwo,DataThree,DataFour,InputID,RSSI,ElapsedTime,\n" +
           $"EventId,EventCode,SubEventCode,MACAddress,CommissionedSensorID,InputCounter,EventDateTimeLocal,EventDateTimeUtc,\n" +
           $"EventEpochLocal,EventEpochUtc, MACAddressString\n" +
           $"| project MACAddressString,EventDateTimeLocal,EventDateTimeUtc;";
        }

        public static string KustoDMEventsQuery(string viewName, string deviceIds)
        {
            return
            $"{viewName} | where deviceID has_any({ deviceIds})\n" +
            $"and PeriodAxis >= ago(EventTimeSpan)\n" +
            $"| summarize pctgoodracksagg = 100 * (sum(RackCount) - sum(AllAlertSum)) / sum(RackCount) by PeriodAxis, deviceID" + "\n" +
            $"| project deviceID,PeriodAxis,pctgoodracksagg";
        }

        public static string KustoDMEventsQueryV2(string viewName, string deviceIds)
        {
            return
            $"{viewName} | where deviceID has_any({ deviceIds})\n" +
            $"and PeriodAxis >= ago(EventTimeSpan)\n" +
            $"| project deviceID, PeriodAxis, RackCount, AllAlertSum";
        }

        public static string KustoSSBenchmarking(string deviceIds)
        {
            return
            $"declare query_parameters(EventTimeSpan:timespan = 30d);" + "\n" +
            $"db_SSEvents" + "\n" +
            $"| where MACAddressString has_any({deviceIds}) and startofday(EventDateTimeLocal) >= ago(EventTimeSpan)" + "\n" +
            $"| summarize RefilCount = count() by MACAddressString, startofday(EventDateTimeLocal)" + "\n";
        }

        public const string EmailRegExpression = @"^([a-zA-Z0-9+_\-\.]+)@((\[[0-9]{1,3}" +
                                                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9+\-]+\" +
                                                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";


        public enum CDMOriginationAccountSystemCode
        {
            ECL_EBS = 1
        }

        public static string GetConnectedAccountsByH7ID(string h7ID) => $"SELECT AccountNumber FROM Account WHERE Contract_Agreement__c ={$@"'{h7ID}'"} and connected__c= true";

        public static string HHInsightSelectColumns = "c.id, c.cdmSiteKey, c.startDateTimeEpoch, c.serviceAreaID, c.insightResultParameters";

        public static List<List<T>> SegregateEntity<T>(IEnumerable<T> entityList, int batchSize, int index)
        {
            if (entityList.Count() < (index * batchSize))
            {
                return new List<List<T>>();
            }
            List<List<T>> result = new List<List<T>>
            {
                entityList.Skip(index * batchSize).Take(batchSize).ToList()
            };
            index++;
            result.AddRange(SegregateEntity<T>(entityList, batchSize, index));
            return result;
        }
        public static string GetNextDayOfWeek(string dayOfWeek)
        {
            var index = Array.IndexOf(ShiftDayOfWeekAry, dayOfWeek);
            if (index == (ShiftDayOfWeekAry.Length - 1))
            {
                return ShiftDayOfWeekAry[0];
            }
            return ShiftDayOfWeekAry[index + 1];
        }

        public static string GetPrevDayOfWeek(string dayOfWeek)
        {
            var index = Array.IndexOf(ShiftDayOfWeekAry, dayOfWeek);
            if (index == 0)
            {
                return ShiftDayOfWeekAry[ShiftDayOfWeekAry.Length - 1];
            }
            return ShiftDayOfWeekAry[index - 1];
        }

        public static DateTime GetLocalStartTime(DateTime local, DateTime utc, int numberOfDays)
        {
            if (numberOfDays > 2) numberOfDays++;
            double span = utc.Subtract(local).TotalMinutes;
            return DateTime.UtcNow.AddMinutes(span).AddDays(numberOfDays * -1).Date;
        }
        public static DateTime GetLocalStartTime(double offset, int numberOfDays)
        {
            return DateTime.UtcNow.AddHours(offset).AddDays(numberOfDays * -1).Date;
        }
        public enum SSViewType
        {
            vw_SSEvents,
            db_SSEvents
        }

        public enum HHViewType
        {
            vw_HHEvents,
            db_HHEvents
        }

        public enum KustoMaterlizedViewType
        {
            vw_HHEvents,
            db_HHEvents,
            vw_SSEvents,
            db_SSEvents,
            mvw_E3DWWShiftEvents,
        }

        public enum SiteIdentifier
        {
            CdmSite,
            GraphNodeSiteKey
        }


        public static T ParseEnum<T>(string value)
        {
            return (T)Enum.Parse(typeof(T), value, true);
        }

        public enum DMViewType
        {
            mvw_E3DWWShiftEvents
        }
        public static double GetOffsetByTimeZoneKey(string timeZoneKey)
        {
            TimeZoneInfo timezoneInfo = TimeZoneInfo.FindSystemTimeZoneById(timeZoneKey);
            return timezoneInfo.BaseUtcOffset.TotalHours;
        }

        // Temporary code, need to remove once we have actual source of data
        public static (string lat, string lon) GetLatLang(string basePath, int cdmSiteKey, string state)
        {
            try
            {
                string readText = File.ReadAllText(Path.Combine(basePath, "tempdata.json"));
                JArray array = JArray.Parse(readText);
                var cdmLocations = array.Select(o => new
                {
                    cdmSiteKey = o["cdmSiteKey"].Value<int>(),
                    latitude = o["latitude"].Value<string>(),
                    longitude = o["longitude"].Value<string>(),
                    state = o["state"].Value<string>(),
                }).ToList();

                var one = cdmLocations.Where(o => o.cdmSiteKey == cdmSiteKey).FirstOrDefault();
                if (one == null)
                {
                    one = cdmLocations.Where(o => o.state == state).FirstOrDefault();
                }

                return one != null ? (one.latitude, one.longitude) : ("37.678847", "-105.143989");
            }
            catch
            {
                // for path trace
                return (Path.Combine(basePath, "tempdata.json"), null);
            }
        }

        public static DateTime DateConvert(string date, string year)
        {
            return DateTime.ParseExact(date + "/" + year, "MM/dd/yyyy", CultureInfo.InvariantCulture);
        }
        public static DateTime DateConvert(string fullDate)
        {
            return DateTime.ParseExact(fullDate, "MM/dd/yyyy", CultureInfo.InvariantCulture);
        }

        public static int FahrenheitToCelsius(int fahrenheit)
        {
            var celsius = Convert.ToDecimal((fahrenheit - 32) * 5) / 9;
            return Convert.ToInt32(Math.Round(celsius));
        }

        public static IDictionary<string, string> ShiftDays = new Dictionary<string, string>{
            {"Monday","M"},
            {"Tuesday","Tu"},
            {"Wednesday","W"},
            {"Thursday","Th"},
            {"Friday","F"},
            {"Saturday","Sa"},
            {"Sunday","Su"},
        };

        public static IEnumerable<T> GetRequestCategories<T>(IEnumerable<string> features)
        {
            var programCategories = new List<T>();
            if (features != null && features.Any())
            {
                foreach (var category in features)
                {
                    programCategories.Add(ParseEnum<T>(category));
                }
            }

            return programCategories;

        }

        public static (bool, T) TryParseComponent<T>(string component) where T : struct
        {
            T enumValue;
            bool isComponentExist = Enum.TryParse(component, out enumValue);
            return (isComponentExist, enumValue);
        }
    }
}