namespace EmployeeManagementSystem.Salary
{
    partial class SalaryShow
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
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnHomeSalary = new System.Windows.Forms.Button();
            this.btnSalaryEdit = new System.Windows.Forms.Button();
            this.btnDeleteSalary = new System.Windows.Forms.Button();
            this.btnAddSalary = new System.Windows.Forms.Button();
            this.dataGridViewSalary = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(635, 357);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnLogOut.TabIndex = 12;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnHomeSalary
            // 
            this.btnHomeSalary.Location = new System.Drawing.Point(554, 357);
            this.btnHomeSalary.Name = "btnHomeSalary";
            this.btnHomeSalary.Size = new System.Drawing.Size(75, 23);
            this.btnHomeSalary.TabIndex = 11;
            this.btnHomeSalary.Text = "Home";
            this.btnHomeSalary.UseVisualStyleBackColor = true;
            this.btnHomeSalary.Click += new System.EventHandler(this.btnHomeSalary_Click);
            // 
            // btnSalaryEdit
            // 
            this.btnSalaryEdit.Location = new System.Drawing.Point(229, 357);
            this.btnSalaryEdit.Name = "btnSalaryEdit";
            this.btnSalaryEdit.Size = new System.Drawing.Size(75, 23);
            this.btnSalaryEdit.TabIndex = 9;
            this.btnSalaryEdit.Text = "Edit";
            this.btnSalaryEdit.UseVisualStyleBackColor = true;
            this.btnSalaryEdit.Click += new System.EventHandler(this.btnSalaryEdit_Click);
            // 
            // btnDeleteSalary
            // 
            this.btnDeleteSalary.Location = new System.Drawing.Point(148, 357);
            this.btnDeleteSalary.Name = "btnDeleteSalary";
            this.btnDeleteSalary.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteSalary.TabIndex = 10;
            this.btnDeleteSalary.Text = "Delete";
            this.btnDeleteSalary.UseVisualStyleBackColor = true;
            // 
            // btnAddSalary
            // 
            this.btnAddSalary.Location = new System.Drawing.Point(14, 357);
            this.btnAddSalary.Name = "btnAddSalary";
            this.btnAddSalary.Size = new System.Drawing.Size(128, 23);
            this.btnAddSalary.TabIndex = 8;
            this.btnAddSalary.Text = "Add New Salary";
            this.btnAddSalary.UseVisualStyleBackColor = true;
            this.btnAddSalary.Click += new System.EventHandler(this.btnAddSalary_Click);
            // 
            // dataGridViewSalary
            // 
            this.dataGridViewSalary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSalary.Location = new System.Drawing.Point(12, 48);
            this.dataGridViewSalary.Name = "dataGridViewSalary";
            this.dataGridViewSalary.RowTemplate.Height = 25;
            this.dataGridViewSalary.Size = new System.Drawing.Size(696, 281);
            this.dataGridViewSalary.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(308, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Salary";
            // 
            // SalaryShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 392);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnHomeSalary);
            this.Controls.Add(this.btnSalaryEdit);
            this.Controls.Add(this.btnDeleteSalary);
            this.Controls.Add(this.btnAddSalary);
            this.Controls.Add(this.dataGridViewSalary);
            this.Controls.Add(this.label1);
            this.Name = "SalaryShow";
            this.Text = "Salary";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnLogOut;
        private Button btnHomeSalary;
        private Button btnSalaryEdit;
        private Button btnDeleteSalary;
        private Button btnAddSalary;
        private DataGridView dataGridViewSalary;
        private Label label1;
    }
}