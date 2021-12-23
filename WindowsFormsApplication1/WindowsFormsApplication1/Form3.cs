using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
       
        public Form3()
        {
            InitializeComponent();
        }


        private void btn_Registr_Click(object sender, EventArgs e)
        {
            string strCon = @"Data Source=(LocalDB)\MSSQLLocalDB;
AttachDbFilename=D:\Chubarov_36\WindowsFormsApplication1\WindowsFormsApplication1\Database1.mdf;
Integrated Security=True";

            SqlConnection sqlCon = new SqlConnection(strCon);
            sqlCon.Open();

            string strQueryNew = $"INSERT INTO TableUsersN  (Login, Pass, Role) Values ('" + TXt_regLogin.Text + $"', '{TXt_regPass.Text}', '0')";

            SqlCommand QueryNew = new SqlCommand(strQueryNew, sqlCon);

            try
            {
                QueryNew.ExecuteNonQuery();
                richTBRegists.Text = QueryNew.CommandText;
            }
            catch
            {
                richTBRegists.Text = "Ошибка в команде: " + strQueryNew;
            }
            sqlCon.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frmMAin = new Form1();
            frmMAin.Show();
            this.Hide();
        }
    }
}
