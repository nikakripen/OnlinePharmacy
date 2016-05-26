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
//using Repository.Properties;
using Repository.Repository;

namespace AdminPart
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

        private void OpenChangeMedPanelButton_Click(object sender, EventArgs e)
        {

            AdminForm.medicineViewControl.SafeMedButton.Text = "Изменить";

            Medicine med = MedicineList.SelectedRows[0].DataBoundItem as Medicine;
            AdminForm.medicineViewControl.NameBox.Text = med.Name;
            AdminForm.medicineViewControl.ProductFormBox.Text = med.ProductForm;
            AdminForm.medicineViewControl.ManufacturerBox.Text = med.Manufacturer;
            AdminForm.medicineViewControl.PriceBox.Text = med.Price.ToString();
            AdminForm.medicineViewControl.RecipeСheckBox.Checked = med.Recipe;
            AdminForm.medicineViewControl.AvailableCheckBox.Checked = med.Available;
            AdminForm.medicineViewControl.BringToFront();
        }

        private void DeleteMedButton_Click(object sender, EventArgs e)
        {
            Medicine cell = MedicineList.SelectedRows[0].DataBoundItem as Medicine;
            if (MessageBox.Show("Вы действительно хотите удалить данное лекарственное средство «"
                                + cell.Name + "»?", "Удаление элемента", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                MedicinesRepository rep = new MedicinesRepository();
                rep.Delete(cell);
                MessageBox.Show("Лекарственное средство " + cell.Name + " удалено!", "Удаление элемента",
                    MessageBoxButtons.OK);
                MedicineList.DataSource = rep.GetAll();
            }

        }

        private void OpenAddMedPannelButton_Click(object sender, EventArgs e)
        {
            AdminForm.medicineViewControl.BringToFront();
            AdminForm.medicineViewControl.SafeMedButton.Text = "Добавить";   
        }
    }
}
