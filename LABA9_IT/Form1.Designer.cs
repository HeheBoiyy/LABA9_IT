namespace LABA9_IT
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.investmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registrationNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registrationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shopDataSet = new LABA9_IT.ShopDataSet();
            this.ownersTableAdapter = new LABA9_IT.ShopDataSetTableAdapters.OwnersTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capitalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.storesTableAdapter = new LABA9_IT.ShopDataSetTableAdapters.StoresTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 22);
            this.button1.TabIndex = 0;
            this.button1.Text = "Добавить владельца";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(512, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(276, 22);
            this.button2.TabIndex = 1;
            this.button2.Text = "Вывод магазинов по определённому владельцу";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.investmentDataGridViewTextBoxColumn,
            this.registrationNumberDataGridViewTextBoxColumn,
            this.registrationDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ownersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(2, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(786, 195);
            this.dataGridView1.TabIndex = 2;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // investmentDataGridViewTextBoxColumn
            // 
            this.investmentDataGridViewTextBoxColumn.DataPropertyName = "Investment";
            this.investmentDataGridViewTextBoxColumn.HeaderText = "Investment";
            this.investmentDataGridViewTextBoxColumn.Name = "investmentDataGridViewTextBoxColumn";
            // 
            // registrationNumberDataGridViewTextBoxColumn
            // 
            this.registrationNumberDataGridViewTextBoxColumn.DataPropertyName = "RegistrationNumber";
            this.registrationNumberDataGridViewTextBoxColumn.HeaderText = "RegistrationNumber";
            this.registrationNumberDataGridViewTextBoxColumn.Name = "registrationNumberDataGridViewTextBoxColumn";
            // 
            // registrationDateDataGridViewTextBoxColumn
            // 
            this.registrationDateDataGridViewTextBoxColumn.DataPropertyName = "RegistrationDate";
            this.registrationDateDataGridViewTextBoxColumn.HeaderText = "RegistrationDate";
            this.registrationDateDataGridViewTextBoxColumn.Name = "registrationDateDataGridViewTextBoxColumn";
            // 
            // ownersBindingSource
            // 
            this.ownersBindingSource.DataMember = "Owners";
            this.ownersBindingSource.DataSource = this.shopDataSet;
            // 
            // shopDataSet
            // 
            this.shopDataSet.DataSetName = "ShopDataSet";
            this.shopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ownersTableAdapter
            // 
            this.ownersTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn1,
            this.phoneDataGridViewTextBoxColumn1,
            this.capitalDataGridViewTextBoxColumn,
            this.profileDataGridViewTextBoxColumn,
            this.ownerIdDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.storesBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(2, 265);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(786, 195);
            this.dataGridView2.TabIndex = 3;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn1
            // 
            this.addressDataGridViewTextBoxColumn1.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn1.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn1.Name = "addressDataGridViewTextBoxColumn1";
            // 
            // phoneDataGridViewTextBoxColumn1
            // 
            this.phoneDataGridViewTextBoxColumn1.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn1.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn1.Name = "phoneDataGridViewTextBoxColumn1";
            // 
            // capitalDataGridViewTextBoxColumn
            // 
            this.capitalDataGridViewTextBoxColumn.DataPropertyName = "Capital";
            this.capitalDataGridViewTextBoxColumn.HeaderText = "Capital";
            this.capitalDataGridViewTextBoxColumn.Name = "capitalDataGridViewTextBoxColumn";
            // 
            // profileDataGridViewTextBoxColumn
            // 
            this.profileDataGridViewTextBoxColumn.DataPropertyName = "Profile";
            this.profileDataGridViewTextBoxColumn.HeaderText = "Profile";
            this.profileDataGridViewTextBoxColumn.Name = "profileDataGridViewTextBoxColumn";
            // 
            // ownerIdDataGridViewTextBoxColumn
            // 
            this.ownerIdDataGridViewTextBoxColumn.DataPropertyName = "OwnerId";
            this.ownerIdDataGridViewTextBoxColumn.HeaderText = "OwnerId";
            this.ownerIdDataGridViewTextBoxColumn.Name = "ownerIdDataGridViewTextBoxColumn";
            // 
            // storesBindingSource
            // 
            this.storesBindingSource.DataMember = "Stores";
            this.storesBindingSource.DataSource = this.shopDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Все владельцы:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Все магазины:";
            // 
            // storesTableAdapter
            // 
            this.storesTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(310, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(196, 21);
            this.button3.TabIndex = 6;
            this.button3.Text = "Удалить выбранного владельца";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(145, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(159, 21);
            this.button4.TabIndex = 7;
            this.button4.Text = "Добавить магазин";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 481);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ShopDataSet shopDataSet;
        private System.Windows.Forms.BindingSource ownersBindingSource;
        private ShopDataSetTableAdapters.OwnersTableAdapter ownersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn investmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrationNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource storesBindingSource;
        private ShopDataSetTableAdapters.StoresTableAdapter storesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn capitalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn profileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

