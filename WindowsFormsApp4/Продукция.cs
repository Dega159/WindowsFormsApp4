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
    public partial class Продукция : Form
    {
        public Продукция()
        {
            InitializeComponent();
        }
        int n;
        private void button2_Click(object sender, EventArgs e)
        {
            SELHOZDataSet.ProdukciaRow nrow = (SELHOZDataSet.ProdukciaRow)sELHOZDataSet.Produkcia.NewRow();
            nrow.Тип_продукции = textBox1.Text;
            
        }

        private void Продукция_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sELHOZDataSet11.Produkcia". При необходимости она может быть перемещена или удалена.
            this.produkciaTableAdapter3.Fill(this.sELHOZDataSet11.Produkcia);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sELHOZDataSet2.Produkcia". При необходимости она может быть перемещена или удалена.
            //this.produkciaTableAdapter2.Fill(this.sELHOZDataSet2.Produkcia);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sELHOZDataSet1.Produkcia". При необходимости она может быть перемещена или удалена.
            //this.produkciaTableAdapter1.Fill(this.sELHOZDataSet1.Produkcia);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sELHOZDataSet.Produkcia". При необходимости она может быть перемещена или удалена.
            //this.produkciaTableAdapter.Fill(this.sELHOZDataSet.Produkcia);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "sELHOZDataSet.Produkcia". При необходимости она может быть перемещена или удалена.
            //this.produkciaTableAdapter.Fill(this.sELHOZDataSet.Produkcia);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "sELHOZDataSet.Produkcia". При необходимости она может быть перемещена или удалена.
            //this.produkciaTableAdapter.Fill(this.sELHOZDataSet.Produkcia);

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


                this.Validate();
                this.produkciaBindingSource.EndEdit();
            }
            else
            {
                MessageBox.Show("Выберите строку для редактирования.", "Ошибка.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            produkciaTableAdapter1.Update(sELHOZDataSet2);
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

        private void button1_Click(object sender, EventArgs e)
        {
            Menu fm2 = new Menu();
            this.Hide();
            fm2.Show();
        }
    }
}
