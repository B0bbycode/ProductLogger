using System;
using System.Windows.Forms;
using ProductLogger.Controllers;
using ProductLogger.Models;

namespace ProductLogger.Views
{
    public partial class SearchForm : Form
    {
        private readonly ProductController _productController;

        public SearchForm()
        {
            InitializeComponent();

            _productController = new ProductController();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            // initialize any necessary form elements here
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            // get the search keyword from the text box
            var keyword = txtKeyword.Text;

            // search for products with the given keyword
            var products = _productController.SearchProducts(keyword);

            // clear the data grid view
            dataGridView.Rows.Clear();

            // add the search results to the data grid view
            foreach (var product in products)
            {
                dataGridView.Rows.Add(product.Name, product.ImagePath, product.SKU, product.Description, product.Unit);
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            // clear the text box and the data grid view
            txtKeyword.Text = "";
            dataGridView.Rows.Clear();
        }
    }
}
