using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void btn1Enter_Click(object sender, EventArgs e)
        {
            bindingSource1.Filter = "Login='" + txtboxLogin.Text + "'";
            //bindingSource1.Filter = "Pass='" + txtboxPassword.Text + "'";

            if (txtboxPassword.Text == Apas.Text.ToString())
            {
                Form2 frmMAin = new Form2();
                frmMAin.Show();

            }
            else
            {
                MessageBox.Show("Неправильно введен Логин или Пароль!");
            }
           
        }

        private void btn2Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtboxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn3Registration_Click(object sender, EventArgs e)
        {
            Form3 frmMAin = new Form3();
            frmMAin.Show();
            this.Hide();
            
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet1.TableUsersN". При необходимости она может быть перемещена или удалена.
            this.tableUsersNTableAdapter.Fill(this.database1DataSet1.TableUsersN);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet1.TableUsersN". При необходимости она может быть перемещена или удалена.
            this.tableUsersNTableAdapter.Fill(this.database1DataSet1.TableUsersN);
            // TODO: This line of code loads data into the 'database1DataSet1.TableUsersN' table. You can move, or remove it, as needed.
            this.tableUsersNTableAdapter.Fill(this.database1DataSet1.TableUsersN);
            // TODO: This line of code loads data into the 'database1DataSet.Авторизация' table. You can move, or remove it, as needed.
            this.tableUsersNTableAdapter.Fill(this.database1DataSet1.TableUsersN);
            // TODO: This line of code loads data into the 'database1DataSet.Авторизация' table. You can move, or remove it, as needed.
            this.tableUsersNTableAdapter.Fill(this.database1DataSet1.TableUsersN);

        }
    }
}
