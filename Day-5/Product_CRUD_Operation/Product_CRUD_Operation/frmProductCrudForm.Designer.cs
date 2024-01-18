namespace Product_CRUD_Operation
{
    partial class frmProductCrudForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.txtProductCompany = new System.Windows.Forms.TextBox();
            this.txtProductRating = new System.Windows.Forms.TextBox();
            this.btn_MoveFirst = new System.Windows.Forms.Button();
            this.btn_MovePervious = new System.Windows.Forms.Button();
            this.btn_MoveNext = new System.Windows.Forms.Button();
            this.btn_MoveLast = new System.Windows.Forms.Button();
            this.btn_NewProduct = new System.Windows.Forms.Button();
            this.btn_SaveProduct = new System.Windows.Forms.Button();
            this.btn_UpdateProduct = new System.Windows.Forms.Button();
            this.btn_ProductDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(573, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product CRUD Operation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(157, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "ProductID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(157, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "ProductName";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(157, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "ProductPrice";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(157, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "ProductCompany";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(157, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "ProductRating";
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(355, 111);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(266, 22);
            this.txtProductID.TabIndex = 8;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(355, 152);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(266, 22);
            this.txtProductName.TabIndex = 9;
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(355, 196);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(266, 22);
            this.txtProductPrice.TabIndex = 10;
            // 
            // txtProductCompany
            // 
            this.txtProductCompany.Location = new System.Drawing.Point(355, 242);
            this.txtProductCompany.Name = "txtProductCompany";
            this.txtProductCompany.Size = new System.Drawing.Size(266, 22);
            this.txtProductCompany.TabIndex = 11;
            // 
            // txtProductRating
            // 
            this.txtProductRating.Location = new System.Drawing.Point(355, 282);
            this.txtProductRating.Name = "txtProductRating";
            this.txtProductRating.Size = new System.Drawing.Size(266, 22);
            this.txtProductRating.TabIndex = 12;
            // 
            // btn_MoveFirst
            // 
            this.btn_MoveFirst.Location = new System.Drawing.Point(100, 335);
            this.btn_MoveFirst.Name = "btn_MoveFirst";
            this.btn_MoveFirst.Size = new System.Drawing.Size(131, 41);
            this.btn_MoveFirst.TabIndex = 13;
            this.btn_MoveFirst.Text = "<<";
            this.btn_MoveFirst.UseVisualStyleBackColor = true;
            this.btn_MoveFirst.Click += new System.EventHandler(this.btn_MoveFirst_Click);
            // 
            // btn_MovePervious
            // 
            this.btn_MovePervious.Location = new System.Drawing.Point(261, 335);
            this.btn_MovePervious.Name = "btn_MovePervious";
            this.btn_MovePervious.Size = new System.Drawing.Size(131, 41);
            this.btn_MovePervious.TabIndex = 14;
            this.btn_MovePervious.Text = "<";
            this.btn_MovePervious.UseVisualStyleBackColor = true;
            this.btn_MovePervious.Click += new System.EventHandler(this.btn_MovePervious_Click);
            // 
            // btn_MoveNext
            // 
            this.btn_MoveNext.Location = new System.Drawing.Point(420, 335);
            this.btn_MoveNext.Name = "btn_MoveNext";
            this.btn_MoveNext.Size = new System.Drawing.Size(131, 41);
            this.btn_MoveNext.TabIndex = 15;
            this.btn_MoveNext.Text = ">";
            this.btn_MoveNext.UseVisualStyleBackColor = true;
            this.btn_MoveNext.Click += new System.EventHandler(this.btn_MoveNext_Click);
            // 
            // btn_MoveLast
            // 
            this.btn_MoveLast.Location = new System.Drawing.Point(570, 335);
            this.btn_MoveLast.Name = "btn_MoveLast";
            this.btn_MoveLast.Size = new System.Drawing.Size(131, 41);
            this.btn_MoveLast.TabIndex = 16;
            this.btn_MoveLast.Text = ">>";
            this.btn_MoveLast.UseVisualStyleBackColor = true;
            this.btn_MoveLast.Click += new System.EventHandler(this.btn_MoveLast_Click);
            // 
            // btn_NewProduct
            // 
            this.btn_NewProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NewProduct.Location = new System.Drawing.Point(100, 397);
            this.btn_NewProduct.Name = "btn_NewProduct";
            this.btn_NewProduct.Size = new System.Drawing.Size(131, 41);
            this.btn_NewProduct.TabIndex = 17;
            this.btn_NewProduct.Text = "NEW";
            this.btn_NewProduct.UseVisualStyleBackColor = true;
            this.btn_NewProduct.Click += new System.EventHandler(this.btn_NewProduct_Click);
            // 
            // btn_SaveProduct
            // 
            this.btn_SaveProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaveProduct.Location = new System.Drawing.Point(261, 397);
            this.btn_SaveProduct.Name = "btn_SaveProduct";
            this.btn_SaveProduct.Size = new System.Drawing.Size(131, 41);
            this.btn_SaveProduct.TabIndex = 18;
            this.btn_SaveProduct.Text = "SAVE";
            this.btn_SaveProduct.UseVisualStyleBackColor = true;
            this.btn_SaveProduct.Click += new System.EventHandler(this.btn_SaveProduct_Click);
            // 
            // btn_UpdateProduct
            // 
            this.btn_UpdateProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UpdateProduct.Location = new System.Drawing.Point(420, 397);
            this.btn_UpdateProduct.Name = "btn_UpdateProduct";
            this.btn_UpdateProduct.Size = new System.Drawing.Size(131, 41);
            this.btn_UpdateProduct.TabIndex = 19;
            this.btn_UpdateProduct.Text = "UPDATE";
            this.btn_UpdateProduct.UseVisualStyleBackColor = true;
            this.btn_UpdateProduct.Click += new System.EventHandler(this.btn_UpdateProduct_Click);
            // 
            // btn_ProductDelete
            // 
            this.btn_ProductDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ProductDelete.Location = new System.Drawing.Point(570, 397);
            this.btn_ProductDelete.Name = "btn_ProductDelete";
            this.btn_ProductDelete.Size = new System.Drawing.Size(131, 41);
            this.btn_ProductDelete.TabIndex = 20;
            this.btn_ProductDelete.Text = "DELETE";
            this.btn_ProductDelete.UseVisualStyleBackColor = true;
            this.btn_ProductDelete.Click += new System.EventHandler(this.btn_ProductDelete_Click);
            // 
            // frmProductCrudForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_ProductDelete);
            this.Controls.Add(this.btn_UpdateProduct);
            this.Controls.Add(this.btn_SaveProduct);
            this.Controls.Add(this.btn_NewProduct);
            this.Controls.Add(this.btn_MoveLast);
            this.Controls.Add(this.btn_MoveNext);
            this.Controls.Add(this.btn_MovePervious);
            this.Controls.Add(this.btn_MoveFirst);
            this.Controls.Add(this.txtProductRating);
            this.Controls.Add(this.txtProductCompany);
            this.Controls.Add(this.txtProductPrice);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmProductCrudForm";
            this.Text = "frmProductCrudForm";
            this.Load += new System.EventHandler(this.frmProductCrudForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.TextBox txtProductCompany;
        private System.Windows.Forms.TextBox txtProductRating;
        private System.Windows.Forms.Button btn_MoveFirst;
        private System.Windows.Forms.Button btn_MovePervious;
        private System.Windows.Forms.Button btn_MoveNext;
        private System.Windows.Forms.Button btn_MoveLast;
        private System.Windows.Forms.Button btn_NewProduct;
        private System.Windows.Forms.Button btn_SaveProduct;
        private System.Windows.Forms.Button btn_UpdateProduct;
        private System.Windows.Forms.Button btn_ProductDelete;
    }
}