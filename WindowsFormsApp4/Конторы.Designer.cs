namespace WindowsFormsApp4
{
    partial class Конторы
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
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодконторыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.комплексDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.предприятиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kontoraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sELHOZDataSet = new WindowsFormsApp4.SELHOZDataSet();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.kompleksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.kontoraTableAdapter = new WindowsFormsApp4.SELHOZDataSetTableAdapters.KontoraTableAdapter();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.kompleksTableAdapter = new WindowsFormsApp4.SELHOZDataSetTableAdapters.KompleksTableAdapter();
            this.sELHOZDataSet1 = new WindowsFormsApp4.SELHOZDataSet1();
            this.kompleksBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kompleksTableAdapter1 = new WindowsFormsApp4.SELHOZDataSet1TableAdapters.KompleksTableAdapter();
            this.kontoraBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kontoraTableAdapter1 = new WindowsFormsApp4.SELHOZDataSet1TableAdapters.KontoraTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kontoraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sELHOZDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kompleksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sELHOZDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kompleksBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kontoraBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(148, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Комплекс";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Предприятие";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 267);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Телефон";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 218);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Адрес";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодконторыDataGridViewTextBoxColumn,
            this.адресDataGridViewTextBoxColumn,
            this.телефонDataGridViewTextBoxColumn,
            this.комплексDataGridViewTextBoxColumn,
            this.предприятиеDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kontoraBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(508, 150);
            this.dataGridView1.TabIndex = 26;
            // 
            // кодконторыDataGridViewTextBoxColumn
            // 
            this.кодконторыDataGridViewTextBoxColumn.DataPropertyName = "Код_конторы";
            this.кодконторыDataGridViewTextBoxColumn.HeaderText = "Код конторы";
            this.кодконторыDataGridViewTextBoxColumn.Name = "кодконторыDataGridViewTextBoxColumn";
            this.кодконторыDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // адресDataGridViewTextBoxColumn
            // 
            this.адресDataGridViewTextBoxColumn.DataPropertyName = "Адрес";
            this.адресDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.адресDataGridViewTextBoxColumn.Name = "адресDataGridViewTextBoxColumn";
            // 
            // телефонDataGridViewTextBoxColumn
            // 
            this.телефонDataGridViewTextBoxColumn.DataPropertyName = "Телефон";
            this.телефонDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.телефонDataGridViewTextBoxColumn.Name = "телефонDataGridViewTextBoxColumn";
            // 
            // комплексDataGridViewTextBoxColumn
            // 
            this.комплексDataGridViewTextBoxColumn.DataPropertyName = "Комплекс";
            this.комплексDataGridViewTextBoxColumn.HeaderText = "Комплекс";
            this.комплексDataGridViewTextBoxColumn.Name = "комплексDataGridViewTextBoxColumn";
            // 
            // предприятиеDataGridViewTextBoxColumn
            // 
            this.предприятиеDataGridViewTextBoxColumn.DataPropertyName = "Предприятие";
            this.предприятиеDataGridViewTextBoxColumn.HeaderText = "Предприятие";
            this.предприятиеDataGridViewTextBoxColumn.Name = "предприятиеDataGridViewTextBoxColumn";
            // 
            // kontoraBindingSource
            // 
            this.kontoraBindingSource.DataMember = "Kontora";
            this.kontoraBindingSource.DataSource = this.sELHOZDataSet;
            // 
            // sELHOZDataSet
            // 
            this.sELHOZDataSet.DataSetName = "SELHOZDataSet";
            this.sELHOZDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(148, 251);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 49;
            this.label10.Text = "Поиск";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(151, 267);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(121, 20);
            this.textBox9.TabIndex = 48;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.kompleksBindingSource1;
            this.comboBox2.DisplayMember = "Тип_продукции";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(151, 217);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 51;
            this.comboBox2.ValueMember = "Тип_продукции";
            // 
            // kompleksBindingSource
            // 
            this.kompleksBindingSource.DataMember = "Kompleks";
            this.kompleksBindingSource.DataSource = this.sELHOZDataSet;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(288, 345);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(113, 25);
            this.button6.TabIndex = 87;
            this.button6.Text = "Найти";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(407, 218);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(113, 87);
            this.button5.TabIndex = 86;
            this.button5.Text = "Сохранить изменения";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(288, 244);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 27);
            this.button4.TabIndex = 85;
            this.button4.Text = "Удалить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(288, 275);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 30);
            this.button3.TabIndex = 84;
            this.button3.Text = "Редактировать";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(288, 218);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 24);
            this.button2.TabIndex = 83;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(407, 334);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(113, 42);
            this.button7.TabIndex = 82;
            this.button7.Text = "Выход на панель выбора форм";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // kontoraTableAdapter
            // 
            this.kontoraTableAdapter.ClearBeforeFill = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 316);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 20);
            this.textBox3.TabIndex = 88;
            // 
            // kompleksTableAdapter
            // 
            this.kompleksTableAdapter.ClearBeforeFill = true;
            // 
            // sELHOZDataSet1
            // 
            this.sELHOZDataSet1.DataSetName = "SELHOZDataSet1";
            this.sELHOZDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kompleksBindingSource1
            // 
            this.kompleksBindingSource1.DataMember = "Kompleks";
            this.kompleksBindingSource1.DataSource = this.sELHOZDataSet1;
            // 
            // kompleksTableAdapter1
            // 
            this.kompleksTableAdapter1.ClearBeforeFill = true;
            // 
            // kontoraBindingSource1
            // 
            this.kontoraBindingSource1.DataMember = "Kontora";
            this.kontoraBindingSource1.DataSource = this.sELHOZDataSet1;
            // 
            // kontoraTableAdapter1
            // 
            this.kontoraTableAdapter1.ClearBeforeFill = true;
            // 
            // Конторы
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 386);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Конторы";
            this.Text = "Конторы";
            this.Load += new System.EventHandler(this.Конторы_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kontoraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sELHOZDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kompleksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sELHOZDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kompleksBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kontoraBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button7;
        private SELHOZDataSet sELHOZDataSet;
        private System.Windows.Forms.BindingSource kontoraBindingSource;
        private SELHOZDataSetTableAdapters.KontoraTableAdapter kontoraTableAdapter;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.BindingSource kompleksBindingSource;
        private SELHOZDataSetTableAdapters.KompleksTableAdapter kompleksTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодконторыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn комплексDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn предприятиеDataGridViewTextBoxColumn;
        private SELHOZDataSet1 sELHOZDataSet1;
        private System.Windows.Forms.BindingSource kompleksBindingSource1;
        private SELHOZDataSet1TableAdapters.KompleksTableAdapter kompleksTableAdapter1;
        private System.Windows.Forms.BindingSource kontoraBindingSource1;
        private SELHOZDataSet1TableAdapters.KontoraTableAdapter kontoraTableAdapter1;
    }
}