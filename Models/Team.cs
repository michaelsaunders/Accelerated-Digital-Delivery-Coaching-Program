using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;

namespace Accelerated_Digital_Delivery_Coaching_Program.Models
{
    public class Team
    {
        [Key]
        public long TeamID { get; set; }

        [DisplayName("Team Name")]
        public string TeamName { get; set; }

        [DisplayName("Yesterdays Weather")]
        public int YesterdaysWeather { get; set; }

        [DisplayName("When was the last yesterdays weather update")]
        public DateTime LastYesterdaysWeatherUpdate { get; set; }

        public Person TeamLead { get; set; }

        public Person TeamCoach { get; set; }

        public Pattern Pattern { get; set; }

    }
}
