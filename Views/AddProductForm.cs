using System;
using System.Windows.Forms;
using ProductLogger.Controllers;
using ProductLogger.Models;

namespace ProductLogger.Views
{
    public partial class AddProductForm : Form
    {
        private readonly ProductController _productController;

        public AddProductForm()
        {
            InitializeComponent();

            _productController = new ProductController();
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {
            // initialize any necessary form elements here
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // create a new Product object with the data from the form
            var product = new Product
            {
                Name = txtName.Text,
                ImagePath = txtImagePath.Text,
                SKU = txtSku.Text,
                Description = txtDescription.Text,
                Unit = txtUnit.Text
            };

            // add the product to the database
            var result = _productController.AddProduct(product);

            if (result)
            {
                // show a success message
                MessageBox.Show("Product added successfully.");

                // clear the form fields
                txtName.Text = "";
                txtImagePath.Text = "";
                txtSku.Text = "";
                txtDescription.Text = "";
                txtUnit.Text = "";
            }
            else
            {
                // show an error message
                MessageBox.Show("Error adding product.");
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            // close the form
            Close();
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            // open a file dialog to select an image file
            var openFileDialog = new OpenFileDialog
            {
                Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // set the image path text box to the selected file path
                txtImagePath.Text = openFileDialog.FileName;
            }
        }
    }
}
