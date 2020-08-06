using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Accelerated_Digital_Delivery_Coaching_Program.Models
{
    public class ProductBacklog
    {
        public Guid ProductBacklogID { get; set; }

        [DisplayName("Product Backlog Name")]
        public string ProductBacklogName { get; set; }

        [DisplayName("Product Definition Of Done")]
        public string ProductDefintionOfDone { get; set; }

        public ICollection<ProductBacklogItem> ProductBacklogItems { get; set; }

    }
}
