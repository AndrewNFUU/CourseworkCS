namespace CourseWorkCS
{
    partial class frmTeachers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTeachers));
            this.dataGridTeachers = new System.Windows.Forms.DataGridView();
            this.firsrtName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAddTeacher = new System.Windows.Forms.Button();
            this.btnFindTeacher = new System.Windows.Forms.Button();
            this.btnSortTeachers = new System.Windows.Forms.Button();
            this.btnReadFromFile = new System.Windows.Forms.Button();
            this.btnWriteToFile = new System.Windows.Forms.Button();
            this.labelFind = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTeachers)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridTeachers
            // 
            this.dataGridTeachers.AllowUserToAddRows = false;
            this.dataGridTeachers.AllowUserToDeleteRows = false;
            this.dataGridTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTeachers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firsrtName,
            this.lastName,
            this.position});
            this.dataGridTeachers.Location = new System.Drawing.Point(25, 95);
            this.dataGridTeachers.Name = "dataGridTeachers";
            this.dataGridTeachers.RowHeadersVisible = false;
            this.dataGridTeachers.RowHeadersWidth = 51;
            this.dataGridTeachers.RowTemplate.Height = 24;
            this.dataGridTeachers.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridTeachers.Size = new System.Drawing.Size(390, 288);
            this.dataGridTeachers.TabIndex = 12;
            // 
            // firsrtName
            // 
            this.firsrtName.HeaderText = "First name";
            this.firsrtName.MinimumWidth = 6;
            this.firsrtName.Name = "firsrtName";
            this.firsrtName.Width = 95;
            // 
            // lastName
            // 
            this.lastName.HeaderText = "Last name";
            this.lastName.MinimumWidth = 6;
            this.lastName.Name = "lastName";
            this.lastName.Width = 95;
            // 
            // position
            // 
            this.position.HeaderText = "Position";
            this.position.MinimumWidth = 6;
            this.position.Name = "position";
            this.position.Width = 125;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Cornsilk;
            this.btnRefresh.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRefresh.Location = new System.Drawing.Point(447, 187);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(168, 40);
            this.btnRefresh.TabIndex = 18;
            this.btnRefresh.Text = "Refresh data";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAddTeacher
            // 
            this.btnAddTeacher.BackColor = System.Drawing.Color.Cornsilk;
            this.btnAddTeacher.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddTeacher.Location = new System.Drawing.Point(447, 141);
            this.btnAddTeacher.Name = "btnAddTeacher";
            this.btnAddTeacher.Size = new System.Drawing.Size(168, 40);
            this.btnAddTeacher.TabIndex = 17;
            this.btnAddTeacher.Text = "Add teacher";
            this.btnAddTeacher.UseVisualStyleBackColor = false;
            this.btnAddTeacher.Click += new System.EventHandler(this.btnAddTeacher_Click);
            // 
            // btnFindTeacher
            // 
            this.btnFindTeacher.BackColor = System.Drawing.Color.Cornsilk;
            this.btnFindTeacher.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFindTeacher.Location = new System.Drawing.Point(447, 95);
            this.btnFindTeacher.Name = "btnFindTeacher";
            this.btnFindTeacher.Size = new System.Drawing.Size(168, 40);
            this.btnFindTeacher.TabIndex = 16;
            this.btnFindTeacher.Text = "Find teacher";
            this.btnFindTeacher.UseVisualStyleBackColor = false;
            this.btnFindTeacher.Click += new System.EventHandler(this.btnFindTeacher_Click);
            // 
            // btnSortTeachers
            // 
            this.btnSortTeachers.BackColor = System.Drawing.Color.Cornsilk;
            this.btnSortTeachers.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSortTeachers.Location = new System.Drawing.Point(447, 233);
            this.btnSortTeachers.Name = "btnSortTeachers";
            this.btnSortTeachers.Size = new System.Drawing.Size(168, 40);
            this.btnSortTeachers.TabIndex = 19;
            this.btnSortTeachers.Text = "Sort teachers";
            this.btnSortTeachers.UseVisualStyleBackColor = false;
            this.btnSortTeachers.Click += new System.EventHandler(this.btnSortTeachers_Click);
            // 
            // btnReadFromFile
            // 
            this.btnReadFromFile.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnReadFromFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReadFromFile.Location = new System.Drawing.Point(447, 343);
            this.btnReadFromFile.Name = "btnReadFromFile";
            this.btnReadFromFile.Size = new System.Drawing.Size(168, 40);
            this.btnReadFromFile.TabIndex = 21;
            this.btnReadFromFile.Text = "Read from file";
            this.btnReadFromFile.UseVisualStyleBackColor = false;
            this.btnReadFromFile.Click += new System.EventHandler(this.btnReadFromFile_Click);
            // 
            // btnWriteToFile
            // 
            this.btnWriteToFile.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnWriteToFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnWriteToFile.Location = new System.Drawing.Point(447, 297);
            this.btnWriteToFile.Name = "btnWriteToFile";
            this.btnWriteToFile.Size = new System.Drawing.Size(168, 40);
            this.btnWriteToFile.TabIndex = 20;
            this.btnWriteToFile.Text = "Write to file";
            this.btnWriteToFile.UseVisualStyleBackColor = false;
            this.btnWriteToFile.Click += new System.EventHandler(this.btnWriteToFile_Click);
            // 
            // labelFind
            // 
            this.labelFind.AutoSize = true;
            this.labelFind.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFind.Location = new System.Drawing.Point(74, 37);
            this.labelFind.Name = "labelFind";
            this.labelFind.Size = new System.Drawing.Size(168, 23);
            this.labelFind.TabIndex = 22;
            this.labelFind.Text = "Enter last name:";
            this.labelFind.Visible = false;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtLastName.Location = new System.Drawing.Point(265, 36);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(150, 28);
            this.txtLastName.TabIndex = 23;
            this.txtLastName.Visible = false;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            this.txtLastName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLastName_KeyDown);
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnFind.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFind.Location = new System.Drawing.Point(447, 33);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(78, 33);
            this.btnFind.TabIndex = 24;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Visible = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // frmTeachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 433);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.labelFind);
            this.Controls.Add(this.btnReadFromFile);
            this.Controls.Add(this.btnWriteToFile);
            this.Controls.Add(this.btnSortTeachers);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAddTeacher);
            this.Controls.Add(this.btnFindTeacher);
            this.Controls.Add(this.dataGridTeachers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTeachers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teachers";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTeachers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridTeachers;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAddTeacher;
        private System.Windows.Forms.Button btnFindTeacher;
        private System.Windows.Forms.Button btnSortTeachers;
        private System.Windows.Forms.Button btnReadFromFile;
        private System.Windows.Forms.Button btnWriteToFile;
        private System.Windows.Forms.Label labelFind;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.DataGridViewTextBoxColumn firsrtName;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn position;
    }
}