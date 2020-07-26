using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;

namespace Accelerated_Digital_Delivery_Coaching_Program.Models
{
    public class Team
    {
        public long TeamID { get; set; }

        public string TeamName { get; set; }

        public int YesterdaysWeather { get; set; }

        public DateTime LastYesterdaysWeatherUpdate { get; set; }

        public Person TeamLead { get; set; }

        public Person TeamCoach { get; set; }

    }
}
