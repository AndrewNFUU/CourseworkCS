namespace CourseWorkCS
{
    partial class frmStudents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudents));
            this.dataGridStudents = new System.Windows.Forms.DataGridView();
            this.firsrtName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examsCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReadFromFile = new System.Windows.Forms.Button();
            this.btnWriteToFile = new System.Windows.Forms.Button();
            this.btnSortTeachers = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.labelFind = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridStudents
            // 
            this.dataGridStudents.AllowUserToAddRows = false;
            this.dataGridStudents.AllowUserToDeleteRows = false;
            this.dataGridStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firsrtName,
            this.lastName,
            this.group,
            this.examsCount});
            this.dataGridStudents.Location = new System.Drawing.Point(21, 99);
            this.dataGridStudents.Name = "dataGridStudents";
            this.dataGridStudents.RowHeadersVisible = false;
            this.dataGridStudents.RowHeadersWidth = 51;
            this.dataGridStudents.RowTemplate.Height = 24;
            this.dataGridStudents.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridStudents.Size = new System.Drawing.Size(501, 288);
            this.dataGridStudents.TabIndex = 13;
            this.dataGridStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridStudents_CellContentClick);
            // 
            // firsrtName
            // 
            this.firsrtName.HeaderText = "First name";
            this.firsrtName.MinimumWidth = 6;
            this.firsrtName.Name = "firsrtName";
            this.firsrtName.Width = 83;
            // 
            // lastName
            // 
            this.lastName.HeaderText = "Last name";
            this.lastName.MinimumWidth = 6;
            this.lastName.Name = "lastName";
            this.lastName.Width = 85;
            // 
            // group
            // 
            this.group.HeaderText = "Group";
            this.group.MinimumWidth = 6;
            this.group.Name = "group";
            this.group.Width = 140;
            // 
            // examsCount
            // 
            this.examsCount.HeaderText = "Exams";
            this.examsCount.MinimumWidth = 6;
            this.examsCount.Name = "examsCount";
            this.examsCount.Width = 65;
            // 
            // btnReadFromFile
            // 
            this.btnReadFromFile.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnReadFromFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReadFromFile.Location = new System.Drawing.Point(552, 347);
            this.btnReadFromFile.Name = "btnReadFromFile";
            this.btnReadFromFile.Size = new System.Drawing.Size(159, 40);
            this.btnReadFromFile.TabIndex = 27;
            this.btnReadFromFile.Text = "Read from file";
            this.btnReadFromFile.UseVisualStyleBackColor = false;
            this.btnReadFromFile.Click += new System.EventHandler(this.btnReadFromFile_Click);
            // 
            // btnWriteToFile
            // 
            this.btnWriteToFile.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnWriteToFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnWriteToFile.Location = new System.Drawing.Point(552, 301);
            this.btnWriteToFile.Name = "btnWriteToFile";
            this.btnWriteToFile.Size = new System.Drawing.Size(159, 40);
            this.btnWriteToFile.TabIndex = 26;
            this.btnWriteToFile.Text = "Write to file";
            this.btnWriteToFile.UseVisualStyleBackColor = false;
            this.btnWriteToFile.Click += new System.EventHandler(this.btnWriteToFile_Click);
            // 
            // btnSortTeachers
            // 
            this.btnSortTeachers.BackColor = System.Drawing.Color.Cornsilk;
            this.btnSortTeachers.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSortTeachers.Location = new System.Drawing.Point(552, 191);
            this.btnSortTeachers.Name = "btnSortTeachers";
            this.btnSortTeachers.Size = new System.Drawing.Size(159, 40);
            this.btnSortTeachers.TabIndex = 25;
            this.btnSortTeachers.Text = "Sort ";
            this.btnSortTeachers.UseVisualStyleBackColor = false;
            this.btnSortTeachers.Click += new System.EventHandler(this.btnSortTeachers_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Cornsilk;
            this.btnRefresh.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRefresh.Location = new System.Drawing.Point(552, 145);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(159, 40);
            this.btnRefresh.TabIndex = 24;
            this.btnRefresh.Text = "Refresh data";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.BackColor = System.Drawing.Color.Cornsilk;
            this.btnAddStudent.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddStudent.Location = new System.Drawing.Point(552, 99);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(159, 40);
            this.btnAddStudent.TabIndex = 23;
            this.btnAddStudent.Text = "Add new";
            this.btnAddStudent.UseVisualStyleBackColor = false;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnFind.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFind.Location = new System.Drawing.Point(552, 40);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(97, 34);
            this.btnFind.TabIndex = 30;
            this.btnFind.Text = "Select";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(349, 43);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(173, 28);
            this.txtLastName.TabIndex = 29;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            this.txtLastName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLastName_KeyDown);
            // 
            // labelFind
            // 
            this.labelFind.AutoSize = true;
            this.labelFind.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFind.Location = new System.Drawing.Point(159, 44);
            this.labelFind.Name = "labelFind";
            this.labelFind.Size = new System.Drawing.Size(168, 23);
            this.labelFind.TabIndex = 28;
            this.labelFind.Text = "Enter last name:";
            this.labelFind.Click += new System.EventHandler(this.labelFind_Click);
            // 
            // frmStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 433);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.labelFind);
            this.Controls.Add(this.btnReadFromFile);
            this.Controls.Add(this.btnWriteToFile);
            this.Controls.Add(this.btnSortTeachers);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.dataGridStudents);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmStudents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Students";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridStudents;
        private System.Windows.Forms.Button btnReadFromFile;
        private System.Windows.Forms.Button btnWriteToFile;
        private System.Windows.Forms.Button btnSortTeachers;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label labelFind;
        private System.Windows.Forms.DataGridViewTextBoxColumn firsrtName;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn group;
        private System.Windows.Forms.DataGridViewTextBoxColumn examsCount;
    }
}