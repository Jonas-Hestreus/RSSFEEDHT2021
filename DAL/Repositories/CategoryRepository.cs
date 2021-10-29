using Models;
using System.Collections.Generic;


namespace DAL.Repositories
{
    public class CategoryRepository : ICategoryRepository<Category>

    {
        DatamanagerCategory dataManager;
        List<Category> listOfCategory;
        public CategoryRepository()
        {
            listOfCategory = new List<Category>();
            dataManager = new DatamanagerCategory();
            listOfCategory = GetAll();
        }

        public List<Category> GetAll()
        {
            List<Category> allCa = new List<Category>();
            allCa = dataManager.DerializeFiles();
            return allCa;
        }

        public void Create(Category newCategory)
        {
            listOfCategory.Add(newCategory);
            SaveChanges();

        }
        public void Delete(int i)
        {
            listOfCategory.RemoveAt(i);
            SaveChanges();
        }

        public void SaveChanges()
        {
            dataManager.SerializeFiles(listOfCategory);

        }
        public int GetIndexOfName(string categoryName)
        {
            return GetAll().FindIndex(e => e.CategoryName.Equals(categoryName));

        }
        public void Update(int i, Category updatedCategory)
        {
            if (i >= 0)
            {
                listOfCategory[i] = updatedCategory;
                SaveChanges();
            }
        }
    }
}
