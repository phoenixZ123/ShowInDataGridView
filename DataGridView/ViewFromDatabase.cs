using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView
{
    public partial class ViewFromDatabase : Form
    {
        public ViewFromDatabase()
        {
            InitializeComponent();
        }

        private void ViewFromDatabase_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Customer", @"Data Source=localhost;Initial Catalog=master;User ID=sa;Password=ComplexPassword123!;Connect Timeout=30;Encrypt=False;");
            DataSet ds = new DataSet();
            da.Fill(ds, "Customer");
            dataGridView1.DataSource = ds.Tables["Customer"].DefaultView;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=localhost;Initial Catalog=master;User ID=sa;Password=ComplexPassword123!;Connect Timeout=30;Encrypt=False;");
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into Student values('" + txtId.Text + "','" + txtName.Text + "','" + txtAddress.Text + "')", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("saved your information");

           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
