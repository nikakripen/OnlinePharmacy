namespace AdminPart
{
    partial class MedicinesControl
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
            this.DeleteMedButton = new System.Windows.Forms.Button();
            this.MedicineList = new System.Windows.Forms.DataGridView();
            this.OpenChangeMedPanelButton = new System.Windows.Forms.Button();
            this.OpenAddMedPannelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MedicineList)).BeginInit();
            this.SuspendLayout();
            // 
            // DeleteMedButton
            // 
            this.DeleteMedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteMedButton.Location = new System.Drawing.Point(331, 238);
            this.DeleteMedButton.Name = "DeleteMedButton";
            this.DeleteMedButton.Size = new System.Drawing.Size(154, 42);
            this.DeleteMedButton.TabIndex = 17;
            this.DeleteMedButton.Text = "Удалить";
            this.DeleteMedButton.UseVisualStyleBackColor = true;
            this.DeleteMedButton.Click += new System.EventHandler(this.DeleteMedButton_Click);
            // 
            // MedicineList
            // 
            this.MedicineList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MedicineList.Location = new System.Drawing.Point(5, 2);
            this.MedicineList.Name = "MedicineList";
            this.MedicineList.ReadOnly = true;
            this.MedicineList.RowHeadersVisible = false;
            this.MedicineList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MedicineList.Size = new System.Drawing.Size(480, 230);
            this.MedicineList.TabIndex = 14;
            this.MedicineList.VirtualMode = true;
            // 
            // OpenChangeMedPanelButton
            // 
            this.OpenChangeMedPanelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenChangeMedPanelButton.Location = new System.Drawing.Point(168, 238);
            this.OpenChangeMedPanelButton.Name = "OpenChangeMedPanelButton";
            this.OpenChangeMedPanelButton.Size = new System.Drawing.Size(154, 42);
            this.OpenChangeMedPanelButton.TabIndex = 16;
            this.OpenChangeMedPanelButton.Text = "Изменить";
            this.OpenChangeMedPanelButton.UseVisualStyleBackColor = true;
            this.OpenChangeMedPanelButton.Click += new System.EventHandler(this.OpenChangeMedPanelButton_Click);
            // 
            // OpenAddMedPannelButton
            // 
            this.OpenAddMedPannelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenAddMedPannelButton.Location = new System.Drawing.Point(5, 238);
            this.OpenAddMedPannelButton.Name = "OpenAddMedPannelButton";
            this.OpenAddMedPannelButton.Size = new System.Drawing.Size(154, 42);
            this.OpenAddMedPannelButton.TabIndex = 15;
            this.OpenAddMedPannelButton.Text = "Добавить";
            this.OpenAddMedPannelButton.UseVisualStyleBackColor = true;
            this.OpenAddMedPannelButton.Click += new System.EventHandler(this.OpenAddMedPannelButton_Click);
            // 
            // MedicinesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DeleteMedButton);
            this.Controls.Add(this.MedicineList);
            this.Controls.Add(this.OpenChangeMedPanelButton);
            this.Controls.Add(this.OpenAddMedPannelButton);
            this.Name = "MedicinesControl";
            this.Size = new System.Drawing.Size(490, 280);
            ((System.ComponentModel.ISupportInitialize)(this.MedicineList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView MedicineList;
        public System.Windows.Forms.Button DeleteMedButton;
        public System.Windows.Forms.Button OpenChangeMedPanelButton;
        public System.Windows.Forms.Button OpenAddMedPannelButton;
    }
}
