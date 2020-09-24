using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Сотрудники fm = new Сотрудники();
            fm.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Продукция fm = new Продукция();
            fm.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Конторы fm = new Конторы();
            fm.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Комплексы fm = new Комплексы();
            fm.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Авторизация fm = new Авторизация();
            fm.Show();
            this.Close();
        }
    }
}
