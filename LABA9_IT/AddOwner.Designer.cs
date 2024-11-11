namespace LABA9_IT
{
    partial class AddOwner
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FIOBox = new System.Windows.Forms.TextBox();
            this.AdressBOX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PhoneBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MoneyBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.RegistrationNumBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.RegDateBox = new System.Windows.Forms.DateTimePicker();
            this.AddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО Владельца";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(85, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Добавление владельца";
            // 
            // FIOBox
            // 
            this.FIOBox.Location = new System.Drawing.Point(15, 43);
            this.FIOBox.Name = "FIOBox";
            this.FIOBox.Size = new System.Drawing.Size(258, 20);
            this.FIOBox.TabIndex = 2;
            // 
            // AdressBOX
            // 
            this.AdressBOX.Location = new System.Drawing.Point(15, 91);
            this.AdressBOX.Name = "AdressBOX";
            this.AdressBOX.Size = new System.Drawing.Size(258, 20);
            this.AdressBOX.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Адрес Владельца";
            // 
            // PhoneBox
            // 
            this.PhoneBox.Location = new System.Drawing.Point(15, 141);
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(258, 20);
            this.PhoneBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Телефон Владельца";
            // 
            // MoneyBox
            // 
            this.MoneyBox.Location = new System.Drawing.Point(15, 194);
            this.MoneyBox.Name = "MoneyBox";
            this.MoneyBox.Size = new System.Drawing.Size(258, 20);
            this.MoneyBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Вклад в магазин";
            // 
            // RegistrationNumBox
            // 
            this.RegistrationNumBox.Location = new System.Drawing.Point(15, 246);
            this.RegistrationNumBox.Name = "RegistrationNumBox";
            this.RegistrationNumBox.Size = new System.Drawing.Size(258, 20);
            this.RegistrationNumBox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Регистрационный номер";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Дата регистрации";
            // 
            // RegDateBox
            // 
            this.RegDateBox.Location = new System.Drawing.Point(15, 298);
            this.RegDateBox.Name = "RegDateBox";
            this.RegDateBox.Size = new System.Drawing.Size(258, 20);
            this.RegDateBox.TabIndex = 12;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(111, 397);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(99, 41);
            this.AddButton.TabIndex = 13;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddOwner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 450);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.RegDateBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.RegistrationNumBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MoneyBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PhoneBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AdressBOX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FIOBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddOwner";
            this.Text = "AddOwner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FIOBox;
        private System.Windows.Forms.TextBox AdressBOX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PhoneBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MoneyBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox RegistrationNumBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker RegDateBox;
        private System.Windows.Forms.Button AddButton;
    }
}