using InfluencerManagerApp.Models.Contracts;
using InfluencerManagerApp.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfluencerManagerApp.Repositories
{
    public class InfluencerRepository : IRepository<IInfluencer>
    {
        public IReadOnlyCollection<IInfluencer> Models => throw new NotImplementedException();

        public void AddModel(IInfluencer model)
        {
            throw new NotImplementedException();
        }

        public IInfluencer FindByName(string name)
        {
            throw new NotImplementedException();
        }

        public bool RemoveModel(IInfluencer model)
        {
            throw new NotImplementedException();
        }
    }
}
