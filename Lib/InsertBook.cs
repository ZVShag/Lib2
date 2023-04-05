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
    public partial class InsertBook : Form
    {
        private SqlConnection sqlConnection = null;
        public InsertBook()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Не указано название книги!");
            }
            if (textBox2.Text.Length == 0)
            {
                MessageBox.Show("Не указано фамилия автора!");

            }
            if (textBox3.Text.Length == 0)
            {
                MessageBox.Show("Не указано количество страниц!");
            }
            if (textBox2.Text.Length == 0)
            {
                MessageBox.Show("Не указано стоимость книги!");

            }
            if ((textBox1.Text.Length > 0) && (textBox2.Text.Length > 0)&& (textBox3.Text.Length > 0) && (textBox4.Text.Length > 0))
            {
                SqlCommand cmd = new SqlCommand($"INSERT INTO[Books](AuthorId,Title,Price,Page) VALUES(@Authorid,@Title,@Price,@Page)", sqlConnection);

                cmd.Parameters.AddWithValue("Authorid", Int32.Parse(textBox1.Text));
                cmd.Parameters.AddWithValue("Title", textBox2.Text);
                cmd.Parameters.AddWithValue("Price", Int32.Parse(textBox3.Text));
                cmd.Parameters.AddWithValue("Page", Int32.Parse(textBox4.Text));
                cmd.ExecuteNonQuery();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                MessageBox.Show("Запись успешно добавлена!");
            }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void InsertBook_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["CSDB"].ConnectionString);
            sqlConnection.Open();
        }
    }
}
