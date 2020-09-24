namespace WindowsFormsApp4
{
    partial class Комплексы
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
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sELHOZDataSet1 = new WindowsFormsApp4.SELHOZDataSet();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.produkciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produkciaTableAdapter = new WindowsFormsApp4.SELHOZDataSetTableAdapters.ProdukciaTableAdapter();
            this.sELHOZDataSet11 = new WindowsFormsApp4.SELHOZDataSet1();
            this.kompleksBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kompleksTableAdapter1 = new WindowsFormsApp4.SELHOZDataSet1TableAdapters.KompleksTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодпродукцииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produkciaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.produkciaTableAdapter1 = new WindowsFormsApp4.SELHOZDataSet1TableAdapters.ProdukciaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sELHOZDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produkciaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sELHOZDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kompleksBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produkciaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 321);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 70;
            this.label10.Text = "Поиск";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(12, 337);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(154, 20);
            this.textBox9.TabIndex = 69;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(176, 332);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(113, 25);
            this.button6.TabIndex = 68;
            this.button6.Text = "Найти";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(295, 205);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(113, 87);
            this.button5.TabIndex = 67;
            this.button5.Text = "Сохранить изменения";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(176, 231);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 27);
            this.button4.TabIndex = 66;
            this.button4.Text = "Удалить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(176, 262);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 30);
            this.button3.TabIndex = 65;
            this.button3.Text = "Редактировать";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(176, 205);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 24);
            this.button2.TabIndex = 64;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "Тип производимой продукции";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(295, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 42);
            this.button1.TabIndex = 51;
            this.button1.Text = "Выход на панель выбора форм";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.кодпродукцииDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kompleksBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(396, 150);
            this.dataGridView1.TabIndex = 50;
            // 
            // sELHOZDataSet1
            // 
            this.sELHOZDataSet1.DataSetName = "SELHOZDataSet";
            this.sELHOZDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.produkciaBindingSource1;
            this.comboBox1.DisplayMember = "Тип_продукции";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(10, 231);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(156, 21);
            this.comboBox1.TabIndex = 71;
            this.comboBox1.ValueMember = "Тип_продукции";
            // 
            // produkciaBindingSource
            // 
            this.produkciaBindingSource.DataMember = "Produkcia";
            this.produkciaBindingSource.DataSource = this.sELHOZDataSet1;
            // 
            // produkciaTableAdapter
            // 
            this.produkciaTableAdapter.ClearBeforeFill = true;
            // 
            // sELHOZDataSet11
            // 
            this.sELHOZDataSet11.DataSetName = "SELHOZDataSet1";
            this.sELHOZDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kompleksBindingSource1
            // 
            this.kompleksBindingSource1.DataMember = "Kompleks";
            this.kompleksBindingSource1.DataSource = this.sELHOZDataSet11;
            // 
            // kompleksTableAdapter1
            // 
            this.kompleksTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Код_комплекса";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код_комплекса";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Тип_продукции";
            this.dataGridViewTextBoxColumn2.HeaderText = "Тип_продукции";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // кодпродукцииDataGridViewTextBoxColumn
            // 
            this.кодпродукцииDataGridViewTextBoxColumn.DataPropertyName = "Код_продукции";
            this.кодпродукцииDataGridViewTextBoxColumn.HeaderText = "Код_продукции";
            this.кодпродукцииDataGridViewTextBoxColumn.Name = "кодпродукцииDataGridViewTextBoxColumn";
            // 
            // produkciaBindingSource1
            // 
            this.produkciaBindingSource1.DataMember = "Produkcia";
            this.produkciaBindingSource1.DataSource = this.sELHOZDataSet11;
            // 
            // produkciaTableAdapter1
            // 
            this.produkciaTableAdapter1.ClearBeforeFill = true;
            // 
            // Комплексы
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 368);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Комплексы";
            this.Text = "Комплексы";
            this.Load += new System.EventHandler(this.Комплексы_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sELHOZDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produkciaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sELHOZDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kompleksBindingSource1)).EndInit();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private SELHOZDataSet sELHOZDataSet;
        private SELHOZDataSetTableAdapters.KompleksTableAdapter kompleksTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодкомплексаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn типпродукцииDataGridViewTextBoxColumn;
        private SELHOZDataSet sELHOZDataSet1;
        private System.Windows.Forms.BindingSource produkciaBindingSource;
        private SELHOZDataSetTableAdapters.ProdukciaTableAdapter produkciaTableAdapter;
        private SELHOZDataSet1 sELHOZDataSet11;
        private System.Windows.Forms.BindingSource kompleksBindingSource1;
        private SELHOZDataSet1TableAdapters.KompleksTableAdapter kompleksTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодпродукцииDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource produkciaBindingSource1;
        private SELHOZDataSet1TableAdapters.ProdukciaTableAdapter produkciaTableAdapter1;
    }
}