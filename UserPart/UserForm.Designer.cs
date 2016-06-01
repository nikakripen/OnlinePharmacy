namespace UserPart
{
    partial class UserForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.OpenMedControlButton = new System.Windows.Forms.Button();
            this.OpenViewOrderButton = new System.Windows.Forms.Button();
            this.OpenContactsButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.OpenCartButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.RichTextBox();
            this.ClearCartButton = new System.Windows.Forms.Button();
            this.AddToCartButton = new System.Windows.Forms.Button();
            this.CancelSearchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OpenMedControlButton
            // 
            this.OpenMedControlButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenMedControlButton.Location = new System.Drawing.Point(12, 60);
            this.OpenMedControlButton.Name = "OpenMedControlButton";
            this.OpenMedControlButton.Size = new System.Drawing.Size(159, 42);
            this.OpenMedControlButton.TabIndex = 0;
            this.OpenMedControlButton.Text = "Список лекарственных средств";
            this.OpenMedControlButton.UseVisualStyleBackColor = true;
            this.OpenMedControlButton.Click += new System.EventHandler(this.OpenMedControlButton_Click);
            // 
            // OpenViewOrderButton
            // 
            this.OpenViewOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenViewOrderButton.Location = new System.Drawing.Point(12, 108);
            this.OpenViewOrderButton.Name = "OpenViewOrderButton";
            this.OpenViewOrderButton.Size = new System.Drawing.Size(159, 42);
            this.OpenViewOrderButton.TabIndex = 1;
            this.OpenViewOrderButton.Text = "Оформить заказ";
            this.OpenViewOrderButton.UseVisualStyleBackColor = true;
            this.OpenViewOrderButton.Click += new System.EventHandler(this.OpenViewOrderButton_Click);
            // 
            // OpenContactsButton
            // 
            this.OpenContactsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenContactsButton.Location = new System.Drawing.Point(12, 156);
            this.OpenContactsButton.Name = "OpenContactsButton";
            this.OpenContactsButton.Size = new System.Drawing.Size(159, 42);
            this.OpenContactsButton.TabIndex = 2;
            this.OpenContactsButton.Text = "Контакты";
            this.OpenContactsButton.UseVisualStyleBackColor = true;
            // 
            // SearchButton
            // 
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Image = ((System.Drawing.Image)(resources.GetObject("SearchButton.Image")));
            this.SearchButton.Location = new System.Drawing.Point(380, 13);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(46, 37);
            this.SearchButton.TabIndex = 5;
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // OpenCartButton
            // 
            this.OpenCartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenCartButton.Image = ((System.Drawing.Image)(resources.GetObject("OpenCartButton.Image")));
            this.OpenCartButton.Location = new System.Drawing.Point(614, 13);
            this.OpenCartButton.Name = "OpenCartButton";
            this.OpenCartButton.Size = new System.Drawing.Size(46, 37);
            this.OpenCartButton.TabIndex = 8;
            this.OpenCartButton.UseVisualStyleBackColor = true;
            this.OpenCartButton.Click += new System.EventHandler(this.OpenCartButton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchTextBox.Location = new System.Drawing.Point(187, 12);
            this.SearchTextBox.Multiline = false;
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(187, 37);
            this.SearchTextBox.TabIndex = 9;
            this.SearchTextBox.Text = "";
            // 
            // ClearCartButton
            // 
            this.ClearCartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearCartButton.Image = ((System.Drawing.Image)(resources.GetObject("ClearCartButton.Image")));
            this.ClearCartButton.Location = new System.Drawing.Point(562, 13);
            this.ClearCartButton.Name = "ClearCartButton";
            this.ClearCartButton.Size = new System.Drawing.Size(46, 37);
            this.ClearCartButton.TabIndex = 13;
            this.ClearCartButton.UseVisualStyleBackColor = true;
            this.ClearCartButton.Click += new System.EventHandler(this.ClearCartButton_Click);
            // 
            // AddToCartButton
            // 
            this.AddToCartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddToCartButton.Image = ((System.Drawing.Image)(resources.GetObject("AddToCartButton.Image")));
            this.AddToCartButton.Location = new System.Drawing.Point(510, 13);
            this.AddToCartButton.Name = "AddToCartButton";
            this.AddToCartButton.Size = new System.Drawing.Size(46, 37);
            this.AddToCartButton.TabIndex = 14;
            this.AddToCartButton.UseVisualStyleBackColor = true;
            this.AddToCartButton.Click += new System.EventHandler(this.AddToCartButton_Click);
            // 
            // CancelSearchButton
            // 
            this.CancelSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelSearchButton.Image = ((System.Drawing.Image)(resources.GetObject("CancelSearchButton.Image")));
            this.CancelSearchButton.Location = new System.Drawing.Point(432, 12);
            this.CancelSearchButton.Name = "CancelSearchButton";
            this.CancelSearchButton.Size = new System.Drawing.Size(46, 37);
            this.CancelSearchButton.TabIndex = 15;
            this.CancelSearchButton.UseVisualStyleBackColor = true;
            this.CancelSearchButton.Visible = false;
            this.CancelSearchButton.Click += new System.EventHandler(this.CancelSearchButton_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 369);
            this.Controls.Add(this.CancelSearchButton);
            this.Controls.Add(this.AddToCartButton);
            this.Controls.Add(this.ClearCartButton);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.OpenCartButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.OpenContactsButton);
            this.Controls.Add(this.OpenViewOrderButton);
            this.Controls.Add(this.OpenMedControlButton);
            this.Name = "UserForm";
            this.Text = "Электронная аптека";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OpenMedControlButton;
        private System.Windows.Forms.Button OpenViewOrderButton;
        private System.Windows.Forms.Button OpenContactsButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button OpenCartButton;
        private System.Windows.Forms.RichTextBox SearchTextBox;
        private System.Windows.Forms.Button ClearCartButton;
        private System.Windows.Forms.Button AddToCartButton;
        private System.Windows.Forms.Button CancelSearchButton;

    }
}

