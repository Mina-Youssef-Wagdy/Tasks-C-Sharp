using Microsoft.Data.SqlClient;
using System.Data;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task_6
{
    public partial class Employee : Form
    {
        string connection = "Data Source=ADMINISTRATOR\\SQLEXPRESS01;Initial Catalog=Task_6_DB;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        public Employee()
        {
            InitializeComponent();
            this.Load += Employee_Load;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;

            this.FormClosed += Employee_FormClosed;
        }
        private void Employee_Load(object? sender, EventArgs e)
        {
            LoadNamesToComboBox();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                using (SqlConnection con = new SqlConnection(connection))
                {
                    con.Open();
                    string query = "INSERT INTO Employees (Name, Job, Salary, Photo) VALUES (@Name, @Job, @Salary, @Photo)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Name", txtName.Text);
                    cmd.Parameters.AddWithValue("@Job", txtJob.Text);
                    if (!decimal.TryParse(txtSalary.Text, out decimal salary))
                    {
                        MessageBox.Show("The salary must be in numbers ");
                        return;
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Salary", Convert.ToDecimal(txtSalary.Text));
                    }
                    cmd.Parameters.AddWithValue("@Photo", (object?)ImageToByteArray(pictureBox1) ?? DBNull.Value);


                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Saved");
                    LoadData();
                    LoadNamesToComboBox();

                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }


        }
        private void LoadData()

        {
            try
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
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        private byte[]? ImageToByteArray(PictureBox pictureBox)
        {
            if (pictureBox.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    pictureBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    return ms.ToArray();
                }
            }
            return null;
        }


        private Image? ByteArrayToImage(byte[]? data)
        {
            if (data == null) return new Bitmap(1, 1); ;
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    using (var fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read))
                    {
                        pictureBox1.Image = Image.FromStream(fs);
                        using (Image temp = Image.FromStream(fs))
                            pictureBox1.Image = new Bitmap(temp);
                        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

                    }
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

        }

        private void btnShow_Click(object sender, EventArgs e)
        {

            LoadData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtID.Text))
                {
                    MessageBox.Show("Enter the employee ID to edit.");
                    return;
                }
                using (SqlConnection con = new SqlConnection(connection))
                {
                    con.Open();
                    string query = "UPDATE Employees SET Name=@Name, Job=@Job, Salary=@Salary, Photo=@Photo WHERE ID=@ID";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(txtID.Text));
                    cmd.Parameters.AddWithValue("@Name", txtName.Text);
                    cmd.Parameters.AddWithValue("@Job", txtJob.Text);
                    cmd.Parameters.AddWithValue("@Salary", Convert.ToDecimal(txtSalary.Text));
                    cmd.Parameters.AddWithValue("@Photo", (object?)ImageToByteArray(pictureBox1) ?? DBNull.Value);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("edit successfully");
                    LoadData();
                    LoadNamesToComboBox();
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void btnDelete_Click(object sender, EventArgs e)

        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtID.Text))
                {
                    MessageBox.Show("Enter the employee ID to delete.");
                    return;
                }
                using (SqlConnection con = new SqlConnection(connection))
                {
                    con.Open();
                    string query = "DELETE FROM Employees WHERE ID=@ID";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(txtID.Text));

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deleted");
                    LoadData();
                    LoadNamesToComboBox();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connection))
                {
                    string query = "SELECT ID, [Name], Job, Salary FROM Employees WHERE [Name] LIKE @Search";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    da.SelectCommand.Parameters.AddWithValue("@Search", "%" + txtSearch.Text + "%");
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtID.Text = row.Cells["ID"].Value?.ToString() ?? string.Empty;
                txtName.Text = row.Cells["Name"].Value?.ToString() ?? string.Empty;
                txtJob.Text = row.Cells["Job"].Value?.ToString() ?? string.Empty;
                txtSalary.Text = row.Cells["Salary"].Value?.ToString() ?? string.Empty;

                if (row.Cells["Photo"].Value != DBNull.Value)
                {
                    byte[]? photoData = (byte[]?)row.Cells["Photo"].Value;
                    pictureBox1.Image = ByteArrayToImage(photoData);
                }
                else
                {
                    pictureBox1.Image = null;
                }
            }
        }

        private void LoadNamesToComboBox()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connection))
                {
                    string query = "SELECT ID, Name FROM Employees";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    comboBox1.DisplayMember = "Name";
                    comboBox1.ValueMember = "ID";
                    comboBox1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void comboBox1_SelectedIndexChanged(object?  sender, EventArgs e)
        {
            if (comboBox1.SelectedValue != null)
            {
                int selectedId = Convert.ToInt32(comboBox1.SelectedValue);

                using (SqlConnection con = new SqlConnection(connection))
                {
                    string query = "SELECT * FROM Employees WHERE ID=@ID";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@ID", selectedId);

                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txtID.Text = reader["ID"].ToString();
                        txtName.Text = reader["Name"].ToString();
                        txtJob.Text = reader["Job"].ToString();
                        txtSalary.Text = reader["Salary"].ToString();

                        if (reader["Photo"] != DBNull.Value)
                        {
                            byte[] photoData = (byte[])reader["Photo"];
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




        private void Employee_FormClosed(object? sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}