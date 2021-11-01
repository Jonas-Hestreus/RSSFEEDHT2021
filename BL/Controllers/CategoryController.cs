using System;
using System.Collections.Generic;
using DAL;
using Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BL.Controllers
{


    public class CategoryController
    {
        Validering validator;
        ICategoryRepository<Category> categoryRepository;

        public CategoryController()
        {
            categoryRepository = new CategoryRepository();
            validator = new Validering();

        }
        public void createCategory(string name)
        {
            if (validator.TextEmpty(name))
            {
                Category newCategory = new Category(name);
                categoryRepository.Create(newCategory);
            }
            else
            {
                MessageBox.Show("Du´måste ge din categori ett namn");
            }

        }
        public List<Category> GetAllCategory()
        {
            return categoryRepository.GetAll();
        }
        public bool deleteCategory(string category)
        {
            bool delete = false;
            if (validator.TextEmpty(category))
            {
                DialogResult dialogResult = MessageBox.Show("Vill du ta bort podcasten " + category + "?", "Bekräfta", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int i = categoryRepository.GetIndexOfName(category);
                    categoryRepository.Delete(i);
                    MessageBox.Show(category + " har blivit raderad");
                     delete = true;
                }
            }
            else
            {
                Console.WriteLine("No category");
            }
            return delete;
        }

        public void updatCategory(int index, string newCategoryName)
        {
            Category updatedCat = new Category(newCategoryName);
            categoryRepository.Update(index, updatedCat);
        }
        public int getIndex(string name)
        {
            return categoryRepository.GetIndexOfName(name);
        }


        public Boolean uniqueCategory(string categoryToCheck)
        {
            Boolean noMatch = true;
            foreach(var category in GetAllCategory())
            {
                if (category.CategoryName.Equals(categoryToCheck))
                {
                    noMatch = false;
                    break;
                }
            }
            return noMatch;
        }
    }
}
