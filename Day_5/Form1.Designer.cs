namespace Day_5
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label2 = new Label();
            txtName = new TextBox();
            label1 = new Label();
            rbtnMale = new RadioButton();
            rbtnFemale = new RadioButton();
            groupBox1 = new GroupBox();
            comboStatus = new ComboBox();
            dtpDOB = new DateTimePicker();
            label3 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            groupBox2 = new GroupBox();
            label4 = new Label();
            label5 = new Label();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            progressBar1 = new ProgressBar();
            progressBar2 = new ProgressBar();
            label6 = new Label();
            label7 = new Label();
            btnRepot = new Button();
            btnPageSetup = new Button();
            btnPreview = new Button();
            btnPrint = new Button();
            groupBox3 = new GroupBox();
            rtxtRepot = new RichTextBox();
            pageSetupDialog1 = new PageSetupDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printDialog1 = new PrintDialog();
            printPreviewDialog1 = new PrintPreviewDialog();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 25);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 1;
            label2.Text = "Name :";
            // 
            // txtName
            // 
            txtName.ForeColor = SystemColors.MenuHighlight;
            txtName.Location = new Point(86, 22);
            txtName.Name = "txtName";
            txtName.Size = new Size(274, 27);
            txtName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 67);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 3;
            label1.Text = "Birth Day :";
            // 
            // rbtnMale
            // 
            rbtnMale.AutoSize = true;
            rbtnMale.Location = new Point(9, 47);
            rbtnMale.Name = "rbtnMale";
            rbtnMale.Size = new Size(63, 24);
            rbtnMale.TabIndex = 0;
            rbtnMale.TabStop = true;
            rbtnMale.Text = "Male";
            rbtnMale.UseVisualStyleBackColor = true;
            // 
            // rbtnFemale
            // 
            rbtnFemale.AutoSize = true;
            rbtnFemale.Location = new Point(174, 47);
            rbtnFemale.Name = "rbtnFemale";
            rbtnFemale.Size = new Size(76, 24);
            rbtnFemale.TabIndex = 1;
            rbtnFemale.TabStop = true;
            rbtnFemale.Text = "female";
            rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbtnFemale);
            groupBox1.Controls.Add(rbtnMale);
            groupBox1.Location = new Point(12, 118);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(348, 100);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gender";
            // 
            // comboStatus
            // 
            comboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboStatus.FormattingEnabled = true;
            comboStatus.Items.AddRange(new object[] { "متزوج ", "اعزب ", "ارمل ", "مطلق" });
            comboStatus.Location = new Point(86, 239);
            comboStatus.Name = "comboStatus";
            comboStatus.Size = new Size(274, 28);
            comboStatus.TabIndex = 3;
            // 
            // dtpDOB
            // 
            dtpDOB.CustomFormat = "yyyy/MM/dd";
            dtpDOB.Format = DateTimePickerFormat.Custom;
            dtpDOB.Location = new Point(86, 64);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(274, 27);
            dtpDOB.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 242);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 11;
            label3.Text = "Mstatus : ";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(39, 36);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(86, 24);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Football";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(158, 36);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(93, 24);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Watch TV";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(39, 82);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(101, 24);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "Swimming";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(158, 82);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(124, 24);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "Body Building";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(checkBox4);
            groupBox2.Controls.Add(checkBox3);
            groupBox2.Controls.Add(checkBox2);
            groupBox2.Controls.Add(checkBox1);
            groupBox2.Location = new Point(12, 283);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(348, 124);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Habites";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 419);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 17;
            label4.Text = "English :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 477);
            label5.Name = "label5";
            label5.Size = new Size(59, 20);
            label5.TabIndex = 18;
            label5.Text = "Arabic :";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(86, 416);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(51, 27);
            numericUpDown1.TabIndex = 5;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(86, 474);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(51, 27);
            numericUpDown2.TabIndex = 6;
            numericUpDown2.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(170, 415);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(190, 29);
            progressBar1.TabIndex = 5;
            progressBar1.Tag = "";
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(170, 473);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(190, 29);
            progressBar2.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(143, 419);
            label6.Name = "label6";
            label6.Size = new Size(21, 20);
            label6.TabIndex = 23;
            label6.Text = "%";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(143, 477);
            label7.Name = "label7";
            label7.Size = new Size(21, 20);
            label7.TabIndex = 24;
            label7.Text = "%";
            // 
            // btnRepot
            // 
            btnRepot.ImageAlign = ContentAlignment.MiddleLeft;
            btnRepot.Location = new Point(95, 513);
            btnRepot.Name = "btnRepot";
            btnRepot.Size = new Size(167, 53);
            btnRepot.TabIndex = 7;
            btnRepot.Text = "Show Result";
            btnRepot.UseVisualStyleBackColor = true;
            btnRepot.Click += btnRepot_Click;
            // 
            // btnPageSetup
            // 
            btnPageSetup.Location = new Point(6, 502);
            btnPageSetup.Name = "btnPageSetup";
            btnPageSetup.Size = new Size(94, 29);
            btnPageSetup.TabIndex = 0;
            btnPageSetup.Text = "Page Setup";
            btnPageSetup.UseVisualStyleBackColor = true;
            btnPageSetup.Click += btnPageSetup_Click;
            // 
            // btnPreview
            // 
            btnPreview.Location = new Point(148, 502);
            btnPreview.Name = "btnPreview";
            btnPreview.Size = new Size(94, 29);
            btnPreview.TabIndex = 1;
            btnPreview.Text = "Preview";
            btnPreview.UseVisualStyleBackColor = true;
            btnPreview.Click += btnPreview_Click;
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(283, 502);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(94, 29);
            btnPrint.TabIndex = 2;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(rtxtRepot);
            groupBox3.Controls.Add(btnPrint);
            groupBox3.Controls.Add(btnPreview);
            groupBox3.Controls.Add(btnPageSetup);
            groupBox3.Location = new Point(366, 22);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(383, 544);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Report";
            // 
            // rtxtRepot
            // 
            rtxtRepot.Location = new Point(8, 26);
            rtxtRepot.Name = "rtxtRepot";
            rtxtRepot.Size = new Size(362, 446);
            rtxtRepot.TabIndex = 29;
            rtxtRepot.Text = "";
            // 
            // pageSetupDialog1
            // 
            pageSetupDialog1.Document = printDocument1;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printDialog1
            // 
            printDialog1.Document = printDocument1;
            printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 588);
            Controls.Add(groupBox3);
            Controls.Add(btnRepot);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(progressBar2);
            Controls.Add(progressBar1);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(groupBox2);
            Controls.Add(label3);
            Controls.Add(dtpDOB);
            Controls.Add(comboStatus);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox txtName;
        private Label label1;
        private TextBox txtbirthday;
        private RadioButton rbtnMale;
        private RadioButton rbtnFemale;
        private GroupBox groupBox1;
        private ComboBox comboStatus;
        private DateTimePicker dtpDOB;
        private Label label3;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private GroupBox groupBox2;
        private Label label4;
        private Label label5;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private ProgressBar progressBar1;
        private ProgressBar progressBar2;
        private Label label6;
        private Label label7;
        private Button btnRepot;
        private Button btnPageSetup;
        private Button btnPreview;
        private Button btnPrint;
        private GroupBox groupBox3;
        private RichTextBox rtxtRepot;
        private PageSetupDialog pageSetupDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintDialog printDialog1;
        private PrintPreviewDialog printPreviewDialog1;
    }
}
