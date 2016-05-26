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
        static public OrdersControl ordersPanel;
        static public OrderViewControl orderViewControl;
        static public MedicinesControl medicinesControl;
        static public MedicineViewControl medicineViewControl;     

        public AdminForm()
        {
            InitializeComponent();

            ordersPanel = new OrdersControl();
            ordersPanel.Parent = this;
            ordersPanel.Location = new Point(190, 63);

            orderViewControl = new OrderViewControl();
            orderViewControl.Parent = this;
            ordersPanel.Location = new Point(190, 63);

            medicinesControl = new MedicinesControl();
            medicinesControl.Parent = this;
            medicinesControl.Location = new Point(190, 63);

            medicineViewControl = new MedicineViewControl();
            medicineViewControl.Parent = this;
            medicineViewControl.Location = new Point(190, 63);

        }

        static public readonly IRepository<Medicine> MedRepository = new MedicinesRepository();

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
            ordersPanel.BringToFront();
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
