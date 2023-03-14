// MainForm.Designer.cs
namespace ProductLog.Views
{
partial class MainForm
{
private System.ComponentModel.IContainer components = null;
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        this.dgvProducts = new System.Windows.Forms.DataGridView();
        this.btnAddProduct = new System.Windows.Forms.Button();
        this.btnSearchProduct = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
        this.SuspendLayout();
        // 
        // dgvProducts
        // 
        this.dgvProducts.AllowUserToAddRows = false;
        this.dgvProducts.AllowUserToDeleteRows = false;
        this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvProducts.Location = new System.Drawing.Point(12, 63);
        this.dgvProducts.Name = "dgvProducts";
        this.dgvProducts.ReadOnly = true;
        this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.dgvProducts.Size = new System.Drawing.Size(560, 295);
        this.dgvProducts.TabIndex = 0;
        // 
        // btnAddProduct
        // 
        this.btnAddProduct.Location = new System.Drawing.Point(12, 12);
        this.btnAddProduct.Name = "btnAddProduct";
        this.btnAddProduct.Size = new System.Drawing.Size(130, 45);
        this.btnAddProduct.TabIndex = 1;
        this.btnAddProduct.Text = "Add Product";
        this.btnAddProduct.UseVisualStyleBackColor = true;
        this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
        // 
        // btnSearchProduct
        // 
        this.btnSearchProduct.Location = new System.Drawing.Point(148, 12);
        this.btnSearchProduct.Name = "btnSearchProduct";
        this.btnSearchProduct.Size = new System.Drawing.Size(130, 45);
        this.btnSearchProduct.TabIndex = 2;
        this.btnSearchProduct.Text = "Search Product";
        this.btnSearchProduct.UseVisualStyleBackColor = true;
        this.btnSearchProduct.Click += new System.EventHandler(this.btnSearchProduct_Click);
        // 
        // MainForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(584, 370);
        this.Controls.Add(this.btnSearchProduct);
        this.Controls.Add(this.btnAddProduct);
        this.Controls.Add(this.dgvProducts);
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.Name = "MainForm";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Product Log";
        ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
        this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView dgvProducts;
    private System.Windows.Forms.Button btnAddProduct;
    private System.Windows.Forms.Button btnSearchProduct;
}
}