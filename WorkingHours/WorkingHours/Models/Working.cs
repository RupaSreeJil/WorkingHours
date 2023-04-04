using Microsoft.EntityFrameworkCore;

namespace WorkingHours.Models
{
    public class Working
    {
        private DbContextOptions<Working> options;

        public Working(DbContextOptions<Working> options)
        {
            this.options = options;
        }

        public int HoursWorked { get; set; }
        public int RegularHours { get; set; }
        public int OvertimeWorkingHrs { get; set; }
    }
}
