namespace EmployeeManagementSystem
{
    partial class project
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
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnHomeProject = new System.Windows.Forms.Button();
            this.btnEditProject = new System.Windows.Forms.Button();
            this.btnDeleteProject = new System.Windows.Forms.Button();
            this.btnAddProject = new System.Windows.Forms.Button();
            this.dataGridViewClient = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(288, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 36;
            this.label2.Text = "Projects";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(634, 359);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnLogOut.TabIndex = 35;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnHomeProject
            // 
            this.btnHomeProject.Location = new System.Drawing.Point(553, 359);
            this.btnHomeProject.Name = "btnHomeProject";
            this.btnHomeProject.Size = new System.Drawing.Size(75, 23);
            this.btnHomeProject.TabIndex = 34;
            this.btnHomeProject.Text = "Home";
            this.btnHomeProject.UseVisualStyleBackColor = true;
            this.btnHomeProject.Click += new System.EventHandler(this.btnHomeProject_Click);
            // 
            // btnEditProject
            // 
            this.btnEditProject.Location = new System.Drawing.Point(228, 359);
            this.btnEditProject.Name = "btnEditProject";
            this.btnEditProject.Size = new System.Drawing.Size(75, 23);
            this.btnEditProject.TabIndex = 32;
            this.btnEditProject.Text = "Edit";
            this.btnEditProject.UseVisualStyleBackColor = true;
            this.btnEditProject.Click += new System.EventHandler(this.btnEditProject_Click);
            // 
            // btnDeleteProject
            // 
            this.btnDeleteProject.Location = new System.Drawing.Point(147, 359);
            this.btnDeleteProject.Name = "btnDeleteProject";
            this.btnDeleteProject.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteProject.TabIndex = 33;
            this.btnDeleteProject.Text = "Delete";
            this.btnDeleteProject.UseVisualStyleBackColor = true;
            // 
            // btnAddProject
            // 
            this.btnAddProject.Location = new System.Drawing.Point(13, 359);
            this.btnAddProject.Name = "btnAddProject";
            this.btnAddProject.Size = new System.Drawing.Size(128, 23);
            this.btnAddProject.TabIndex = 31;
            this.btnAddProject.Text = "Add New Project";
            this.btnAddProject.UseVisualStyleBackColor = true;
            this.btnAddProject.Click += new System.EventHandler(this.btnAddProject_Click);
            // 
            // dataGridViewClient
            // 
            this.dataGridViewClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClient.Location = new System.Drawing.Point(11, 50);
            this.dataGridViewClient.Name = "dataGridViewClient";
            this.dataGridViewClient.RowTemplate.Height = 25;
            this.dataGridViewClient.Size = new System.Drawing.Size(696, 281);
            this.dataGridViewClient.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(307, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 25);
            this.label1.TabIndex = 29;
            this.label1.Text = " ";
            // 
            // project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 392);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnHomeProject);
            this.Controls.Add(this.btnEditProject);
            this.Controls.Add(this.btnDeleteProject);
            this.Controls.Add(this.btnAddProject);
            this.Controls.Add(this.dataGridViewClient);
            this.Controls.Add(this.label1);
            this.Name = "project";
            this.Text = "project";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private Button btnLogOut;
        private Button btnHomeProject;
        private Button btnEditProject;
        private Button btnDeleteProject;
        private Button btnAddProject;
        private DataGridView dataGridViewClient;
        private Label label1;
    }
}