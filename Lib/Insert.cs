using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lib
{
    public partial class Insert : Form
    {
        private SqlConnection sqlConnection = null;
        public Insert()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Не указано имя автора!");
            }
            if (textBox2.Text.Length == 0)
            {
                MessageBox.Show("Не указано фамилия автора!");

            }
            if ((textBox1.Text.Length > 0) && (textBox2.Text.Length > 0))
            {
                SqlCommand cmd = new SqlCommand($"INSERT INTO[Authors](FName, SName) VALUES(@Fname,@Sname)", sqlConnection);

                cmd.Parameters.AddWithValue("Fname", textBox1.Text);
                cmd.Parameters.AddWithValue("Sname", textBox2.Text);
                cmd.ExecuteNonQuery();


            }
        }

        private void Insert_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["CSDB"].ConnectionString);
            sqlConnection.Open();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
