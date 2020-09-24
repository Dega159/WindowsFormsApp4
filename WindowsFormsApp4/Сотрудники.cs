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
    public partial class Сотрудники : Form
    {
        public Сотрудники()
        {
            InitializeComponent();
        }
        int n;
        private void button2_Click(object sender, EventArgs e)
        {
            SELHOZDataSet.SotrudnikiRow nrow = (SELHOZDataSet.SotrudnikiRow)sELHOZDataSet.Sotrudniki.NewRow();
            nrow.Фамилия = textBox1.Text;
            nrow.Имя = textBox2.Text;
            nrow.Отчество = textBox3.Text;
            nrow.Телефон = textBox4.Text;
            nrow.Должность = textBox5.Text;
            nrow.Контора = comboBox1.Text;

            sELHOZDataSet.Sotrudniki.AddSotrudnikiRow(nrow);
        }

        private void Сотрудники_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sELHOZDataSet1.Kontora". При необходимости она может быть перемещена или удалена.
            this.kontoraTableAdapter1.Fill(this.sELHOZDataSet1.Kontora);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sELHOZDataSet1.Sotrudniki". При необходимости она может быть перемещена или удалена.
            this.sotrudnikiTableAdapter1.Fill(this.sELHOZDataSet1.Sotrudniki);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sELHOZDataSet.Kontora". При необходимости она может быть перемещена или удалена.
            //this.kontoraTableAdapter.Fill(this.sELHOZDataSet.Kontora);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sELHOZDataSet.Sotrudniki". При необходимости она может быть перемещена или удалена.
            //this.sotrudnikiTableAdapter.Fill(this.sELHOZDataSet.Sotrudniki);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "sELHOZDataSet.Sotrudniki". При необходимости она может быть перемещена или удалена.
            //this.sotrudnikiTableAdapter.Fill(this.sELHOZDataSet.Sotrudniki);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Подтвердите действие", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                int a = dataGridView1.CurrentRow.Index;
                dataGridView1.Rows.Remove(dataGridView1.Rows[a]);
            }
            else
            {
                MessageBox.Show("Отменено");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataGridViewRow dgn = dataGridView1.Rows[n];
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dgn.Cells[1].Value = textBox1.Text;
                dgn.Cells[2].Value = textBox2.Text;
                dgn.Cells[3].Value = textBox3.Text;
                dgn.Cells[4].Value = textBox4.Text;
                dgn.Cells[5].Value = textBox5.Text;
                dgn.Cells[6].Value = comboBox1.Text;
                
                this.Validate();
                this.sotrudnikiBindingSource.EndEdit();
            }
            else
            {
                MessageBox.Show("Выберите строку для редактирования.", "Ошибка.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sotrudnikiTableAdapter1.Update(sELHOZDataSet1);
        }

        private void button6_Click(object sender, EventArgs e)
        {

            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    dataGridView1.Rows[i].Selected = false;
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                        if (dataGridView1.Rows[i].Cells[j].Value != null)
                            if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBox9.Text))
                            {
                                dataGridView1.Rows[i].Selected = true;
                                break;
                            }

                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Menu fm2 = new Menu();
            this.Hide();
            fm2.Show();
        }
    }
}
