using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfluencerManagerApp.Models
{
    internal class BloggerInfluencer : Influencer
    {
        private const double BlIEngagementRate = 2.0;
        public BloggerInfluencer(string username, int followers) 
            : base(username, followers, BlIEngagementRate)
        {
        }
    }
}
