using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Repository.Models;
using Repository.Repository;

namespace UserPart
{
    public partial class OrderViewControl : UserControl
    {
        private readonly MedicinesRepository MedRepository = new MedicinesRepository();
            
        public OrderViewControl()
        {
            InitializeComponent();

            OrderedMedicinesList.AutoGenerateColumns = false;
            OrderedMedicinesList.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Name",
                Name = "Наименование",
                Width = 90
            });

            OrderedMedicinesList.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "ProductForm",
                Name = "Форма выпуска",
                Width = 95
            });

            OrderedMedicinesList.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Manufacturer",
                Name = "Производитель",
                Width = 112
            });

            OrderedMedicinesList.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Price",
                Name = "Цена",
                Width = 80
            });

            OrderedMedicinesList.Columns.Add(new DataGridViewCheckBoxColumn()
            {
                DataPropertyName = "Recipe",
                Name = "По рецепту",
                Width = 50
            });

            OrderedMedicinesList.Columns.Add(new DataGridViewCheckBoxColumn()
            {
                DataPropertyName = "Available",
                Name = "В наличии",
                Width = 50
            });

            OrderedMedicinesList.AllowUserToAddRows = false;
        
        }

        private void SaveOrderButton_Click(object sender, EventArgs e)
        {
            if (NameBox.Text == "" || SurnameBox.Text == "" || PatronymicBox.Text == ""
                || EmailBox.Text == "" || PhoneNumberBox.Text == "")
            {
                MessageBox.Show("Все поля должны быть заполнены!", "Ошибка!", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if ((NameBox.Text.Length < 2 || NameBox.Text.Length > 255) ||
                (SurnameBox.Text.Length < 2 || SurnameBox.Text.Length > 255)
                || (PatronymicBox.Text.Length < 2 || PatronymicBox.Text.Length > 255) ||
                (EmailBox.Text.Length < 2 || EmailBox.Text.Length > 255))
            {
                MessageBox.Show("Поле должно содержать от 2 до 255 символов!", "Ошибка!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (!new Regex(
                @"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$",
                RegexOptions.IgnorePatternWhitespace).IsMatch(EmailBox.Text))
            {
                MessageBox.Show("Поле Электронная почта записано не правильно!", "Ошибка!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (PhoneNumberBox.Text.Length < 7 || PhoneNumberBox.Text.Length > 15 || new Regex(
                @"/^(\+?\d+)?\s*(\(\d+\))?[\s-]*([\d-]*)$/",
                RegexOptions.IgnorePatternWhitespace).IsMatch(EmailBox.Text))
            {
                MessageBox.Show("Поле Номер телефона должно содержать только цифры и знак + !", "Ошибка!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var OrdRepository = new OrdersRepository();
            Order order = null;
            try
            {
                order = new Order()
                {
                    Surname = SurnameBox.Text,
                    Name = NameBox.Text,
                    Patronymic = PatronymicBox.Text,
                    E_mail = EmailBox.Text,
                    PhoneNumber = PhoneNumberBox.Text,
                    State = "не обработан",
                    OrderedMedicines = UserForm.ordMedList.ToList()
                };
                OrdRepository.Save(order);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            MessageBox.Show(String.Format("Ваш заказ успешно отправлен. Номер вашего заказа: {0}", order.Id),
                "Добавление лек.средства",
                MessageBoxButtons.OK);
            
            UserForm.ordMedList.Clear();
            UserForm.medicineControl.MedicineList.DataSource = MedRepository.GetAll();
            UserForm.medicineControl.BringToFront();

            foreach (Control control in Controls)
            {
                if (control is TextBox)
                    control.Text = "";
            }

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            UserForm.medicineControl.BringToFront();
            UserForm.medicineControl.MedicineList.DataSource = MedRepository.GetAll();
        }

    }
}
