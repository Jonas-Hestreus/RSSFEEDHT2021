using System;
using System.Collections.Generic;
using System.Text;


namespace DAL.Repositories
{
    public interface IRepository<T> where T : class
    {
        void Create(T media);
        void Delete(int i);
        void Update(int i, T newMedia);
        List<T> GetAll();
        void SaveChanges();
        int GetIndexOfName(string name);
    }
}
