using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Repository.Filters;
using Repository.Models;
using Repository.Repository;

namespace UserPart
{
    public partial class UserForm : Form
    {
        public static MedicinesControl medicineControl;
        public static OrderViewControl orderViewControl;
        private readonly IRepository<Medicine> MedRepository = new MedicinesRepository();
        public static BindingList<Medicine> ordMedList = new BindingList<Medicine>();  
        public UserForm()
        {
            InitializeComponent();
           
            medicineControl = new MedicinesControl()
            {
                Parent = this,
                Location = new Point(190, 63)
            };

            orderViewControl = new OrderViewControl()
            {
                Parent = this,
                Location = new Point(190,63)
            };
            orderViewControl.OrderedMedicinesList.DataSource = ordMedList;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            medicineControl.BringToFront();
            medicineControl.MedicineList.DataSource = MedRepository.GetAll();
        }

        private void OpenMedControlButton_Click(object sender, EventArgs e)
        {
            medicineControl.BringToFront();
            medicineControl.MedicineList.DataSource = MedRepository.GetAll();
        }

        private void OpenViewOrderButton_Click(object sender, EventArgs e)
        {
            orderViewControl.BringToFront();
            orderViewControl.OrderedMedicinesList.DataSource = ordMedList;
        }

        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            Medicine med = medicineControl.MedicineList.SelectedRows[0].DataBoundItem as Medicine;
            ordMedList.Add(med);
            MessageBox.Show("Лек.средство добавленно в корзину!", "Добавление в корзину", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ClearCartButton_Click(object sender, EventArgs e)
        {
            ordMedList.Clear();
            MessageBox.Show("Корзина очищена!", "Корзина", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
        }

        private void OpenCartButton_Click(object sender, EventArgs e)
        {
            orderViewControl.BringToFront();
            orderViewControl.OrderedMedicinesList.DataSource = ordMedList;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            medicineControl.MedicineList.DataSource = MedRepository.GetAll().WithNameLike(SearchTextBox.Text);
            CancelSearchButton.Visible = true;
        }

        private void CancelSearchButton_Click(object sender, EventArgs e)
        {
            medicineControl.MedicineList.DataSource = MedRepository.GetAll();
            CancelSearchButton.Visible = false;
            SearchTextBox.Text = "";
        }
    }
}
