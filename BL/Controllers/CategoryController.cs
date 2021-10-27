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
        public void deleteCategory(string category)
        {
            if (validator.TextEmpty(category))
            {
                int i = categoryRepository.GetIndexOfName(category);
                categoryRepository.Delete(i);
            }
            else
            {
                Console.WriteLine("No category");

            }
        }


        public void updatCategory(Category oldCat, string newCategoryName)
        {
            int i = categoryRepository.GetIndexOfName(oldCat.CategoryName);
            Category newCategory = new Category(newCategoryName);
            categoryRepository.Update(i, newCategory);
        }
    }
}
