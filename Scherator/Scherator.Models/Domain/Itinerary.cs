using System.Collections.Generic;

namespace Scherator.Models.Domain
{
    public class Itinerary
    {
        public string CourseName { get; set; }
        public string TeacherName { get; set; }
        public List<DailySchedule> CourseSchedule { get; set; }
    }
}
