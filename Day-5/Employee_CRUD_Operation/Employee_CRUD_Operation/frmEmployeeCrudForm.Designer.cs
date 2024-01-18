namespace Employee_CRUD_Operation
{
    partial class frmEmployeeCrudForm
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
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.txtEmployeeSalary = new System.Windows.Forms.TextBox();
            this.txtEmployeeAddress = new System.Windows.Forms.TextBox();
            this.txtEmployeeDesignation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_MoveFirst_Click = new System.Windows.Forms.Button();
            this.btn_MovePrevious_Click = new System.Windows.Forms.Button();
            this.btn_MoveNext_Click = new System.Windows.Forms.Button();
            this.btn_MoveLast_Click = new System.Windows.Forms.Button();
            this.btn_AddNewEmployee_Click = new System.Windows.Forms.Button();
            this.btn_Save_Employee_Click = new System.Windows.Forms.Button();
            this.btn_Update_Employee_Details_Click = new System.Windows.Forms.Button();
            this.btn_Delete_Employee_Click = new System.Windows.Forms.Button();
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
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(521, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employee CRUD Operation";
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(394, 122);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(207, 22);
            this.txtEmployeeID.TabIndex = 2;
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(394, 168);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(207, 22);
            this.txtEmployeeName.TabIndex = 3;
            // 
            // txtEmployeeSalary
            // 
            this.txtEmployeeSalary.Location = new System.Drawing.Point(394, 211);
            this.txtEmployeeSalary.Name = "txtEmployeeSalary";
            this.txtEmployeeSalary.Size = new System.Drawing.Size(207, 22);
            this.txtEmployeeSalary.TabIndex = 4;
            // 
            // txtEmployeeAddress
            // 
            this.txtEmployeeAddress.Location = new System.Drawing.Point(394, 253);
            this.txtEmployeeAddress.Name = "txtEmployeeAddress";
            this.txtEmployeeAddress.Size = new System.Drawing.Size(207, 22);
            this.txtEmployeeAddress.TabIndex = 5;
            // 
            // txtEmployeeDesignation
            // 
            this.txtEmployeeDesignation.Location = new System.Drawing.Point(394, 299);
            this.txtEmployeeDesignation.Name = "txtEmployeeDesignation";
            this.txtEmployeeDesignation.Size = new System.Drawing.Size(207, 22);
            this.txtEmployeeDesignation.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(156, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "EmployeeID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(156, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "EmployeeName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(156, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "EmployeeSalary";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(156, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "EmployeeAddress";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(156, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(221, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "EmployeeDesignation";
            // 
            // btn_MoveFirst_Click
            // 
            this.btn_MoveFirst_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MoveFirst_Click.Location = new System.Drawing.Point(102, 354);
            this.btn_MoveFirst_Click.Name = "btn_MoveFirst_Click";
            this.btn_MoveFirst_Click.Size = new System.Drawing.Size(116, 33);
            this.btn_MoveFirst_Click.TabIndex = 12;
            this.btn_MoveFirst_Click.Text = "<<";
            this.btn_MoveFirst_Click.UseVisualStyleBackColor = true;
            this.btn_MoveFirst_Click.Click += new System.EventHandler(this.btn_MoveFirst_Click_Click);
            // 
            // btn_MovePrevious_Click
            // 
            this.btn_MovePrevious_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MovePrevious_Click.Location = new System.Drawing.Point(255, 354);
            this.btn_MovePrevious_Click.Name = "btn_MovePrevious_Click";
            this.btn_MovePrevious_Click.Size = new System.Drawing.Size(122, 33);
            this.btn_MovePrevious_Click.TabIndex = 13;
            this.btn_MovePrevious_Click.Text = "<";
            this.btn_MovePrevious_Click.UseVisualStyleBackColor = true;
            this.btn_MovePrevious_Click.Click += new System.EventHandler(this.btn_MovePrevious_Click_Click);
            // 
            // btn_MoveNext_Click
            // 
            this.btn_MoveNext_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MoveNext_Click.Location = new System.Drawing.Point(394, 354);
            this.btn_MoveNext_Click.Name = "btn_MoveNext_Click";
            this.btn_MoveNext_Click.Size = new System.Drawing.Size(126, 33);
            this.btn_MoveNext_Click.TabIndex = 14;
            this.btn_MoveNext_Click.Text = ">";
            this.btn_MoveNext_Click.UseVisualStyleBackColor = true;
            this.btn_MoveNext_Click.Click += new System.EventHandler(this.btn_MoveNext_Click_Click);
            // 
            // btn_MoveLast_Click
            // 
            this.btn_MoveLast_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MoveLast_Click.Location = new System.Drawing.Point(540, 354);
            this.btn_MoveLast_Click.Name = "btn_MoveLast_Click";
            this.btn_MoveLast_Click.Size = new System.Drawing.Size(148, 33);
            this.btn_MoveLast_Click.TabIndex = 15;
            this.btn_MoveLast_Click.Text = ">>";
            this.btn_MoveLast_Click.UseVisualStyleBackColor = true;
            this.btn_MoveLast_Click.Click += new System.EventHandler(this.btn_MoveLast_Click_Click);
            // 
            // btn_AddNewEmployee_Click
            // 
            this.btn_AddNewEmployee_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddNewEmployee_Click.Location = new System.Drawing.Point(102, 407);
            this.btn_AddNewEmployee_Click.Name = "btn_AddNewEmployee_Click";
            this.btn_AddNewEmployee_Click.Size = new System.Drawing.Size(116, 31);
            this.btn_AddNewEmployee_Click.TabIndex = 16;
            this.btn_AddNewEmployee_Click.Text = "NEW";
            this.btn_AddNewEmployee_Click.UseVisualStyleBackColor = true;
            this.btn_AddNewEmployee_Click.Click += new System.EventHandler(this.btn_AddNewEmployee_Click_Click);
            // 
            // btn_Save_Employee_Click
            // 
            this.btn_Save_Employee_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save_Employee_Click.Location = new System.Drawing.Point(255, 407);
            this.btn_Save_Employee_Click.Name = "btn_Save_Employee_Click";
            this.btn_Save_Employee_Click.Size = new System.Drawing.Size(122, 31);
            this.btn_Save_Employee_Click.TabIndex = 17;
            this.btn_Save_Employee_Click.Text = "SAVE";
            this.btn_Save_Employee_Click.UseVisualStyleBackColor = true;
            this.btn_Save_Employee_Click.Click += new System.EventHandler(this.btn_Save_Employee_Click_Click);
            // 
            // btn_Update_Employee_Details_Click
            // 
            this.btn_Update_Employee_Details_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update_Employee_Details_Click.Location = new System.Drawing.Point(394, 407);
            this.btn_Update_Employee_Details_Click.Name = "btn_Update_Employee_Details_Click";
            this.btn_Update_Employee_Details_Click.Size = new System.Drawing.Size(126, 31);
            this.btn_Update_Employee_Details_Click.TabIndex = 18;
            this.btn_Update_Employee_Details_Click.Text = "UPDATE";
            this.btn_Update_Employee_Details_Click.UseVisualStyleBackColor = true;
            this.btn_Update_Employee_Details_Click.Click += new System.EventHandler(this.btn_Update_Employee_Details_Click_Click);
            // 
            // btn_Delete_Employee_Click
            // 
            this.btn_Delete_Employee_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete_Employee_Click.Location = new System.Drawing.Point(540, 407);
            this.btn_Delete_Employee_Click.Name = "btn_Delete_Employee_Click";
            this.btn_Delete_Employee_Click.Size = new System.Drawing.Size(148, 31);
            this.btn_Delete_Employee_Click.TabIndex = 19;
            this.btn_Delete_Employee_Click.Text = "DELETE";
            this.btn_Delete_Employee_Click.UseVisualStyleBackColor = true;
            this.btn_Delete_Employee_Click.Click += new System.EventHandler(this.btn_Delete_Employee_Click_Click);
            // 
            // frmEmployeeCrudForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Delete_Employee_Click);
            this.Controls.Add(this.btn_Update_Employee_Details_Click);
            this.Controls.Add(this.btn_Save_Employee_Click);
            this.Controls.Add(this.btn_AddNewEmployee_Click);
            this.Controls.Add(this.btn_MoveLast_Click);
            this.Controls.Add(this.btn_MoveNext_Click);
            this.Controls.Add(this.btn_MovePrevious_Click);
            this.Controls.Add(this.btn_MoveFirst_Click);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmployeeDesignation);
            this.Controls.Add(this.txtEmployeeAddress);
            this.Controls.Add(this.txtEmployeeSalary);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.txtEmployeeID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmEmployeeCrudForm";
            this.Text = "frmEmployeeCrudForm";
            this.Load += new System.EventHandler(this.frmEmployeeCrudForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.TextBox txtEmployeeSalary;
        private System.Windows.Forms.TextBox txtEmployeeAddress;
        private System.Windows.Forms.TextBox txtEmployeeDesignation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_MoveFirst_Click;
        private System.Windows.Forms.Button btn_MovePrevious_Click;
        private System.Windows.Forms.Button btn_MoveNext_Click;
        private System.Windows.Forms.Button btn_MoveLast_Click;
        private System.Windows.Forms.Button btn_AddNewEmployee_Click;
        private System.Windows.Forms.Button btn_Save_Employee_Click;
        private System.Windows.Forms.Button btn_Update_Employee_Details_Click;
        private System.Windows.Forms.Button btn_Delete_Employee_Click;
    }
}