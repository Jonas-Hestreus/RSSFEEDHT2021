using System.Collections.Generic;
using System.Threading.Tasks;
using Models;

namespace DAL.Repositories
{
    public interface IFeedRepositroy<T> : IRepository<T> where T : Feed
    {
        Task <List<Episode>> getEpisodes(string url);
        int GetIndexOfCategory(string name);
    }
}
