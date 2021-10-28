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
using Microsoft.VisualBasic;


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
            FillDataGrid();
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
            string name = nameTxt.Text;
            string url = urlTXT.Text;
            // string frq = FreqCombo.GetItemText(FreqCombo.SelectedItem);
            string frq = "10";
            string category = CategoryCombo.GetItemText(CategoryCombo.SelectedItem);
            feedController.Createfeed(name, url, frq, category);
            FillDataGrid();

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

        private void FillDataGrid()
        {
            dataGridView1.Rows.Clear();
            List<Feed> allFeeds = feedController.getAllFeeds();
            foreach (var feed in allFeeds)
            {
                string[] rowOfFeeds = { feed.Episodes.Count.ToString(), feed.Name, feed.Freq, feed.Category };
                dataGridView1.Rows.Add(rowOfFeeds);
            }


        }
        private void FillEpisodeList(string url)
        {
            episodeBox.Items.Clear();
            List<Episode> episodes = feedController.getEpisodes(url);
            
            foreach (var epuisode in episodes)
            {
                episodeBox.Items.Add(epuisode.Name);
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
        
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                DataGridViewRow selctedrow = dataGridView1.Rows[index];
                string feedName = selctedrow.Cells[1].Value.ToString();
                FillEpisodeList(feedName);
            }
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
            {
                int index = e.RowIndex;
                if (index >= 0)
                {
                    DataGridViewRow selctedrow = dataGridView1.Rows[index];
                    string feedName = selctedrow.Cells[1].Value.ToString();
                    FillEpisodeList(feedName);
                }
            }
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

        private void Podcasts_Load_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dataGridView1.CurrentCell.RowIndex;
                DataGridViewRow selctedrow = dataGridView1.Rows[index];
                string feedName = selctedrow.Cells[1].Value.ToString();
                feedController.deleteFeed(feedName);
                FillDataGrid();
            }

            catch (Exception)
            {
                Console.WriteLine("error");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            DataGridViewRow selctedrow = dataGridView1.Rows[index];
            string name = selctedrow.Cells[1].Value.ToString();
            string frq = selctedrow.Cells[2].Value.ToString();
            string category = selctedrow.Cells[3].Value.ToString();
            Form form1 = new Form1(name, frq, category);
            form1.Show();
        }
    }
}
