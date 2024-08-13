using InfluencerManagerApp.Models.Contracts;
using InfluencerManagerApp.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfluencerManagerApp.Repositories
{
    public class CampaignRepository : IRepository<ICampaign>
    {
        public IReadOnlyCollection<ICampaign> Models => throw new NotImplementedException();

        public void AddModel(ICampaign model)
        {
            throw new NotImplementedException();
        }

        public ICampaign FindByName(string name)
        {
            throw new NotImplementedException();
        }

        public bool RemoveModel(ICampaign model)
        {
            throw new NotImplementedException();
        }
    }
}
