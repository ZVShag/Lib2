using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;



namespace Lib
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        /*private void button1_Click(object sender, EventArgs e)
        //{
            Insert inauthor = new Insert();
            inauthor.Show();
            this.Hide();
        }
        */
        private void button2_Click(object sender, EventArgs e)
        {
            InsertBook ibook = new InsertBook();
            ibook.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Insert inauthor = new Insert();
            inauthor.Show();
            this.Hide();

        }
    }
}