namespace AdminPart
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.OpenMedicineListButton = new System.Windows.Forms.Button();
            this.OpenOrderListButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.RichTextBox();
            this.CancelSearchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OpenMedicineListButton
            // 
            this.OpenMedicineListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenMedicineListButton.Location = new System.Drawing.Point(12, 63);
            this.OpenMedicineListButton.Name = "OpenMedicineListButton";
            this.OpenMedicineListButton.Size = new System.Drawing.Size(159, 42);
            this.OpenMedicineListButton.TabIndex = 0;
            this.OpenMedicineListButton.Text = "Список лекарственных средств";
            this.OpenMedicineListButton.UseVisualStyleBackColor = true;
            this.OpenMedicineListButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // OpenOrderListButton
            // 
            this.OpenOrderListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenOrderListButton.Location = new System.Drawing.Point(12, 111);
            this.OpenOrderListButton.Name = "OpenOrderListButton";
            this.OpenOrderListButton.Size = new System.Drawing.Size(159, 42);
            this.OpenOrderListButton.TabIndex = 1;
            this.OpenOrderListButton.Text = "Список заказов";
            this.OpenOrderListButton.UseVisualStyleBackColor = true;
            this.OpenOrderListButton.Click += new System.EventHandler(this.button2_Click);
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
            // SearchTextBox
            // 
            this.SearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchTextBox.Location = new System.Drawing.Point(190, 12);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(187, 37);
            this.SearchTextBox.TabIndex = 9;
            this.SearchTextBox.Text = "";
            // 
            // CancelSearchButton
            // 
            this.CancelSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelSearchButton.Image = ((System.Drawing.Image)(resources.GetObject("CancelSearchButton.Image")));
            this.CancelSearchButton.Location = new System.Drawing.Point(432, 13);
            this.CancelSearchButton.Name = "CancelSearchButton";
            this.CancelSearchButton.Size = new System.Drawing.Size(46, 37);
            this.CancelSearchButton.TabIndex = 10;
            this.CancelSearchButton.UseVisualStyleBackColor = true;
            this.CancelSearchButton.Visible = false;
            this.CancelSearchButton.Click += new System.EventHandler(this.CancelSearchButton_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 369);
            this.Controls.Add(this.CancelSearchButton);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.OpenOrderListButton);
            this.Controls.Add(this.OpenMedicineListButton);
            this.Name = "AdminForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OpenMedicineListButton;
        private System.Windows.Forms.Button OpenOrderListButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.RichTextBox SearchTextBox;
        private System.Windows.Forms.Button CancelSearchButton;

    }
}

