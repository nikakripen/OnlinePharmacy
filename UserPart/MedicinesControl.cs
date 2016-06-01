using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Repository.Models;
using Repository.Repository;

namespace UserPart
{
    public partial class MedicinesControl : UserControl
    {
        public MedicinesControl()
        {
            InitializeComponent();

            MedicineList.AutoGenerateColumns = false;
            MedicineList.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Name",
                Name = "Наименование",
                Width = 90
            });

            MedicineList.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "ProductForm",
                Name = "Форма выпуска",
                Width = 95
            });

            MedicineList.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Manufacturer",
                Name = "Производитель",
                Width = 112
            });

            MedicineList.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Price",
                Name = "Цена",
                Width = 80
            });

            MedicineList.Columns.Add(new DataGridViewCheckBoxColumn()
            {
                DataPropertyName = "Recipe",
                Name = "По рецепту",
                Width = 50
            });

            MedicineList.Columns.Add(new DataGridViewCheckBoxColumn()
            {
                DataPropertyName = "Available",
                Name = "В наличии",
                Width = 50
            });

            MedicineList.AllowUserToAddRows = false;
        }
    }
}
