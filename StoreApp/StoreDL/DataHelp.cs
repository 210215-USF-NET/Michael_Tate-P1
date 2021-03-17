using StoreModels;
using System;
using System.Collections.Generic;

namespace StoreDL
{
    public class DataHelp
    {
        public static List<string> HumanizeWorkHours(IEnumerable<BranchHours> branchHours)
        {
            var hours = new List<string>();

            foreach (var time in branchHours)
            {
                var day = HumanizeDay(time.DayOfWeek);
                var openTime = HumanizeDay(time.OpenTime);
                var closeTime = HumanizeDay(time.CloseTime);

                var timeEntry = $"{day} {openTime} - {closeTime}";

                hours.Add(timeEntry);
            }

            return hours;
        }

        public static string HumanizeDay(int number)
        {
            return Enum.GetName(typeof(DayOfWeek), number - 1);
        }

        public static string HumanizeTime(int time)
        {
            return TimeSpan.FromHours(time).ToString("hh':'mm");
        }
    }
}