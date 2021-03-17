using StoreModels;
using System;
using System.Collections.Generic;

namespace StoreDL
{
    internal class DataHelp
    {
        public static List<string> HumanizeWorkHours(IEnumerable<BranchHours> branchHours)
        {
            var hours = new List<string>();

            foreach (var time in branchHours)
            {
                var day = HumanizeDay(time.DayOfWeek);
                var openTime = HumanizeDay(time.OpenTime);
                var closrTime = HumanizeDay(time.DayOfWeek);

                var timeEntry = $"{day} {openTime} - {closrTime}";

                hours.Add(timeEntry);
            }

            return hours;
        }

        public static string HumanizeDay(int number)
        {
            return Enum.GetName(typeof(DayOfWeek), number);
        }

        public static string HumanizeTime(int time)
        {
            return TimeSpan.FromHours(time).ToString("hh': 'mm");
        }
    }
}