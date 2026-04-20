namespace Deryabin_16
{
    partial class MainForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.deryabin_16_examDataSet = new Deryabin_16.Deryabin_16_examDataSet();
            this.deryabin16examDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заказыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заказыTableAdapter = new Deryabin_16.Deryabin_16_examDataSetTableAdapters.ЗаказыTableAdapter();
            this.номерзаказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиетовараDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.производительDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.скидкаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deryabin_16_examDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deryabin16examDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерзаказаDataGridViewTextBoxColumn,
            this.названиетовараDataGridViewTextBoxColumn,
            this.ценаDataGridViewTextBoxColumn,
            this.производительDataGridViewTextBoxColumn,
            this.скидкаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.заказыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(568, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // deryabin_16_examDataSet
            // 
            this.deryabin_16_examDataSet.DataSetName = "Deryabin_16_examDataSet";
            this.deryabin_16_examDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // deryabin16examDataSetBindingSource
            // 
            this.deryabin16examDataSetBindingSource.DataSource = this.deryabin_16_examDataSet;
            this.deryabin16examDataSetBindingSource.Position = 0;
            // 
            // заказыBindingSource
            // 
            this.заказыBindingSource.DataMember = "Заказы";
            this.заказыBindingSource.DataSource = this.deryabin_16_examDataSet;
            // 
            // заказыTableAdapter
            // 
            this.заказыTableAdapter.ClearBeforeFill = true;
            // 
            // номерзаказаDataGridViewTextBoxColumn
            // 
            this.номерзаказаDataGridViewTextBoxColumn.DataPropertyName = "Номер_заказа";
            this.номерзаказаDataGridViewTextBoxColumn.HeaderText = "Номер_заказа";
            this.номерзаказаDataGridViewTextBoxColumn.Name = "номерзаказаDataGridViewTextBoxColumn";
            // 
            // названиетовараDataGridViewTextBoxColumn
            // 
            this.названиетовараDataGridViewTextBoxColumn.DataPropertyName = "Название_товара";
            this.названиетовараDataGridViewTextBoxColumn.HeaderText = "Название_товара";
            this.названиетовараDataGridViewTextBoxColumn.Name = "названиетовараDataGridViewTextBoxColumn";
            // 
            // ценаDataGridViewTextBoxColumn
            // 
            this.ценаDataGridViewTextBoxColumn.DataPropertyName = "Цена";
            this.ценаDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.ценаDataGridViewTextBoxColumn.Name = "ценаDataGridViewTextBoxColumn";
            // 
            // производительDataGridViewTextBoxColumn
            // 
            this.производительDataGridViewTextBoxColumn.DataPropertyName = "Производитель";
            this.производительDataGridViewTextBoxColumn.HeaderText = "Производитель";
            this.производительDataGridViewTextBoxColumn.Name = "производительDataGridViewTextBoxColumn";
            // 
            // скидкаDataGridViewTextBoxColumn
            // 
            this.скидкаDataGridViewTextBoxColumn.DataPropertyName = "Скидка";
            this.скидкаDataGridViewTextBoxColumn.HeaderText = "Скидка";
            this.скидкаDataGridViewTextBoxColumn.Name = "скидкаDataGridViewTextBoxColumn";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 397);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 41);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(122, 397);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(104, 41);
            this.btnDel.TabIndex = 2;
            this.btnDel.Text = "Удалить";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(232, 397);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 41);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnRen
            // 
            this.btnRen.Location = new System.Drawing.Point(342, 397);
            this.btnRen.Name = "btnRen";
            this.btnRen.Size = new System.Drawing.Size(104, 41);
            this.btnRen.TabIndex = 4;
            this.btnRen.Text = "Изменить";
            this.btnRen.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRen);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deryabin_16_examDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deryabin16examDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource deryabin16examDataSetBindingSource;
        private Deryabin_16_examDataSet deryabin_16_examDataSet;
        private System.Windows.Forms.BindingSource заказыBindingSource;
        private Deryabin_16_examDataSetTableAdapters.ЗаказыTableAdapter заказыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерзаказаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиетовараDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn производительDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn скидкаDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRen;
    }
}