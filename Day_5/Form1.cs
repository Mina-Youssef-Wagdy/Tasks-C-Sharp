namespace Day_5
{
    public partial class Form1 : Form
    {
        string Name;
        string DOB;
        string Gender;
        string Status;
        string Habites;
        string English;
        string Arabic;
        public Form1()
        {
            InitializeComponent();
        }


        private void btnRepot_Click(object sender, EventArgs e)
        {
            Name = txtName.Text;
            DOB = dtpDOB.Value.ToShortDateString();
            Status = comboStatus.Text;
            if (rbtnMale.Checked)
                Gender = "Male";
            else
                Gender = "Female";

            Habites = string.Empty;
            if (checkBox1.Checked)
                Habites += checkBox1.Text + "  ";
            if (checkBox2.Checked)
                Habites += checkBox2.Text + "  ";
            if (checkBox3.Checked)
                Habites += checkBox3.Text + "  ";
            if (checkBox4.Checked)
                Habites += checkBox4.Text + "  ";

            English = progressBar1.Value.ToString();

            Arabic = progressBar2.Value.ToString();


            rtxtRepot.Text = string.Format("-------------------Your Information-------------------\nName : {0}\nDOB : {1}\nStatus : {2}\nGender : {3}\nHabites : {4} \nEnglish :{5}\nArabic :{6}\n--------------------------END--------------------------", Name, DOB, Status, Gender, Habites, English, Arabic);

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            progressBar1.Value = (int)numericUpDown1.Value;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            progressBar2.Value = (int)numericUpDown2.Value;
        }

        private void btnPageSetup_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(rtxtRepot.Text, new Font("Tahoma", 16), Brushes.Blue, 10, 10);
        }


        }
    }

