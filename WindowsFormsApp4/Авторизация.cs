using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace WindowsFormsApp4
{
    public partial class Авторизация : Form
    {
        public Авторизация()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=WIN-N4LAU77TVNN\SQLEXPRESS;Initial Catalog=SELHOZ;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count (*) From Авторизация where Логин = '" + textBox1.Text + "' and Пароль = '" + textBox2.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);


            if (dt.Rows[0][0].ToString() == "1")
            {
                Menu af = new Menu();
                
                af.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }

        }
    }
}
