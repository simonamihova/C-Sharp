using InfluencerManagerApp.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfluencerManagerApp.Models
{
    public abstract class Campaign : ICampaign
    {

        public Campaign(string brand, double budget)
        {
                
        }
        public string Brand => throw new NotImplementedException();

        public double Budget => throw new NotImplementedException();

        public IReadOnlyCollection<string> Contributors => throw new NotImplementedException();

        public void Engage(IInfluencer influencer)
        {
            throw new NotImplementedException();
        }

        public void Gain(double amount)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"{GetType().Name} - Brand: {Brand}, Budget: {Budget}, Contributors: {Contributors.Count}";
        }
    }
}
