using System.Configuration;
using System.Data.SqlClient;


namespace Lib
{
    public partial class Form1 : Form
    {
        private SqlConnection sqlConnection=null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["CSDB"].ConnectionString);
            sqlConnection.Open();
            if (sqlConnection.State==System.Data.ConnectionState.Open) 
            {
                MessageBox.Show("База данных подключена!");
            }
            sqlConnection.Close();

        }
    }
}