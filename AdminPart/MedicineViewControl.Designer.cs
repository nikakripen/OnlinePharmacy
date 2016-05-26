namespace AdminPart
{
    partial class MedicineViewControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedicineViewControl));
            this.BackButton = new System.Windows.Forms.PictureBox();
            this.SafeMedButton = new System.Windows.Forms.Button();
            this.AvailableCheckBox = new System.Windows.Forms.CheckBox();
            this.RecipeСheckBox = new System.Windows.Forms.CheckBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.ManufacturerLabel = new System.Windows.Forms.Label();
            this.ProductFormLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.ManufacturerBox = new System.Windows.Forms.TextBox();
            this.ProductFormBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.BackButton)).BeginInit();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Image = ((System.Drawing.Image)(resources.GetObject("BackButton.Image")));
            this.BackButton.Location = new System.Drawing.Point(36, 233);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(32, 32);
            this.BackButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BackButton.TabIndex = 25;
            this.BackButton.TabStop = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // SafeMedButton
            // 
            this.SafeMedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SafeMedButton.Location = new System.Drawing.Point(391, 238);
            this.SafeMedButton.Name = "SafeMedButton";
            this.SafeMedButton.Size = new System.Drawing.Size(93, 33);
            this.SafeMedButton.TabIndex = 24;
            this.SafeMedButton.Text = "Добавить";
            this.SafeMedButton.UseVisualStyleBackColor = true;
            this.SafeMedButton.Click += new System.EventHandler(this.SafeMedButton_Click);
            // 
            // AvailableCheckBox
            // 
            this.AvailableCheckBox.AutoSize = true;
            this.AvailableCheckBox.Location = new System.Drawing.Point(369, 37);
            this.AvailableCheckBox.Name = "AvailableCheckBox";
            this.AvailableCheckBox.Size = new System.Drawing.Size(77, 17);
            this.AvailableCheckBox.TabIndex = 23;
            this.AvailableCheckBox.Text = "В наличии";
            this.AvailableCheckBox.UseVisualStyleBackColor = true;
            // 
            // RecipeСheckBox
            // 
            this.RecipeСheckBox.AutoSize = true;
            this.RecipeСheckBox.Location = new System.Drawing.Point(369, 11);
            this.RecipeСheckBox.Name = "RecipeСheckBox";
            this.RecipeСheckBox.Size = new System.Drawing.Size(62, 17);
            this.RecipeСheckBox.TabIndex = 22;
            this.RecipeСheckBox.Text = "Рецепт";
            this.RecipeСheckBox.UseVisualStyleBackColor = true;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(181, 90);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(33, 13);
            this.PriceLabel.TabIndex = 21;
            this.PriceLabel.Text = "Цена";
            this.PriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ManufacturerLabel
            // 
            this.ManufacturerLabel.AutoSize = true;
            this.ManufacturerLabel.Location = new System.Drawing.Point(7, 64);
            this.ManufacturerLabel.Name = "ManufacturerLabel";
            this.ManufacturerLabel.Size = new System.Drawing.Size(207, 13);
            this.ManufacturerLabel.TabIndex = 20;
            this.ManufacturerLabel.Text = "Производитель/Страна производитель";
            this.ManufacturerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ProductFormLabel
            // 
            this.ProductFormLabel.AutoSize = true;
            this.ProductFormLabel.Location = new System.Drawing.Point(124, 38);
            this.ProductFormLabel.Name = "ProductFormLabel";
            this.ProductFormLabel.Size = new System.Drawing.Size(90, 13);
            this.ProductFormLabel.TabIndex = 19;
            this.ProductFormLabel.Text = "Форма выпуска";
            this.ProductFormLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(131, 12);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(83, 13);
            this.NameLabel.TabIndex = 18;
            this.NameLabel.Text = "Наименование";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PriceBox
            // 
            this.PriceBox.Location = new System.Drawing.Point(220, 87);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(100, 20);
            this.PriceBox.TabIndex = 17;
            // 
            // ManufacturerBox
            // 
            this.ManufacturerBox.Location = new System.Drawing.Point(220, 61);
            this.ManufacturerBox.Name = "ManufacturerBox";
            this.ManufacturerBox.Size = new System.Drawing.Size(100, 20);
            this.ManufacturerBox.TabIndex = 16;
            // 
            // ProductFormBox
            // 
            this.ProductFormBox.Location = new System.Drawing.Point(220, 35);
            this.ProductFormBox.Name = "ProductFormBox";
            this.ProductFormBox.Size = new System.Drawing.Size(100, 20);
            this.ProductFormBox.TabIndex = 15;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(220, 10);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(100, 20);
            this.NameBox.TabIndex = 14;
            // 
            // MedicineViewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.SafeMedButton);
            this.Controls.Add(this.AvailableCheckBox);
            this.Controls.Add(this.RecipeСheckBox);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.ManufacturerLabel);
            this.Controls.Add(this.ProductFormLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.PriceBox);
            this.Controls.Add(this.ManufacturerBox);
            this.Controls.Add(this.ProductFormBox);
            this.Controls.Add(this.NameBox);
            this.Name = "MedicineViewControl";
            this.Size = new System.Drawing.Size(490, 280);
            ((System.ComponentModel.ISupportInitialize)(this.BackButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox BackButton;
        public System.Windows.Forms.Button SafeMedButton;
        public System.Windows.Forms.CheckBox AvailableCheckBox;
        public System.Windows.Forms.CheckBox RecipeСheckBox;
        public System.Windows.Forms.Label PriceLabel;
        public System.Windows.Forms.Label ManufacturerLabel;
        public System.Windows.Forms.Label ProductFormLabel;
        public System.Windows.Forms.Label NameLabel;
        public System.Windows.Forms.TextBox PriceBox;
        public System.Windows.Forms.TextBox ManufacturerBox;
        public System.Windows.Forms.TextBox ProductFormBox;
        public System.Windows.Forms.TextBox NameBox;

    }
}
