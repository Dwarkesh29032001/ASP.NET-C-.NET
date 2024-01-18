namespace ConnectedArchitectureExample
{
    partial class frmCustomerCrudFrom
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
            this.customerDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtCustomerEmail = new System.Windows.Forms.TextBox();
            this.txtCustomerPhone = new System.Windows.Forms.TextBox();
            this.txtCustomerAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            //this.txtRegdate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnMoveFirst_Click = new System.Windows.Forms.Button();
            this.btnMovePrevious_Click = new System.Windows.Forms.Button();
            this.btnMoveNext_Click = new System.Windows.Forms.Button();
            this.btnMoveLast_Click = new System.Windows.Forms.Button();
            this.btnNew_Click = new System.Windows.Forms.Button();
            this.btnSave_Click = new System.Windows.Forms.Button();
            this.btnUpdate_Click = new System.Windows.Forms.Button();
            this.btnDelete_Click = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // customerDataGridView
            // 
            this.customerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerDataGridView.Location = new System.Drawing.Point(0, 0);
            this.customerDataGridView.Name = "customerDataGridView";
            this.customerDataGridView.RowHeadersWidth = 51;
            this.customerDataGridView.RowTemplate.Height = 24;
            this.customerDataGridView.Size = new System.Drawing.Size(800, 450);
            this.customerDataGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Himalaya", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(233, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Infoway Customer Form";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(315, 64);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(247, 22);
            this.txtCustomerID.TabIndex = 2;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(315, 105);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(247, 22);
            this.txtCustomerName.TabIndex = 3;
            // 
            // txtCustomerEmail
            // 
            this.txtCustomerEmail.Location = new System.Drawing.Point(315, 151);
            this.txtCustomerEmail.Name = "txtCustomerEmail";
            this.txtCustomerEmail.Size = new System.Drawing.Size(247, 22);
            this.txtCustomerEmail.TabIndex = 4;
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.Location = new System.Drawing.Point(315, 192);
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.Size = new System.Drawing.Size(247, 22);
            this.txtCustomerPhone.TabIndex = 5;
            // 
            // txtCustomerAddress
            // 
            this.txtCustomerAddress.Location = new System.Drawing.Point(315, 229);
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.Size = new System.Drawing.Size(247, 22);
            this.txtCustomerAddress.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "customerID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "customerName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "customerEmail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(160, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "customerPhone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(160, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "customerAddress";
            // 
            // txtRegdate
            // 
            /*this.txtRegdate.Location = new System.Drawing.Point(315, 276);
            this.txtRegdate.Name = "txtRegdate";
            this.txtRegdate.Size = new System.Drawing.Size(247, 22);
            this.txtRegdate.TabIndex = 12;*/
            // 
            // label7
            // 
           /* this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(160, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "registrationDate";*/
            // 
            // btnMoveFirst_Click
            // 
            this.btnMoveFirst_Click.Location = new System.Drawing.Point(163, 336);
            this.btnMoveFirst_Click.Name = "btnMoveFirst_Click";
            this.btnMoveFirst_Click.Size = new System.Drawing.Size(75, 23);
            this.btnMoveFirst_Click.TabIndex = 14;
            this.btnMoveFirst_Click.Text = "<<";
            this.btnMoveFirst_Click.UseVisualStyleBackColor = true;
            this.btnMoveFirst_Click.Click += new System.EventHandler(this.btnMoveFirst_Click_Click);
            // 
            // btnMovePrevious_Click
            // 
            this.btnMovePrevious_Click.Location = new System.Drawing.Point(279, 336);
            this.btnMovePrevious_Click.Name = "btnMovePrevious_Click";
            this.btnMovePrevious_Click.Size = new System.Drawing.Size(75, 23);
            this.btnMovePrevious_Click.TabIndex = 15;
            this.btnMovePrevious_Click.Text = "<";
            this.btnMovePrevious_Click.UseVisualStyleBackColor = true;
            this.btnMovePrevious_Click.Click += new System.EventHandler(this.btnMovePrevious_Click_Click);
            // 
            // btnMoveNext_Click
            // 
            this.btnMoveNext_Click.Location = new System.Drawing.Point(395, 336);
            this.btnMoveNext_Click.Name = "btnMoveNext_Click";
            this.btnMoveNext_Click.Size = new System.Drawing.Size(75, 23);
            this.btnMoveNext_Click.TabIndex = 16;
            this.btnMoveNext_Click.Text = ">";
            this.btnMoveNext_Click.UseVisualStyleBackColor = true;
            this.btnMoveNext_Click.Click += new System.EventHandler(this.btnMoveNext_Click_Click);
            // 
            // btnMoveLast_Click
            // 
            this.btnMoveLast_Click.Location = new System.Drawing.Point(511, 336);
            this.btnMoveLast_Click.Name = "btnMoveLast_Click";
            this.btnMoveLast_Click.Size = new System.Drawing.Size(75, 23);
            this.btnMoveLast_Click.TabIndex = 17;
            this.btnMoveLast_Click.Text = ">>";
            this.btnMoveLast_Click.UseVisualStyleBackColor = true;
            this.btnMoveLast_Click.Click += new System.EventHandler(this.btnMoveLast_Click_Click);
            // 
            // btnNew_Click
            // 
            this.btnNew_Click.Location = new System.Drawing.Point(163, 393);
            this.btnNew_Click.Name = "btnNew_Click";
            this.btnNew_Click.Size = new System.Drawing.Size(75, 23);
            this.btnNew_Click.TabIndex = 18;
            this.btnNew_Click.Text = "NEW";
            this.btnNew_Click.UseVisualStyleBackColor = true;
            this.btnNew_Click.Click += new System.EventHandler(this.btnNew_Click_Click);
            // 
            // btnSave_Click
            // 
            this.btnSave_Click.Location = new System.Drawing.Point(288, 393);
            this.btnSave_Click.Name = "btnSave_Click";
            this.btnSave_Click.Size = new System.Drawing.Size(75, 23);
            this.btnSave_Click.TabIndex = 19;
            this.btnSave_Click.Text = "SAVE";
            this.btnSave_Click.UseVisualStyleBackColor = true;
            this.btnSave_Click.Click += new System.EventHandler(this.btnSave_Click_Click);
            // 
            // btnUpdate_Click
            // 
            this.btnUpdate_Click.Location = new System.Drawing.Point(395, 393);
            this.btnUpdate_Click.Name = "btnUpdate_Click";
            this.btnUpdate_Click.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate_Click.TabIndex = 20;
            this.btnUpdate_Click.Text = "UPDATE";
            this.btnUpdate_Click.UseVisualStyleBackColor = true;
            this.btnUpdate_Click.Click += new System.EventHandler(this.btnUpdate_Click_Click);
            // 
            // btnDelete_Click
            // 
            this.btnDelete_Click.Location = new System.Drawing.Point(511, 393);
            this.btnDelete_Click.Name = "btnDelete_Click";
            this.btnDelete_Click.Size = new System.Drawing.Size(75, 23);
            this.btnDelete_Click.TabIndex = 21;
            this.btnDelete_Click.Text = "DELETE";
            this.btnDelete_Click.UseVisualStyleBackColor = true;
            this.btnDelete_Click.Click += new System.EventHandler(this.btnDelete_Click_Click);
            // 
            // frmCustomerCrudFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete_Click);
            this.Controls.Add(this.btnUpdate_Click);
            this.Controls.Add(this.btnSave_Click);
            this.Controls.Add(this.btnNew_Click);
            this.Controls.Add(this.btnMoveLast_Click);
            this.Controls.Add(this.btnMoveNext_Click);
            this.Controls.Add(this.btnMovePrevious_Click);
            this.Controls.Add(this.btnMoveFirst_Click);
            this.Controls.Add(this.label7);
          //  this.Controls.Add(this.txtRegdate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCustomerAddress);
            this.Controls.Add(this.txtCustomerPhone);
            this.Controls.Add(this.txtCustomerEmail);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customerDataGridView);
            this.Name = "frmCustomerCrudFrom";
            this.Text = "frmCustomerCrudFrom";
            this.Load += new System.EventHandler(this.frmCustomerCrudFrom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView customerDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtCustomerEmail;
        private System.Windows.Forms.TextBox txtCustomerPhone;
        private System.Windows.Forms.TextBox txtCustomerAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
       // private System.Windows.Forms.TextBox txtRegdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnMoveFirst_Click;
        private System.Windows.Forms.Button btnMovePrevious_Click;
        private System.Windows.Forms.Button btnMoveNext_Click;
        private System.Windows.Forms.Button btnMoveLast_Click;
        private System.Windows.Forms.Button btnNew_Click;
        private System.Windows.Forms.Button btnSave_Click;
        private System.Windows.Forms.Button btnUpdate_Click;
        private System.Windows.Forms.Button btnDelete_Click;
    }
}