namespace EmployeeManagementSystem.Salary
{
    partial class SalaryUpdate
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
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxEmployeeID = new System.Windows.Forms.ComboBox();
            this.dateTimeToMonth = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimeFromMonth = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SalayAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnUpdateEmployee = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SalaryID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(228, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 25);
            this.label2.TabIndex = 33;
            this.label2.Text = "Add Employee Salary";
            // 
            // comboBoxEmployeeID
            // 
            this.comboBoxEmployeeID.FormattingEnabled = true;
            this.comboBoxEmployeeID.Location = new System.Drawing.Point(70, 161);
            this.comboBoxEmployeeID.Name = "comboBoxEmployeeID";
            this.comboBoxEmployeeID.Size = new System.Drawing.Size(211, 23);
            this.comboBoxEmployeeID.TabIndex = 32;
            // 
            // dateTimeToMonth
            // 
            this.dateTimeToMonth.Location = new System.Drawing.Point(383, 220);
            this.dateTimeToMonth.Name = "dateTimeToMonth";
            this.dateTimeToMonth.Size = new System.Drawing.Size(211, 23);
            this.dateTimeToMonth.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(383, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 15);
            this.label8.TabIndex = 27;
            this.label8.Text = "To Month";
            // 
            // dateTimeFromMonth
            // 
            this.dateTimeFromMonth.Location = new System.Drawing.Point(383, 161);
            this.dateTimeFromMonth.Name = "dateTimeFromMonth";
            this.dateTimeFromMonth.Size = new System.Drawing.Size(211, 23);
            this.dateTimeFromMonth.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(383, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 15);
            this.label10.TabIndex = 28;
            this.label10.Text = "From Month";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(70, 143);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 15);
            this.label11.TabIndex = 29;
            this.label11.Text = "Employoee ID";
            // 
            // SalayAmount
            // 
            this.SalayAmount.Location = new System.Drawing.Point(70, 220);
            this.SalayAmount.Name = "SalayAmount";
            this.SalayAmount.Size = new System.Drawing.Size(211, 23);
            this.SalayAmount.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 25;
            this.label1.Text = "Salary Amount";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(627, 348);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnLogOut.TabIndex = 24;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(114, 348);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 21;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(18, 348);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 22;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnUpdateEmployee
            // 
            this.btnUpdateEmployee.Location = new System.Drawing.Point(533, 348);
            this.btnUpdateEmployee.Name = "btnUpdateEmployee";
            this.btnUpdateEmployee.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateEmployee.TabIndex = 23;
            this.btnUpdateEmployee.Text = "Update";
            this.btnUpdateEmployee.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 25;
            this.label3.Text = "Salary ID";
            // 
            // SalaryID
            // 
            this.SalaryID.Location = new System.Drawing.Point(65, 92);
            this.SalaryID.Name = "SalaryID";
            this.SalaryID.Size = new System.Drawing.Size(211, 23);
            this.SalaryID.TabIndex = 26;
            // 
            // SalaryUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 392);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxEmployeeID);
            this.Controls.Add(this.dateTimeToMonth);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimeFromMonth);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.SalaryID);
            this.Controls.Add(this.SalayAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnUpdateEmployee);
            this.Name = "SalaryUpdate";
            this.Text = "SalaryUpdate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private ComboBox comboBoxEmployeeID;
        private DateTimePicker dateTimeToMonth;
        private Label label8;
        private DateTimePicker dateTimeFromMonth;
        private Label label10;
        private Label label11;
        private TextBox SalayAmount;
        private Label label1;
        private Button btnLogOut;
        private Button btnRefresh;
        private Button btnBack;
        private Button btnUpdateEmployee;
        private Label label3;
        private TextBox SalaryID;
    }
}