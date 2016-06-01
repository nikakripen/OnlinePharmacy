using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Repository.Repository;
using Repository.Models;
using Repository.Filters;

namespace AdminPart
{
    public partial class MedicineViewControl : UserControl
    {
        public MedicineViewControl()
        {
            InitializeComponent();
        }

        private void SafeMedButton_Click(object sender, EventArgs e)
        {
            var rep = new MedicinesRepository();
            Medicine med;
            try
            {
            med = new Medicine()
            {
                Name = NameBox.Text,
                Available = AvailableCheckBox.Checked,
                Manufacturer = ManufacturerBox.Text,
                ProductForm = ProductFormBox.Text,
                Price = Convert.ToDecimal(PriceBox.Text),
                Recipe = RecipeСheckBox.Checked
            };
            

            
            ValidationClass.ValidateMedicine(med);

            //if (NameBox.Text == "" || ProductFormBox.Text == ""
            //    || ManufacturerBox.Text == "" || PriceBox.Text == "")
            //{
            //    MessageBox.Show("Все поля должны быть заполнены!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            //if (NameBox.Text.Length < 2 || NameBox.Text.Length > 255)
            //{
            //    MessageBox.Show("Поле Наименование должно содержать от 2 до 255 символов!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //if (ProductFormBox.Text.Length < 2 || ProductFormBox.Text.Length > 255)
            //{
            //    MessageBox.Show("Поле Форма выпуска должно содержать от 2 до 255 символов!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //if (ManufacturerBox.Text.Length < 2 || ManufacturerBox.Text.Length > 255)
            //{
            //    MessageBox.Show("Поле Производитель должно содержать от 2 до 255 символов!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //try
            //{
            //    if (Convert.ToInt32(PriceBox.Text) < 100 || Convert.ToInt32(PriceBox.Text) > 100000000)
            //    {
            //        MessageBox.Show("Поле Цена должно содержать значения от 100 до 100000000!", "Ошибка!",
            //            MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        return;
            //    }
            //}
            //catch (FormatException exception)
            //{
            //    MessageBox.Show("Поле Цена должно содержать цифровые значения!", "Ошибка!",
            //            MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;

            //}
            

            ValidationClass.IsMedicineAlreadyExist(med, rep);
            //if (rep.GetAll().IsMedicineExist(NameBox.Text, ProductFormBox.Text, ManufacturerBox.Text))
            //{
            //    MessageBox.Show("Такое лек.средство уже существует в системе!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            }
            catch(FormatException exception)
            {
                MessageBox.Show("Поле Цена должно содержать цифровые значения!", "Ошибка!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if ((sender as Button).Text == "Добавить")
            {
                rep.Save(med);

                MessageBox.Show(String.Format("Лекарственное средство {0} добавленно", NameBox.Text),
                    "Добавление лек.средства",
                    MessageBoxButtons.OK);
            }
            else
            {
                Medicine dbmed = AdminForm.medicinesControl.MedicineList.SelectedRows[0].DataBoundItem as Medicine;
                med.Id = dbmed.Id;

                rep.Save(med);
                MessageBox.Show("Изменения лек.средства " + med.Name + " сохранены!", "Изменение лек.средства", MessageBoxButtons.OK);

            }
            
            AdminForm.medicinesControl.MedicineList.DataSource = rep.GetAll();
            AdminForm.medicinesControl.BringToFront();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (NameBox.Text != "" || ProductFormBox.Text != ""
                || ManufacturerBox.Text != "" || PriceBox.Text != "")
            {
                if (MessageBox.Show("Сохранить изменения?", "Сохранение изменений",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    this.SafeMedButton_Click(this.SafeMedButton, e);
                }
                //else AdminForm.medicinesControl.BringToFront();
            }
            AdminForm.medicinesControl.BringToFront();
        }
    }
}
