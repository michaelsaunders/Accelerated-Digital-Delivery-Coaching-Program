using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Accelerated_Digital_Delivery_Coaching_Program.Models
{
    public class OKR
    {
        [Key]
        public Guid OkrID { get; set; }

        public string Objective { get; set; }

        public string Measure1 { get; set; }
        public string Measure2 { get; set; }

        public string Measure3 { get; set; }

        public string Measure4 { get; set; }

        public string Measure5 { get; set; }

        public long MetricMeasure1 { get; set; }

        public long MetricMeasure2 { get; set; }

        public long MetricMeasure3 { get; set; }

        public long MetricMeasure4 { get; set; }

        public long MetricMeasure5 { get; set; }

        public int ConfidenceScoreMeasure1 { get; set; }
        public int ConfidenceScoreMeasure2 { get; set; }

        public int ConfidenceScoreMeasure3 { get; set; }

        public int ConfidenceScoreMeasure4 { get; set; }

        public int ConfidenceScoreMeasure5 { get; set; }
    }
}
