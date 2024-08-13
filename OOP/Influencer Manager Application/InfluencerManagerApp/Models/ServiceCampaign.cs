﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfluencerManagerApp.Models
{
    internal class ServiceCampaign : Campaign
    {
        private const double SCBudget = 30_000;
        public ServiceCampaign(string brand) 
            : base(brand, SCBudget)
        {
        }
    }
}
