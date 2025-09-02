namespace Task_6
{
    partial class Employee
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            txtName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtJob = new TextBox();
            label3 = new Label();
            txtSalary = new TextBox();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            comboBox1 = new ComboBox();
            btnSave = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            label6 = new Label();
            txtSearch = new TextBox();
            btnShow = new Button();
            txtID = new TextBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(101, 62);
            txtName.Name = "txtName";
            txtName.Size = new Size(300, 27);
            txtName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 65);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 2;
            label1.Text = "Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 21);
            label2.Name = "label2";
            label2.Size = new Size(31, 20);
            label2.TabIndex = 3;
            label2.Text = "ID :";
            // 
            // txtJob
            // 
            txtJob.Location = new Point(101, 115);
            txtJob.Name = "txtJob";
            txtJob.Size = new Size(300, 27);
            txtJob.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 118);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 5;
            label3.Text = "Job :";
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(101, 164);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(300, 27);
            txtSalary.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 167);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 7;
            label4.Text = "Salary :";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(482, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(243, 211);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 224);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 2;
            label5.Text = "Name :";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(30, 247);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(300, 28);
            comboBox1.TabIndex = 9;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(30, 306);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += button1_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(255, 306);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(142, 306);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 10;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(379, 275);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 7;
            label6.Text = "Search :";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(379, 307);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(282, 27);
            txtSearch.TabIndex = 6;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(667, 307);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(94, 29);
            btnShow.TabIndex = 10;
            btnShow.Text = "Show";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(101, 18);
            txtID.Name = "txtID";
            txtID.Size = new Size(300, 27);
            txtID.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(30, 372);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(731, 228);
            dataGridView1.TabIndex = 11;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ImageAlign = ContentAlignment.TopRight;
            button1.Location = new Point(564, 229);
            button1.Name = "button1";
            button1.Size = new Size(58, 46);
            button1.TabIndex = 10;
            button1.Text = "...";
            button1.TextAlign = ContentAlignment.TopCenter;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Employee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 622);
            Controls.Add(dataGridView1);
            Controls.Add(btnEdit);
            Controls.Add(button1);
            Controls.Add(btnShow);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(comboBox1);
            Controls.Add(pictureBox1);
            Controls.Add(txtSearch);
            Controls.Add(txtSalary);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(txtJob);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtID);
            Controls.Add(txtName);
            Controls.Add(label5);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Employee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee";
            TransparencyKey = Color.Black;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private Label label1;
        private Label label2;
        private TextBox txtJob;
        private Label label3;
        private TextBox txtSalary;
        private Label label4;
        private PictureBox pictureBox1;
        private Label label5;
        private ComboBox comboBox1;
        private Button btnSave;
        private Button btnDelete;
        private Button btnEdit;
        private Label label6;
        private TextBox txtSearch;
        private Button btnShow;
        private TextBox txtID;
        private DataGridView dataGridView1;
        private Button button1;
    }
}
