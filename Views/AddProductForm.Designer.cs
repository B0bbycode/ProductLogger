namespace ProductLogger.Views
{
    partial class AddProductForm
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

        private void InitializeComponent()
        {
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblProductImage = new System.Windows.Forms.Label();
            this.btnChooseImage = new System.Windows.Forms.Button();
            this.lblProductSKU = new System.Windows.Forms.Label();
            this.txtProductSKU = new System.Windows.Forms.TextBox();
            this.lblProductDescription = new System.Windows.Forms.Label();
            this.txtProductDescription = new System.Windows.Forms.TextBox();
            this.lblProductUnit = new System.Windows.Forms.Label();
            this.txtProductUnit = new System.Windows.Forms.TextBox();
            this.btnSaveProduct = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(12, 20);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(75, 13);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Product Name";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(12, 36);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(260, 20);
            this.txtProductName.TabIndex = 1;
            // 
            // lblProductImage
            // 
            this.lblProductImage.AutoSize = true;
            this.lblProductImage.Location = new System.Drawing.Point(12, 70);
            this.lblProductImage.Name = "lblProductImage";
            this.lblProductImage.Size = new System.Drawing.Size(75, 13);
            this.lblProductImage.TabIndex = 2;
            this.lblProductImage.Text = "Product Image";
            // 
            // btnChooseImage
            // 
            this.btnChooseImage.Location = new System.Drawing.Point(12, 86);
            this.btnChooseImage.Name = "btnChooseImage";
            this.btnChooseImage.Size = new System.Drawing.Size(75, 23);
            this.btnChooseImage.TabIndex = 3;
            this.btnChooseImage.Text = "Choose...";
            this.btnChooseImage.UseVisualStyleBackColor = true;
            this.btnChooseImage.Click += new System.EventHandler(this.BtnChooseImage_Click);
            // 
            // lblProductSKU
            // 
            this.lblProductSKU.AutoSize = true;
            this.lblProductSKU.Location = new System.Drawing.Point(12, 130);
            this.lblProductSKU.Name = "lblProductSKU";
            this.lblProductSKU.Size = new System.Drawing.Size(70, 13);
            this.lblProductSKU.TabIndex = 4;
            this.lblProductSKU.Text = "Product SKU";
            // 
            // txtProductSKU
            // 
            this.txtProductSKU.Location = new System.Drawing.Point(12, 146);
            this.txtProductSKU.Name = "txtProductSKU";
            this.txtProductSKU.Size = new System.Drawing.Size(260, 20);
            this.txtProductSKU.TabIndex = 5;
            // 
            // lblProductDescription
            // 
            this.lblProductDescription.AutoSize = true;
            this.lblProductDescription.Location = new System.Drawing.Point(12, 190);
            this.lblProductDescription.Name = "lblProductDescription";
            this.lblProductDescription.Size = new System.Drawing.Size(106, 13);
            this.lblProductDescription.TabIndex = 6;
            this.lblProductDescription.Text = "Product Description";
            //
            // txtProductDescription
            //
            this.txtProductDescription.Location = new System.Drawing.Point(12, 206);
            this.txtProductDescription.Multiline = true;
            this.txtProductDescription.Name = "txtProductDescription";
            this.txtProductDescription.Size = new System.Drawing.Size(260, 60);
            this.txtProductDescription.TabIndex = 7;
            //
            // lblProductUnit
            //
            this.lblProductUnit.AutoSize = true;
            this.lblProductUnit.Location = new System.Drawing.Point(12, 284);
            this.lblProductUnit.Name = "lblProductUnit";
            this.lblProductUnit.Size = new System.Drawing.Size(68, 13);
            this.lblProductUnit.TabIndex = 8;
            this.lblProductUnit.Text = "Product Unit";
            //
            // txtProductUnit
            //
            this.txtProductUnit.Location = new System.Drawing.Point(12, 300);
            this.txtProductUnit.Name = "txtProductUnit";
            this.txtProductUnit.Size = new System.Drawing.Size(260, 20);
            this.txtProductUnit.TabIndex = 9;
            //
            // btnSaveProduct
            //
            this.btnSaveProduct.Location = new System.Drawing.Point(116, 342);
            this.btnSaveProduct.Name = "btnSaveProduct";
            this.btnSaveProduct.Size = new System.Drawing.Size(75, 23);
            this.btnSaveProduct.TabIndex = 10;
            this.btnSaveProduct.Text = "Save";
            this.btnSaveProduct.UseVisualStyleBackColor = true;
            this.btnSaveProduct.Click += new System.EventHandler(this.BtnSaveProduct_Click);
            //
            // btnCancel
            //
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(197, 342);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            //
            // pictureBox
            //
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(93, 70);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(179, 107);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 12;
            this.pictureBox.TabStop = false;
            //
            // AddProductForm
            //
            this.AcceptButton = this.btnSaveProduct;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(284, 377);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveProduct);
            this.Controls.Add(this.txtProductUnit);
            this.Controls.Add(this.lblProductUnit);
            this.Controls.Add(this.txtProductDescription);
            this.Controls.Add(this.lblProductDescription);
            this.Controls.Add(this.txtProductSKU);
            this.Controls.Add(this.lblProductSKU);
            this.Controls.Add(this.btnChooseImage);
            this.Controls.Add(this.lblProductImage);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.lblProductName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Product";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
                }

    #region  Windows Form Designer generated code

    private System.Windows.Forms.Label lblProductName;
    private System.Windows.Forms.TextBox txtProductName;
    private System.Windows.Forms.Label lblProductImage;
    private System.Windows.Forms.Button btnChooseImage;
    private System.Windows.Forms.Label lblProductSKU;
    private System.Windows.Forms.TextBox txtProductSKU;
    private System.Windows.Forms.Label lblProductDescription;
    private System.Windows.Forms.TextBox txtProductDescription;
    private System.Windows.Forms.Label lblProductUnit;
    private System.Windows.Forms.TextBox txtProductUnit;
    private System.Windows.Forms.Button btnSaveProduct;
    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.PictureBox pictureBox;
}
}