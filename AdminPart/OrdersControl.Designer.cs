namespace AdminPart
{
    partial class OrdersControl
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
            this.DeleteOrderButton = new System.Windows.Forms.Button();
            this.OrdersList = new System.Windows.Forms.DataGridView();
            this.OpenViewOrderPannelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersList)).BeginInit();
            this.SuspendLayout();
            // 
            // DeleteOrderButton
            // 
            this.DeleteOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteOrderButton.Location = new System.Drawing.Point(332, 237);
            this.DeleteOrderButton.Name = "DeleteOrderButton";
            this.DeleteOrderButton.Size = new System.Drawing.Size(154, 42);
            this.DeleteOrderButton.TabIndex = 16;
            this.DeleteOrderButton.Text = "Удалить";
            this.DeleteOrderButton.UseVisualStyleBackColor = true;
            this.DeleteOrderButton.Click += new System.EventHandler(this.DeleteOrderButton_Click);
            // 
            // OrdersList
            // 
            this.OrdersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersList.Location = new System.Drawing.Point(5, 3);
            this.OrdersList.Name = "OrdersList";
            this.OrdersList.ReadOnly = true;
            this.OrdersList.RowHeadersVisible = false;
            this.OrdersList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrdersList.Size = new System.Drawing.Size(480, 230);
            this.OrdersList.TabIndex = 14;
            this.OrdersList.VirtualMode = true;
            // 
            // OpenViewOrderPannelButton
            // 
            this.OpenViewOrderPannelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenViewOrderPannelButton.Location = new System.Drawing.Point(5, 237);
            this.OpenViewOrderPannelButton.Name = "OpenViewOrderPannelButton";
            this.OpenViewOrderPannelButton.Size = new System.Drawing.Size(154, 42);
            this.OpenViewOrderPannelButton.TabIndex = 15;
            this.OpenViewOrderPannelButton.Text = "Просмотреть";
            this.OpenViewOrderPannelButton.UseVisualStyleBackColor = true;
            this.OpenViewOrderPannelButton.Click += new System.EventHandler(this.OpenViewOrderPannelButton_Click);
            // 
            // OrdersControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DeleteOrderButton);
            this.Controls.Add(this.OrdersList);
            this.Controls.Add(this.OpenViewOrderPannelButton);
            this.Name = "OrdersControl";
            this.Size = new System.Drawing.Size(490, 280);
            ((System.ComponentModel.ISupportInitialize)(this.OrdersList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button DeleteOrderButton;
        public System.Windows.Forms.DataGridView OrdersList;
        public System.Windows.Forms.Button OpenViewOrderPannelButton;


    }
}
