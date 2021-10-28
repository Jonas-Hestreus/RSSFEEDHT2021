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
    public partial class Form1 : Form
    {
        string FeedName;
        string Frq;
        string Category;
        CategoryController cController;
        FeedController feedController;
        public Form1(string feedName, string frq, string category)
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
        }



    }
}
