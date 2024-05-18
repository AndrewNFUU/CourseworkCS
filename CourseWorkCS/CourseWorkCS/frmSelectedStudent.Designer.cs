namespace CourseWorkCS
{
    partial class frmSelectedStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelectedStudent));
            this.dataGridExams = new System.Windows.Forms.DataGridView();
            this.subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studyHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listBoxStats = new System.Windows.Forms.ListBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.labelFind = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridExams)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridExams
            // 
            this.dataGridExams.AllowUserToAddRows = false;
            this.dataGridExams.AllowUserToDeleteRows = false;
            this.dataGridExams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridExams.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subject,
            this.studyHours,
            this.examDate,
            this.firstName,
            this.lastName,
            this.position,
            this.grade});
            this.dataGridExams.Location = new System.Drawing.Point(12, 81);
            this.dataGridExams.Name = "dataGridExams";
            this.dataGridExams.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridExams.RowHeadersVisible = false;
            this.dataGridExams.RowHeadersWidth = 51;
            this.dataGridExams.RowTemplate.Height = 24;
            this.dataGridExams.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridExams.Size = new System.Drawing.Size(716, 204);
            this.dataGridExams.TabIndex = 13;
            // 
            // subject
            // 
            this.subject.HeaderText = "Subject";
            this.subject.MinimumWidth = 6;
            this.subject.Name = "subject";
            this.subject.Width = 110;
            // 
            // studyHours
            // 
            this.studyHours.HeaderText = "Study hours";
            this.studyHours.MinimumWidth = 6;
            this.studyHours.Name = "studyHours";
            this.studyHours.Width = 55;
            // 
            // examDate
            // 
            this.examDate.HeaderText = "Exam date";
            this.examDate.MinimumWidth = 6;
            this.examDate.Name = "examDate";
            this.examDate.Width = 85;
            // 
            // firstName
            // 
            this.firstName.HeaderText = "First name";
            this.firstName.MinimumWidth = 6;
            this.firstName.Name = "firstName";
            this.firstName.Width = 66;
            // 
            // lastName
            // 
            this.lastName.HeaderText = "Last name";
            this.lastName.MinimumWidth = 6;
            this.lastName.Name = "lastName";
            this.lastName.Width = 66;
            // 
            // position
            // 
            this.position.HeaderText = "Position";
            this.position.MinimumWidth = 6;
            this.position.Name = "position";
            this.position.Width = 90;
            // 
            // grade
            // 
            this.grade.HeaderText = "Grade";
            this.grade.MinimumWidth = 6;
            this.grade.Name = "grade";
            this.grade.Width = 63;
            // 
            // listBoxStats
            // 
            this.listBoxStats.FormattingEnabled = true;
            this.listBoxStats.ItemHeight = 16;
            this.listBoxStats.Location = new System.Drawing.Point(12, 291);
            this.listBoxStats.Name = "listBoxStats";
            this.listBoxStats.Size = new System.Drawing.Size(716, 132);
            this.listBoxStats.TabIndex = 14;
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnFind.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFind.Location = new System.Drawing.Point(486, 32);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(97, 34);
            this.btnFind.TabIndex = 33;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtSubject
            // 
            this.txtSubject.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubject.Location = new System.Drawing.Point(286, 36);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(173, 28);
            this.txtSubject.TabIndex = 32;
            this.txtSubject.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSubject_KeyDown);
            // 
            // labelFind
            // 
            this.labelFind.AutoSize = true;
            this.labelFind.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFind.Location = new System.Drawing.Point(118, 38);
            this.labelFind.Name = "labelFind";
            this.labelFind.Size = new System.Drawing.Size(150, 23);
            this.labelFind.TabIndex = 31;
            this.labelFind.Text = "Enter subgect:";
            // 
            // frmSelectedStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 433);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.labelFind);
            this.Controls.Add(this.listBoxStats);
            this.Controls.Add(this.dataGridExams);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSelectedStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selected student";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridExams)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridExams;
        private System.Windows.Forms.ListBox listBoxStats;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label labelFind;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn studyHours;
        private System.Windows.Forms.DataGridViewTextBoxColumn examDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn position;
        private System.Windows.Forms.DataGridViewTextBoxColumn grade;
    }
}