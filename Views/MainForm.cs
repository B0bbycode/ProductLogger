using System;
using System.Windows.Forms;
using ProductLogger.Views;

namespace ProductLogger
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            // open the AddProductForm as a modal dialog
            var addProductForm = new AddProductForm();
            addProductForm.ShowDialog();
        }

        private void BtnSearchProduct_Click(object sender, EventArgs e)
        {
            // open the SearchForm as a modal dialog
            var searchForm = new SearchForm();
            searchForm.ShowDialog();
        }
    }
}
