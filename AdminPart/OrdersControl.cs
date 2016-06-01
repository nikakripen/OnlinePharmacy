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
            OrdersList.DataSource = OrdRepository.GetAll();
            OrdersList.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Id",
                Name = "ID",
                Width = 30
            });
            
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
            Order order = OrdersList.SelectedRows[0].DataBoundItem as Order;
            AdminForm.orderViewControl.IDBox.Text = order.Id.ToString();
            AdminForm.orderViewControl.SurnameBox.Text = order.Surname;
            AdminForm.orderViewControl.NameBox.Text = order.Name;
            AdminForm.orderViewControl.PatronymicBox.Text = order.Patronymic;
            AdminForm.orderViewControl.EmailBox.Text = order.E_mail;
            AdminForm.orderViewControl.PhoneNumberBox.Text = order.PhoneNumber;
            AdminForm.orderViewControl.StatusBox.SelectedIndex = AdminForm.orderViewControl.StatusBox.FindString(order.State);
            var orderedMed = from med in order.OrderedMedicines
                select med.Name + " " + med.ProductForm;
            
            AdminForm.orderViewControl.OrderedMedicinesList.Items.Clear();     
            AdminForm.orderViewControl.OrderedMedicinesList.Items.AddRange(orderedMed.ToArray());
            AdminForm.orderViewControl.BringToFront();
        }

        private void DeleteOrderButton_Click(object sender, EventArgs e)
        {
            Order order = OrdersList.SelectedRows[0].DataBoundItem as Order;
            if (MessageBox.Show("Вы действительно хотите удалить заказ № "
                                + order.Id + "?", "Удаление элемента", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                MedicinesRepository rep = new MedicinesRepository();
                OrdRepository.Delete(order);
                MessageBox.Show("Заказ № " + order.Id + " удален!", "Удаление элемента",
                    MessageBoxButtons.OK);
                OrdersList.DataSource = OrdRepository.GetAll();
            }
        }

        private void OrdersList_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (OrdersList.SelectedRows.Count == 0)
            {
                OpenViewOrderPannelButton.Enabled = false;
                DeleteOrderButton.Enabled = false;
            }
            else
            {
                OpenViewOrderPannelButton.Enabled = true;
                if ((OrdersList.SelectedRows[0].DataBoundItem as Order).State == "доставлен")
                {
                    DeleteOrderButton.Enabled = true;
                }
                else
                {
                    DeleteOrderButton.Enabled = false;
                }
            }
            
        }
    }
}
