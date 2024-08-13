using InfluencerManagerApp.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfluencerManagerApp.Models
{
    public abstract class Influencer : IInfluencer
    {

        public Influencer(string username, int followers, double engagementRate)
        {
                
        }
        public string Username => throw new NotImplementedException();

        public int Followers => throw new NotImplementedException();

        public double EngagementRate => throw new NotImplementedException();

        public double Income => throw new NotImplementedException();

        public IReadOnlyCollection<string> Participations => throw new NotImplementedException();

        public int CalculateCampaignPrice()
        {
            throw new NotImplementedException();
        }

        public void EarnFee(double amount)
        {
            throw new NotImplementedException();
        }

        public void EndParticipation(string brand)
        {
            throw new NotImplementedException();
        }

        public void EnrollCampaign(string brand)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"{Username} - Followers: {Followers}, Total Income: {Income}";
        }
    }
}
