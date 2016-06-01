using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Repository.Db;
using Repository.Filters;
using Repository.Models;
//using Repository.Properties;
using Repository.Repository;


namespace AdminPart
{
    public partial class AdminForm : Form
    {
        static public OrdersControl ordersControl;
        static public OrderViewControl orderViewControl;
        static public MedicinesControl medicinesControl;
        static public MedicineViewControl medicineViewControl;
        static public string[] StatusMas = {"не обработан", "обработан", "доставлен"};

        public AdminForm()
        {
            InitializeComponent();

            ordersControl = new OrdersControl
            {
                Parent = this,
                Location = new Point(190, 63)
            };

            orderViewControl = new OrderViewControl
            {
                Parent = this,
                Location = new Point(190, 63)
            };
            orderViewControl.StatusBox.Items.AddRange(AdminForm.StatusMas);

            medicinesControl = new MedicinesControl
            {
                Parent = this,
                Location = new Point(190, 63)
            };

            medicineViewControl = new MedicineViewControl
            {
                Parent = this,
                Location = new Point(190, 63)
            };

        }

        private readonly IRepository<Medicine> MedRepository = new MedicinesRepository();
        private readonly IRepository<Order> OrdRepository = new OrdersRepository();
        
        private void AdminForm_Load(object sender, EventArgs e)
        {
            medicinesControl.BringToFront();
            medicinesControl.MedicineList.DataSource = MedRepository.GetAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            medicinesControl.BringToFront();
            medicinesControl.MedicineList.DataSource = MedRepository.GetAll();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ordersControl.BringToFront();
            ordersControl.OrdersList.DataSource = OrdRepository.GetAll();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            medicinesControl.MedicineList.DataSource = MedRepository.GetAll().WithNameLike(SearchTextBox.Text);
            CancelSearchButton.Visible = true;
        }

        private void CancelSearchButton_Click(object sender, EventArgs e)
        {
            medicinesControl.MedicineList.DataSource = MedRepository.GetAll();
            CancelSearchButton.Visible = false;
            SearchTextBox.Text = "";
        }

        
    }
}
