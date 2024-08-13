using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfluencerManagerApp.Models
{
    internal class ProductCampaign : Campaign
    {
        private const double PCBudget = 60_000;
        public ProductCampaign(string brand) 
            : base(brand, PCBudget)
        {
        }
    }
}
