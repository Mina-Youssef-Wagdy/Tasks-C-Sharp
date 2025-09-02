using System.Transactions;

namespace Task_Day_5
{
    public partial class Application : Form
    {
        #region Var
        String Name;
        String DOB;
        String Gender;
        String Status;
        String Hab;
        String Arabic;
        String English;
        #endregion
        public Application()
        {
            InitializeComponent();
        }

        private void btnReport1_Click(object sender, EventArgs e)
        {
            Name = txtName.Text;
            DOB = DTpDOB.Value.ToShortDateString();
            Status = combstatus.Text;
            if (rbtnMale.Checked)
                Gender = "Male";
            else
                Gender = "Female";

            Hab = string.Empty;
            if (checkBox1.Checked)
            {
                Hab += checkBox1.Text + "  ";
            }
            if (checkBox2.Checked)
            {
                Hab += checkBox2.Text + "  ";
            }
            if (checkBox3.Checked)
            {
                Hab += checkBox3.Text + "  ";
            }
            if (checkBox4.Checked)
            {
                Hab += checkBox4.Text + "  ";
            }
            Arabic = proArabic.Value.ToString();
            English = proEnglish.Value.ToString();

            RtxtReport.Text = string.Format("---------------------Your Information---------------------\nName : {0}\nDOB : {1}\nStatus : {2}\nGender : {3}\nHabites : {4}\nArabic : {5} %\nEnglish : {6} %", Name, DOB, Status, Gender, Hab, Arabic, English);
        }

        private void NUDArabic_ValueChanged(object sender, EventArgs e)
        {
            proArabic.Value = (int)NUDArabic.Value;
        }

        private void NUDEnglish_ValueChanged(object sender, EventArgs e)
        {
            proEnglish.Value = (int)NUDEnglish.Value;
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
            e.Graphics.DrawString(RtxtReport.Text, new Font("Tahoma", 16), Brushes.Blue, 10, 10);
        }

        private void Application_Load(object sender, EventArgs e)
        {

        }

        private void RtxtReport_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

