namespace UserPart
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
            this.MedicineList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.MedicineList)).BeginInit();
            this.SuspendLayout();
            // 
            // MedicineList
            // 
            this.MedicineList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MedicineList.Location = new System.Drawing.Point(5, 2);
            this.MedicineList.Name = "MedicineList";
            this.MedicineList.ReadOnly = true;
            this.MedicineList.RowHeadersVisible = false;
            this.MedicineList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MedicineList.Size = new System.Drawing.Size(480, 275);
            this.MedicineList.TabIndex = 14;
            this.MedicineList.VirtualMode = true;
            // 
            // MedicinesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MedicineList);
            this.Name = "MedicinesControl";
            this.Size = new System.Drawing.Size(490, 280);
            ((System.ComponentModel.ISupportInitialize)(this.MedicineList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView MedicineList;
    }
}
