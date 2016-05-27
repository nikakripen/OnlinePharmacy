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

namespace AdminPart
{
    public partial class OrdersControl : UserControl
    {
        private readonly IRepository<Order> OrdRepository = new OrdersRepository();
        
        public OrdersControl()
        {
            InitializeComponent();

            OrdersList.AutoGenerateColumns = false;
            //OrdersList.DataSource = OrdRepository.GetAll();
            OrdersList.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Surname",
                Name = "Фамилия",
                Width = 90
            });
            OrdersList.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Name",
                Name = "Имя",
                Width = 90
            });

            OrdersList.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Patronymic",
                Name = "Отчество",
                Width = 90
            });

            OrdersList.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "E_mail",
                Name = "Email",
                Width = 82
            });

            OrdersList.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "PhoneNumber",
                Name = "Номер телефона",
                Width = 65
            });

            OrdersList.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "State",
                Name = "Состояние",
                Width = 60
            });
            OrdersList.AllowUserToAddRows = false;
        }

        private void OpenViewOrderPannelButton_Click(object sender, EventArgs e)
        {

        }

        private void DeleteOrderButton_Click(object sender, EventArgs e)
        {

        }
    }
}
