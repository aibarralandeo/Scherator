using System;

namespace Scherator.Models.Domain
{
    public class DailySchedule
    {
        public string Day { get; set; }
        public TimeSpan Time { get; set; }
        public TimeSpan StartHour { get; set; }
        public TimeSpan EndHour { get; set; }
    }
}
