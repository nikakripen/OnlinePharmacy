﻿namespace AdminPart
{
    partial class OrderViewControl
    {
        /// <summary> 
        /// Требуется переменная конструктора.
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Обязательный метод для поддержки конструктора - не изменяйте 
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderViewControl));
            this.BackButton = new System.Windows.Forms.PictureBox();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.PatronymicLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.PhoneNumberBox = new System.Windows.Forms.TextBox();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.PatronymicBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.SurnameBox = new System.Windows.Forms.TextBox();
            this.StatusBox = new System.Windows.Forms.ComboBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.OrderedMedicinesList = new System.Windows.Forms.ListBox();
            this.SaveOrderButton = new System.Windows.Forms.Button();
            this.IDLabel = new System.Windows.Forms.Label();
            this.IDBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.BackButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Image = ((System.Drawing.Image)(resources.GetObject("BackButton.Image")));
            this.BackButton.Location = new System.Drawing.Point(36, 233);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(32, 32);
            this.BackButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BackButton.TabIndex = 37;
            this.BackButton.TabStop = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Location = new System.Drawing.Point(15, 163);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(93, 13);
            this.PhoneNumberLabel.TabIndex = 33;
            this.PhoneNumberLabel.Text = "Номер телефона";
            this.PhoneNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(4, 137);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(104, 13);
            this.EmailLabel.TabIndex = 32;
            this.EmailLabel.Text = "Электронная почта";
            this.EmailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PatronymicLabel
            // 
            this.PatronymicLabel.AutoSize = true;
            this.PatronymicLabel.Location = new System.Drawing.Point(54, 111);
            this.PatronymicLabel.Name = "PatronymicLabel";
            this.PatronymicLabel.Size = new System.Drawing.Size(54, 13);
            this.PatronymicLabel.TabIndex = 31;
            this.PatronymicLabel.Text = "Отчество";
            this.PatronymicLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(79, 86);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(29, 13);
            this.NameLabel.TabIndex = 30;
            this.NameLabel.Text = "Имя";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PhoneNumberBox
            // 
            this.PhoneNumberBox.Location = new System.Drawing.Point(114, 160);
            this.PhoneNumberBox.Name = "PhoneNumberBox";
            this.PhoneNumberBox.ReadOnly = true;
            this.PhoneNumberBox.Size = new System.Drawing.Size(121, 20);
            this.PhoneNumberBox.TabIndex = 29;
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(114, 134);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.ReadOnly = true;
            this.EmailBox.Size = new System.Drawing.Size(121, 20);
            this.EmailBox.TabIndex = 28;
            // 
            // PatronymicBox
            // 
            this.PatronymicBox.Location = new System.Drawing.Point(114, 108);
            this.PatronymicBox.Name = "PatronymicBox";
            this.PatronymicBox.ReadOnly = true;
            this.PatronymicBox.Size = new System.Drawing.Size(121, 20);
            this.PatronymicBox.TabIndex = 27;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(114, 83);
            this.NameBox.Name = "NameBox";
            this.NameBox.ReadOnly = true;
            this.NameBox.Size = new System.Drawing.Size(121, 20);
            this.NameBox.TabIndex = 26;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Location = new System.Drawing.Point(52, 60);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(56, 13);
            this.SurnameLabel.TabIndex = 39;
            this.SurnameLabel.Text = "Фамилия";
            this.SurnameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SurnameBox
            // 
            this.SurnameBox.Location = new System.Drawing.Point(114, 57);
            this.SurnameBox.Name = "SurnameBox";
            this.SurnameBox.ReadOnly = true;
            this.SurnameBox.Size = new System.Drawing.Size(121, 20);
            this.SurnameBox.TabIndex = 38;
            // 
            // StatusBox
            // 
            this.StatusBox.FormattingEnabled = true;
            this.StatusBox.Location = new System.Drawing.Point(114, 187);
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.Size = new System.Drawing.Size(121, 21);
            this.StatusBox.TabIndex = 40;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(67, 190);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(41, 13);
            this.StatusLabel.TabIndex = 41;
            this.StatusLabel.Text = "Статус";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // OrderedMedicinesList
            // 
            this.OrderedMedicinesList.FormattingEnabled = true;
            this.OrderedMedicinesList.Location = new System.Drawing.Point(241, 32);
            this.OrderedMedicinesList.Name = "OrderedMedicinesList";
            this.OrderedMedicinesList.Size = new System.Drawing.Size(230, 173);
            this.OrderedMedicinesList.TabIndex = 42;
            // 
            // SaveOrderButton
            // 
            this.SaveOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveOrderButton.Location = new System.Drawing.Point(378, 232);
            this.SaveOrderButton.Name = "SaveOrderButton";
            this.SaveOrderButton.Size = new System.Drawing.Size(93, 33);
            this.SaveOrderButton.TabIndex = 43;
            this.SaveOrderButton.Text = "Изменить";
            this.SaveOrderButton.UseVisualStyleBackColor = true;
            this.SaveOrderButton.Click += new System.EventHandler(this.SaveOrderButton_Click);
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(90, 35);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(18, 13);
            this.IDLabel.TabIndex = 45;
            this.IDLabel.Text = "ID";
            this.IDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // IDBox
            // 
            this.IDBox.Location = new System.Drawing.Point(114, 32);
            this.IDBox.Name = "IDBox";
            this.IDBox.ReadOnly = true;
            this.IDBox.Size = new System.Drawing.Size(121, 20);
            this.IDBox.TabIndex = 44;
            // 
            // OrderViewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.IDBox);
            this.Controls.Add(this.SaveOrderButton);
            this.Controls.Add(this.OrderedMedicinesList);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.StatusBox);
            this.Controls.Add(this.SurnameLabel);
            this.Controls.Add(this.SurnameBox);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.PhoneNumberLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.PatronymicLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.PhoneNumberBox);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.PatronymicBox);
            this.Controls.Add(this.NameBox);
            this.Name = "OrderViewControl";
            this.Size = new System.Drawing.Size(490, 280);
            ((System.ComponentModel.ISupportInitialize)(this.BackButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox BackButton;
        public System.Windows.Forms.Label PhoneNumberLabel;
        public System.Windows.Forms.Label EmailLabel;
        public System.Windows.Forms.Label PatronymicLabel;
        public System.Windows.Forms.Label NameLabel;
        public System.Windows.Forms.TextBox PhoneNumberBox;
        public System.Windows.Forms.TextBox EmailBox;
        public System.Windows.Forms.TextBox PatronymicBox;
        public System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        public System.Windows.Forms.Label SurnameLabel;
        public System.Windows.Forms.TextBox SurnameBox;
        public System.Windows.Forms.Label StatusLabel;
        public System.Windows.Forms.ListBox OrderedMedicinesList;
        public System.Windows.Forms.ComboBox StatusBox;
        public System.Windows.Forms.Button SaveOrderButton;
        public System.Windows.Forms.Label IDLabel;
        public System.Windows.Forms.TextBox IDBox;
    }
}
