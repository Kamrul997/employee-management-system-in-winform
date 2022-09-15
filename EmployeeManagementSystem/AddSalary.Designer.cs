namespace EmployeeManagementSystem.Salary
{
    partial class AddSalary
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnBackAddSalary = new System.Windows.Forms.Button();
            this.btnSubmitEmployee = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SalayAmount = new System.Windows.Forms.TextBox();
            this.comboBoxEmployeeID = new System.Windows.Forms.ComboBox();
            this.dateTimeToMonth = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimeFromMonth = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(624, 357);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnLogOut.TabIndex = 11;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(111, 357);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnBackAddSalary
            // 
            this.btnBackAddSalary.Location = new System.Drawing.Point(15, 357);
            this.btnBackAddSalary.Name = "btnBackAddSalary";
            this.btnBackAddSalary.Size = new System.Drawing.Size(75, 23);
            this.btnBackAddSalary.TabIndex = 9;
            this.btnBackAddSalary.Text = "Back";
            this.btnBackAddSalary.UseVisualStyleBackColor = true;
            this.btnBackAddSalary.Click += new System.EventHandler(this.btnBackAddSalary_Click);
            // 
            // btnSubmitEmployee
            // 
            this.btnSubmitEmployee.Location = new System.Drawing.Point(530, 357);
            this.btnSubmitEmployee.Name = "btnSubmitEmployee";
            this.btnSubmitEmployee.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitEmployee.TabIndex = 10;
            this.btnSubmitEmployee.Text = "Submit";
            this.btnSubmitEmployee.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Salary Amount";
            // 
            // SalayAmount
            // 
            this.SalayAmount.Location = new System.Drawing.Point(53, 191);
            this.SalayAmount.Name = "SalayAmount";
            this.SalayAmount.Size = new System.Drawing.Size(211, 23);
            this.SalayAmount.TabIndex = 13;
            // 
            // comboBoxEmployeeID
            // 
            this.comboBoxEmployeeID.FormattingEnabled = true;
            this.comboBoxEmployeeID.Location = new System.Drawing.Point(53, 129);
            this.comboBoxEmployeeID.Name = "comboBoxEmployeeID";
            this.comboBoxEmployeeID.Size = new System.Drawing.Size(211, 23);
            this.comboBoxEmployeeID.TabIndex = 19;
            // 
            // dateTimeToMonth
            // 
            this.dateTimeToMonth.Location = new System.Drawing.Point(366, 188);
            this.dateTimeToMonth.Name = "dateTimeToMonth";
            this.dateTimeToMonth.Size = new System.Drawing.Size(211, 23);
            this.dateTimeToMonth.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(366, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "To Month";
            // 
            // dateTimeFromMonth
            // 
            this.dateTimeFromMonth.Location = new System.Drawing.Point(366, 129);
            this.dateTimeFromMonth.Name = "dateTimeFromMonth";
            this.dateTimeFromMonth.Size = new System.Drawing.Size(211, 23);
            this.dateTimeFromMonth.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(366, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 15);
            this.label10.TabIndex = 15;
            this.label10.Text = "From Month";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(53, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 15);
            this.label11.TabIndex = 16;
            this.label11.Text = "Employoee ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(225, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Add Employee Salary";
            // 
            // AddSalary
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
            this.Controls.Add(this.SalayAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnBackAddSalary);
            this.Controls.Add(this.btnSubmitEmployee);
            this.Name = "AddSalary";
            this.Text = "AddSalary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnLogOut;
        private Button btnRefresh;
        private Button btnBackAddSalary;
        private Button btnSubmitEmployee;
        private Label label1;
        private TextBox SalayAmount;
        private ComboBox comboBoxEmployeeID;
        private DateTimePicker dateTimeToMonth;
        private Label label8;
        private DateTimePicker dateTimeFromMonth;
        private Label label10;
        private Label label11;
        private Label label2;
    }
}