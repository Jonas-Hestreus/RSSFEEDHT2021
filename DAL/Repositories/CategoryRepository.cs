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
            Category dummyCate = new Category("DummyText");
            Create(dummyCate);

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
            int i = 0;
            foreach (var category in listOfCategory)
                
            {
                if (categoryName.Equals(category.CategoryName))
                {
                    break;
                }
                i++;
            }
            return i;
        }
        public void Update(int i, Category updatedCategory)
        {
            listOfCategory[i] = updatedCategory;
            SaveChanges();
        }
    }
}
