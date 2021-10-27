using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL.Repositories
{
    public interface IFeedRepositroy<T> : IRepository<T> where T : Feed
    {
        List<Episode> getEpisodes(string url);
        int GetIndexOfCategory(string name);
    }

}
