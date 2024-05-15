namespace CourseWorkCS
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTeachers = new System.Windows.Forms.Button();
            this.btnStudents = new System.Windows.Forms.Button();
            this.btnCoursework = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(37, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to StudyHub!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 63);
            this.label2.TabIndex = 1;
            this.label2.Text = "Created to manage information \r\n  about teachers, students, and \r\nexams in a univ" +
    "ersity environment.";
            // 
            // btnTeachers
            // 
            this.btnTeachers.BackColor = System.Drawing.Color.Cornsilk;
            this.btnTeachers.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTeachers.Location = new System.Drawing.Point(436, 91);
            this.btnTeachers.Name = "btnTeachers";
            this.btnTeachers.Size = new System.Drawing.Size(168, 56);
            this.btnTeachers.TabIndex = 3;
            this.btnTeachers.Text = "Teachers";
            this.btnTeachers.UseVisualStyleBackColor = false;
            this.btnTeachers.Click += new System.EventHandler(this.btnTeachers_Click);
            // 
            // btnStudents
            // 
            this.btnStudents.BackColor = System.Drawing.Color.Cornsilk;
            this.btnStudents.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStudents.Location = new System.Drawing.Point(436, 164);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(168, 56);
            this.btnStudents.TabIndex = 4;
            this.btnStudents.Text = "Students";
            this.btnStudents.UseVisualStyleBackColor = false;
            this.btnStudents.Click += new System.EventHandler(this.btnStudents_Click);
            // 
            // btnCoursework
            // 
            this.btnCoursework.BackColor = System.Drawing.Color.Cornsilk;
            this.btnCoursework.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCoursework.Location = new System.Drawing.Point(436, 238);
            this.btnCoursework.Name = "btnCoursework";
            this.btnCoursework.Size = new System.Drawing.Size(168, 64);
            this.btnCoursework.TabIndex = 5;
            this.btnCoursework.Text = "Coursework Stuff";
            this.btnCoursework.UseVisualStyleBackColor = false;
            this.btnCoursework.Click += new System.EventHandler(this.btnCoursework_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.Cornsilk;
            this.btnAbout.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAbout.Location = new System.Drawing.Point(436, 342);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(168, 56);
            this.btnAbout.TabIndex = 6;
            this.btnAbout.Text = "App and Developer";
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CourseWorkCS.Properties.Resources.logo_color;
            this.pictureBox1.Location = new System.Drawing.Point(43, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(317, 219);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(642, 433);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnCoursework);
            this.Controls.Add(this.btnStudents);
            this.Controls.Add(this.btnTeachers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTeachers;
        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.Button btnCoursework;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}