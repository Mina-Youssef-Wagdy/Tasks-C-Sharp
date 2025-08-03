namespace Task_Day_5
{
    partial class Application
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Application));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            rbtnFemale = new RadioButton();
            rbtnMale = new RadioButton();
            txtName = new TextBox();
            DTpDOB = new DateTimePicker();
            combstatus = new ComboBox();
            Habites = new GroupBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            label5 = new Label();
            NUDArabic = new NumericUpDown();
            proArabic = new ProgressBar();
            NUDEnglish = new NumericUpDown();
            proEnglish = new ProgressBar();
            label6 = new Label();
            label7 = new Label();
            btnReport1 = new Button();
            groupBox2 = new GroupBox();
            btnPreview = new Button();
            btnPrint = new Button();
            btnPageSetup = new Button();
            RtxtReport = new RichTextBox();
            pageSetupDialog1 = new PageSetupDialog();
            printDialog1 = new PrintDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            groupBox1.SuspendLayout();
            Habites.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NUDArabic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUDEnglish).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 36);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 0;
            label1.Text = "Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 69);
            label2.Name = "label2";
            label2.Size = new Size(103, 20);
            label2.TabIndex = 1;
            label2.Text = "Date Of Birth :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 214);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 2;
            label3.Text = "Mstatus : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 401);
            label4.Name = "label4";
            label4.Size = new Size(59, 20);
            label4.TabIndex = 3;
            label4.Text = "Arabic :";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbtnFemale);
            groupBox1.Controls.Add(rbtnMale);
            groupBox1.Location = new Point(43, 120);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(310, 84);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gender";
            // 
            // rbtnFemale
            // 
            rbtnFemale.AutoSize = true;
            rbtnFemale.Location = new Point(139, 42);
            rbtnFemale.Name = "rbtnFemale";
            rbtnFemale.Size = new Size(78, 24);
            rbtnFemale.TabIndex = 1;
            rbtnFemale.TabStop = true;
            rbtnFemale.Text = "Female";
            rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // rbtnMale
            // 
            rbtnMale.AutoSize = true;
            rbtnMale.Location = new Point(11, 42);
            rbtnMale.Name = "rbtnMale";
            rbtnMale.Size = new Size(63, 24);
            rbtnMale.TabIndex = 0;
            rbtnMale.TabStop = true;
            rbtnMale.Text = "Male";
            rbtnMale.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            txtName.Location = new Point(152, 33);
            txtName.Name = "txtName";
            txtName.Size = new Size(201, 27);
            txtName.TabIndex = 5;
            // 
            // DTpDOB
            // 
            DTpDOB.CustomFormat = "yyyyMMdd";
            DTpDOB.Format = DateTimePickerFormat.Custom;
            DTpDOB.Location = new Point(152, 66);
            DTpDOB.Name = "DTpDOB";
            DTpDOB.Size = new Size(201, 27);
            DTpDOB.TabIndex = 6;
            // 
            // combstatus
            // 
            combstatus.FormattingEnabled = true;
            combstatus.Items.AddRange(new object[] { "متزوج", "أعزب", "ارمل", "مطلق" });
            combstatus.Location = new Point(152, 210);
            combstatus.Name = "combstatus";
            combstatus.Size = new Size(201, 28);
            combstatus.TabIndex = 7;
            // 
            // Habites
            // 
            Habites.Controls.Add(checkBox4);
            Habites.Controls.Add(checkBox3);
            Habites.Controls.Add(checkBox2);
            Habites.Controls.Add(checkBox1);
            Habites.Location = new Point(43, 243);
            Habites.Name = "Habites";
            Habites.Size = new Size(310, 132);
            Habites.TabIndex = 8;
            Habites.TabStop = false;
            Habites.Text = "Habites";
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(159, 86);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(124, 24);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "Body Building";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(159, 41);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(93, 24);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "Watch TV";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(15, 86);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(101, 24);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Swimming";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(15, 41);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(86, 24);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "FootBall";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(51, 460);
            label5.Name = "label5";
            label5.Size = new Size(63, 20);
            label5.TabIndex = 9;
            label5.Text = "English :";
            // 
            // NUDArabic
            // 
            NUDArabic.Location = new Point(122, 398);
            NUDArabic.Name = "NUDArabic";
            NUDArabic.Size = new Size(46, 27);
            NUDArabic.TabIndex = 10;
            // 
            // proArabic
            // 
            proArabic.Location = new Point(195, 397);
            proArabic.Name = "proArabic";
            proArabic.Size = new Size(158, 29);
            proArabic.TabIndex = 11;
            // 
            // NUDEnglish
            // 
            NUDEnglish.Location = new Point(124, 457);
            NUDEnglish.Name = "NUDEnglish";
            NUDEnglish.Size = new Size(44, 27);
            NUDEnglish.TabIndex = 12;
            // 
            // proEnglish
            // 
            proEnglish.Location = new Point(196, 456);
            proEnglish.Name = "proEnglish";
            proEnglish.Size = new Size(157, 29);
            proEnglish.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(174, 459);
            label6.Name = "label6";
            label6.Size = new Size(21, 20);
            label6.TabIndex = 14;
            label6.Text = "%";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(174, 401);
            label7.Name = "label7";
            label7.Size = new Size(21, 20);
            label7.TabIndex = 15;
            label7.Text = "%";
            // 
            // btnReport1
            // 
            btnReport1.BackColor = Color.FromArgb(0, 192, 192);
            btnReport1.ForeColor = Color.Green;
            btnReport1.Image = Properties.Resources.table;
            btnReport1.ImageAlign = ContentAlignment.MiddleLeft;
            btnReport1.Location = new Point(75, 505);
            btnReport1.Name = "btnReport1";
            btnReport1.Size = new Size(220, 67);
            btnReport1.TabIndex = 16;
            btnReport1.Text = "Show Result";
            btnReport1.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.LightSalmon;
            groupBox2.Controls.Add(RtxtReport);
            groupBox2.Controls.Add(btnPreview);
            groupBox2.Controls.Add(btnPrint);
            groupBox2.Controls.Add(btnPageSetup);
            groupBox2.Location = new Point(391, 27);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(394, 553);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "Repot";
            // 
            // btnPreview
            // 
            btnPreview.Location = new Point(153, 497);
            btnPreview.Name = "btnPreview";
            btnPreview.Size = new Size(94, 29);
            btnPreview.TabIndex = 3;
            btnPreview.Text = "Preview";
            btnPreview.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(276, 497);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(94, 29);
            btnPrint.TabIndex = 2;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnPageSetup
            // 
            btnPageSetup.Location = new Point(35, 497);
            btnPageSetup.Name = "btnPageSetup";
            btnPageSetup.Size = new Size(94, 29);
            btnPageSetup.TabIndex = 0;
            btnPageSetup.Text = "Page Setup";
            btnPageSetup.UseVisualStyleBackColor = true;
            // 
            // RtxtReport
            // 
            RtxtReport.Location = new Point(6, 26);
            RtxtReport.Name = "RtxtReport";
            RtxtReport.Size = new Size(380, 465);
            RtxtReport.TabIndex = 4;
            RtxtReport.Text = "";
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // Application
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 595);
            Controls.Add(groupBox2);
            Controls.Add(btnReport1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(proEnglish);
            Controls.Add(NUDEnglish);
            Controls.Add(proArabic);
            Controls.Add(NUDArabic);
            Controls.Add(label5);
            Controls.Add(Habites);
            Controls.Add(combstatus);
            Controls.Add(DTpDOB);
            Controls.Add(txtName);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.Black;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Application";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Application";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            Habites.ResumeLayout(false);
            Habites.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NUDArabic).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUDEnglish).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox groupBox1;
        private RadioButton rbtnFemale;
        private RadioButton rbtnMale;
        private TextBox txtName;
        private DateTimePicker DTpDOB;
        private ComboBox combstatus;
        private GroupBox Habites;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Label label5;
        private NumericUpDown NUDArabic;
        private ProgressBar proArabic;
        private NumericUpDown NUDEnglish;
        private ProgressBar proEnglish;
        private Label label6;
        private Label label7;
        private Button btnReport1;
        private GroupBox groupBox2;
        private Button btnPageSetup;
        private Button btnPreview;
        private Button btnPrint;
        private RichTextBox RtxtReport;
        private PageSetupDialog pageSetupDialog1;
        private PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
    }
}
