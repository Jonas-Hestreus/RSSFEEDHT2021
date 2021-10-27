using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using BL.Controllers;
using Models;

namespace PL
{
    public partial class Podcasts : Form
    {
        FeedController feedController;
        CategoryController categoryController;
       
        public Podcasts()
        {
            feedController = new FeedController();
            categoryController = new CategoryController();
            InitializeComponent();
            fillCategory();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void FreqCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void ctgNewBTN_Click(object sender, EventArgs e)
        {
            string categoryToDelete = categoryBox.GetItemText(categoryBox.SelectedItem);
            categoryController.deleteCategory(categoryToDelete);
            fillCategory();
            Filltest();
            fillCategory();
            

        }

        private void categoryBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void CategoryCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void newBTN_Click(object sender, EventArgs e)
        {

        }

        private void saveBTN_Click(object sender, EventArgs e)
        {
            string url = urlTXT.Text;
            // string frq = FreqCombo.GetItemText(FreqCombo.SelectedItem);
            string frq = "10";
            string category = CategoryCombo.GetItemText(CategoryCombo.SelectedItem);
            string name = "First feed";
            feedController.Createfeed(name, url, frq, category);
            Filltest();

           


        }

        private void Filltest()
        {
            episodeBox.Items.Clear();
            List<Feed> feedlist = feedController.getAllFeeds();
            foreach (var item in feedlist)
            {
                episodeBox.Items.Add(item.Url);
            }
        }
        private void fillCategory()
        {
            categoryBox.Items.Clear();
            CategoryCombo.Items.Clear();
            List<Category> categoryList = categoryController.GetAllCategory();

            foreach (var item in categoryList)
            {

                    categoryBox.Items.Add(item.CategoryName);
                    CategoryCombo.Items.Add(item.CategoryName);
            }
        }

        private void ctgDeleteBTN_Click(object sender, EventArgs e)
        {
         
        }

        private void ctgDeleteBTN_Click_1(object sender, EventArgs e)
        {
            string categoryToDelete = categoryBox.GetItemText(categoryBox.SelectedItem);
            categoryController.deleteCategory(categoryToDelete);
            feedController.deleteFeedasedOnCategory(categoryToDelete);
            fillCategory();
            Filltest();
            // NYTT AAAAAA
        }

        private void NameLBL_Click(object sender, EventArgs e)
        {

        }

        private void Podcasts_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ctgSaveBTN_Click(object sender, EventArgs e)
        {
            Boolean match = false; 
            List<Category> allCategory = categoryController.GetAllCategory(); 
               foreach (var category in allCategory)
            {
                if (category.CategoryName.Equals(ctgSaveTxt.Text))
                {
                     match = true;
                     break;
                }
            }
            if (match)
            {
                MessageBox.Show("Du har redan en kategori med namnet : " + ctgSaveTxt.Text);
                var errorCG = new Form();
            }
            else
            {
                categoryController.createCategory(ctgSaveTxt.Text);
                fillCategory();
            }
                
        }
    }
}
