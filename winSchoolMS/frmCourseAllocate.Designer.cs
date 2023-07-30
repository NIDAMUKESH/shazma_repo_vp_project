namespace winSchoolMS
{
    partial class frmCourseAllocate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCourseAllocate));
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSection = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gvCourseAllocate = new System.Windows.Forms.DataGridView();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvCourseAllocate)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(798, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(253, 206);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(168, 20);
            this.txtFirstName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(167, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "First Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(616, 202);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(168, 20);
            this.txtLastName.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(529, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Last Name";
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(253, 130);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(168, 20);
            this.txtCourseName.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Window;
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(167, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Course Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Window;
            this.label7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label7.Location = new System.Drawing.Point(529, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Class";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Highlight;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label8.Location = new System.Drawing.Point(563, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(221, 31);
            this.label8.TabIndex = 14;
            this.label8.Text = "Course Allocate";
            // 
            // txtSection
            // 
            this.txtSection.Location = new System.Drawing.Point(896, 126);
            this.txtSection.Name = "txtSection";
            this.txtSection.Size = new System.Drawing.Size(168, 20);
            this.txtSection.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Window;
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(847, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Section";
            // 
            // gvCourseAllocate
            // 
            this.gvCourseAllocate.BackgroundColor = System.Drawing.Color.LightGray;
            this.gvCourseAllocate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCourseAllocate.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.gvCourseAllocate.Location = new System.Drawing.Point(139, 347);
            this.gvCourseAllocate.Name = "gvCourseAllocate";
            this.gvCourseAllocate.ReadOnly = true;
            this.gvCourseAllocate.Size = new System.Drawing.Size(925, 264);
            this.gvCourseAllocate.TabIndex = 24;
            this.gvCourseAllocate.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvCourseAllocate_CellClick);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.SystemColors.Window;
            this.btnInsert.Location = new System.Drawing.Point(449, 283);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 41);
            this.btnInsert.TabIndex = 44;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.Window;
            this.btnUpdate.Location = new System.Drawing.Point(644, 283);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 41);
            this.btnUpdate.TabIndex = 45;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.Window;
            this.btnDelete.Location = new System.Drawing.Point(839, 283);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 41);
            this.btnDelete.TabIndex = 46;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(0, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1371, 65);
            this.panel1.TabIndex = 47;
            // 
            // cmbClass
            // 
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Items.AddRange(new object[] {
            "Class 1st",
            "Class 2nd",
            "Class 3rd",
            "Class 4th",
            "Class 5th",
            "Class 6th",
            "Class 7th",
            "Class 8th",
            "Class 9th",
            "Matric"});
            this.cmbClass.Location = new System.Drawing.Point(616, 128);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(168, 21);
            this.cmbClass.TabIndex = 48;
            // 
            // frmCourseAllocate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1284, 749);
            this.Controls.Add(this.cmbClass);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.gvCourseAllocate);
            this.Controls.Add(this.txtSection);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCourseName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCourseAllocate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Course Allocate";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCourseAllocate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvCourseAllocate)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSection;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView gvCourseAllocate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbClass;
    }
}