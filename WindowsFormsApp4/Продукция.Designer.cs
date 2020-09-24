namespace WindowsFormsApp4
{
    partial class Продукция
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produkciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sELHOZDataSet2 = new WindowsFormsApp4.SELHOZDataSet();
            this.produkciaTableAdapter2 = new WindowsFormsApp4.SELHOZDataSetTableAdapters.ProdukciaTableAdapter();
            this.sELHOZDataSet11 = new WindowsFormsApp4.SELHOZDataSet1();
            this.produkciaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.produkciaTableAdapter3 = new WindowsFormsApp4.SELHOZDataSet1TableAdapters.ProdukciaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produkciaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sELHOZDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sELHOZDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produkciaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(41, 310);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 83;
            this.label10.Text = "Поиск";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(44, 326);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(122, 20);
            this.textBox9.TabIndex = 82;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(176, 321);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(113, 25);
            this.button6.TabIndex = 81;
            this.button6.Text = "Найти";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(295, 194);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(113, 87);
            this.button5.TabIndex = 80;
            this.button5.Text = "Сохранить изменения";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(176, 220);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 27);
            this.button4.TabIndex = 79;
            this.button4.Text = "Удалить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(176, 251);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 30);
            this.button3.TabIndex = 78;
            this.button3.Text = "Редактировать";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(176, 194);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 24);
            this.button2.TabIndex = 77;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 197);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 20);
            this.textBox1.TabIndex = 74;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 73;
            this.label1.Text = "Тип продукции";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(295, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 42);
            this.button1.TabIndex = 72;
            this.button1.Text = "Выход на панель выбора форм";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView1.DataSource = this.produkciaBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(10, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(398, 150);
            this.dataGridView1.TabIndex = 84;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Код_продукции";
            this.dataGridViewTextBoxColumn3.HeaderText = "Код продукции";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Тип_продукции";
            this.dataGridViewTextBoxColumn4.HeaderText = "Тип продукции";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // produkciaBindingSource
            // 
            this.produkciaBindingSource.DataMember = "Produkcia";
            this.produkciaBindingSource.DataSource = this.sELHOZDataSet2;
            // 
            // sELHOZDataSet2
            // 
            this.sELHOZDataSet2.DataSetName = "SELHOZDataSet";
            this.sELHOZDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produkciaTableAdapter2
            // 
            this.produkciaTableAdapter2.ClearBeforeFill = true;
            // 
            // sELHOZDataSet11
            // 
            this.sELHOZDataSet11.DataSetName = "SELHOZDataSet1";
            this.sELHOZDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produkciaBindingSource1
            // 
            this.produkciaBindingSource1.DataMember = "Produkcia";
            this.produkciaBindingSource1.DataSource = this.sELHOZDataSet11;
            // 
            // produkciaTableAdapter3
            // 
            this.produkciaTableAdapter3.ClearBeforeFill = true;
            // 
            // Продукция
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 366);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Продукция";
            this.Text = "Продукция";
            this.Load += new System.EventHandler(this.Продукция_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produkciaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sELHOZDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sELHOZDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produkciaBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn категорияDataGridViewTextBoxColumn;
        private SELHOZDataSet sELHOZDataSet;
        private SELHOZDataSetTableAdapters.ProdukciaTableAdapter produkciaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодпродукцииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn типпродукцииDataGridViewTextBoxColumn;
        private SELHOZDataSet sELHOZDataSet1;
        private SELHOZDataSetTableAdapters.ProdukciaTableAdapter produkciaTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SELHOZDataSet sELHOZDataSet2;
        private System.Windows.Forms.BindingSource produkciaBindingSource;
        private SELHOZDataSetTableAdapters.ProdukciaTableAdapter produkciaTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private SELHOZDataSet1 sELHOZDataSet11;
        private System.Windows.Forms.BindingSource produkciaBindingSource1;
        private SELHOZDataSet1TableAdapters.ProdukciaTableAdapter produkciaTableAdapter3;
    }
}