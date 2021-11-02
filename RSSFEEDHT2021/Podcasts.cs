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
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            timer1.Start();
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
            List<Feed> feeds = feedController.getAllFeeds();
            if (categoryController.deleteCategory(categoryToDelete))
            {
                foreach (var item in feeds)
                {
                    if (item.Category.Equals(categoryToDelete))
                    {
                        feedController.deleteFeed(item.Name);
                    }
                }
                fillCategory();
                fillCategory();
                FillDataGrid();
                _ = delay();
            }
        }



        private void categoryBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (categoryBox.SelectedItem != null)
                {
                    upDateBox1.Text = categoryBox.SelectedItem.ToString();
                }
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Null exception");
            }
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
            string frq = FreqCombo.GetItemText(FreqCombo.SelectedItem);
            string category = CategoryCombo.GetItemText(CategoryCombo.SelectedItem);
            DateTime nextUpdate = DateTime.Now;
            feedController.Createfeed(name, url, frq, category, nextUpdate);
            FillDataGrid();
            _ = delay();

        }

        async Task delay()
        {
            await Task.Delay(250);
            FillDataGrid();
        }

        private void sortByCategory(string category)
        {
            dataGridView1.Rows.Clear();
            List<Feed> feeds = feedController.getAllFeeds();

            var feedsQuery = from feed in feeds
                             where feed.Category.Contains(category)
                             select feed.Name;

            foreach (var item in feedsQuery)
            {
                int index = feedController.getIndexByNam(item);
                string[] rowOfFeeds = { feeds[index].Episodes.Count.ToString(), feeds[index].Name, feeds[index].Freq, feeds[index].Category };
                dataGridView1.Rows.Add(rowOfFeeds);
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

        public void FillDataGrid()
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
                episodeBox.Items.Clear();
            }

            catch (Exception)
            {
                Console.WriteLine("error");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dataGridView1.CurrentCell.RowIndex;
                DataGridViewRow selctedrow = dataGridView1.Rows[index];
                string name = selctedrow.Cells[1].Value.ToString();
                string frq = selctedrow.Cells[2].Value.ToString();
                string category = selctedrow.Cells[3].Value.ToString();
                Form form1 = new Form1(name, frq, category);
                form1.Show();
            }
            catch (Exception)
            {
                Console.WriteLine("Nullpoint");
            }
        }
        
        public void updateFeed()
        {
            FillDataGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                sortByCategory(categoryBox.SelectedItem.ToString());
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Nullpoint");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (categoryController.uniqueCategory(upDateBox1.Text))
            {
                string oldCategory = categoryBox.GetItemText(categoryBox.SelectedItem);
                List<Feed> feeds = feedController.getAllFeeds();
                string newCat = upDateBox1.Text;
                foreach (var item in feeds)
                {
                    if (item.Category.Equals(oldCategory))
                    {
                        int i = feedController.getIndexByNam(item.Name);
                        feedController.updateFeed(item.Name, item.Url, item.Freq, newCat, item.NextUpdate, i);
                    }
                }
                int index = categoryController.getIndex(oldCategory);
                categoryController.updatCategory(index, newCat);
                fillCategory();
                fillCategory();
                FillDataGrid();
                _ = delay();
            }
        }

        private void episodeInfoText_Click(object sender, EventArgs e)
        {

        }

        private void episodeDesc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void episodeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string episode = episodeBox.SelectedItem.ToString();
            int index = dataGridView1.CurrentCell.RowIndex;
            if (index >= 0)
            {
                DataGridViewRow selctedrow = dataGridView1.Rows[index];
                string feedName = selctedrow.Cells[1].Value.ToString();
                List<Episode> episodes = feedController.getEpisodes(feedName);
                foreach (var item in episodes)
                {
                    if (episode.Equals(item.Name))
                    {
                        descLBL.Text=item.Description;
                        break;
                    }
                }
            }
        }

    private void updFreqLBL_Click(object sender, EventArgs e)
    {

    }

        private void descLBL_Click(object sender, EventArgs e)
        {
            {
                string episode = episodeBox.SelectedItem.ToString();
                int index = dataGridView1.CurrentCell.RowIndex;
                if (index >= 0)
                {
                    DataGridViewRow selctedrow = dataGridView1.Rows[index];
                    string feedName = selctedrow.Cells[1].Value.ToString();
                    List<Episode> episodes = feedController.getEpisodes(feedName);
                    foreach (var item in episodes)
                    {
                        if (episode.Equals(item.Name))
                        {
                            descLBL.Text=item.Description;
                            break;
                        }
                    }
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private async void timer1_Tick(object sender, EventArgs e)
        {

            Boolean updated = await feedController.UpdateFeedTick();
            if (updated)
            {
                    FillDataGrid();
            }
            
            

        }
    }
}
