using Models;
using System.Collections.Generic;
using DAL.Exceptions;
using System;

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
            try
            {
                allCa = dataManager.DerializeFiles();
            }
            catch (SerializerException)
            {
                Console.Write("Could not deserialize category.xml");
            }
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
