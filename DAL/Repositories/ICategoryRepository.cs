using DAL.Repositories;
using Models;

namespace DAL
{
    public interface ICategoryRepository<T> : IRepository<T> where T : Category
    {

    }
}
