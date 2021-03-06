using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL.Controllers;
using Models;

namespace PL
{
    public partial class updFeed : Form
    {
        string FeedName;
        string Frq;
        string Category;
        CategoryController cController;
        FeedController feedController;
        public updFeed(string feedName, string frq, string category)
        {
            feedController = new FeedController();
            cController = new CategoryController();
            FeedName = feedName;
            Frq = frq;
            Category = category;
            InitializeComponent();
            fillCategory();
            fillInputs();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = feedController.getIndexByNam(FeedName);
            string url = feedController.getAllFeeds()[index].Url;
            string frq = frqCombo.SelectedItem.ToString();
            string category = CategoryCombo.SelectedItem.ToString();
            string name = nameBox.Text;
            DateTime nextUpdate = DateTime.Now;
            feedController.updateFeed(name, url, frq, category, nextUpdate, index);
            MessageBox.Show("Din podcast är updaterad");
            this.Close();
        }

        private void fillCategory()
        {
            CategoryCombo.Items.Clear();
            List<Category> categoryList = cController.GetAllCategory();
            foreach (var item in categoryList)
            {
                CategoryCombo.Items.Add(item.CategoryName);
            }
            
        }
        private void fillInputs()
        {
            nameBox.Text = FeedName;
            CategoryCombo.SelectedIndex = CategoryCombo.FindString(Category);
            frqCombo.SelectedIndex = frqCombo.FindString(Frq);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
