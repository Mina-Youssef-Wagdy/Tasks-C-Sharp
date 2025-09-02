using Microsoft.Data.SqlClient;
using System.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task_6
{
    public partial class Employee : Form
    { 
        string connection = "Data Source=ADMINISTRATOR\\SQLEXPRESS01;Initial Catalog=Task_6_DB;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        public Employee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                string query = "INSERT INTO Employees (Name, Job, Salary, Photo) VALUES (@Name, @Job, @Salary, @Photo)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Job", txtJob.Text);
                cmd.Parameters.AddWithValue("@Salary", Convert.ToDecimal(txtSalary.Text));
                cmd.Parameters.AddWithValue("@Photo", (object)ImageToByteArray(pictureBox1) ?? DBNull.Value);


                cmd.ExecuteNonQuery();
                MessageBox.Show("Saved");
                LoadData();

            }

        }
        private void LoadData()
        {
            using (SqlConnection con = new SqlConnection(connection))
            {
                string query = "SELECT * FROM Employees";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
        private byte[] ImageToByteArray(PictureBox pictureBox)
        {
            if (pictureBox.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    pictureBox.Image.Save(ms, pictureBox.Image.RawFormat);
                    return ms.ToArray();
                }
            }
            return null;
        }


        private Image ByteArrayToImage(byte[] data)
        {
            if (data == null) return null;
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {

            LoadData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                string query = "UPDATE Employees SET Name=@Name, Job=@Job, Salary=@Salary, Photo=@Photo WHERE ID=@ID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(txtID.Text));
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Job", txtJob.Text);
                cmd.Parameters.AddWithValue("@Salary", Convert.ToDecimal(txtSalary.Text));
                cmd.Parameters.AddWithValue("@Photo", (object)ImageToByteArray(pictureBox1) ?? DBNull.Value);

                cmd.ExecuteNonQuery();
                MessageBox.Show("تم التعديل بنجاح");
                LoadData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                string query = "DELETE FROM Employees WHERE ID=@ID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(txtID.Text));

                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted");
                LoadData();
            }

        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connection))
            {
                string query = "SELECT * FROM Employees WHERE Name LIKE @Search";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@Search", "%" + txtSearch.Text + "%");
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtID.Text = row.Cells["ID"].Value.ToString();
                txtName.Text = row.Cells["Name"].Value.ToString();
                txtJob.Text = row.Cells["Job"].Value.ToString();
                txtSalary.Text = row.Cells["Salary"].Value.ToString();

                if (row.Cells["Photo"].Value != DBNull.Value)
                {
                    byte[] photoData = (byte[])row.Cells["Photo"].Value;
                    pictureBox1.Image = ByteArrayToImage(photoData);
                }
                else
                {
                    pictureBox1.Image = null;
                }
            }
        }
    }
}