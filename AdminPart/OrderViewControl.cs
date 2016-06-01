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

namespace AdminPart
{
    public partial class OrderViewControl : UserControl
    {
        public OrderViewControl()
        {
            InitializeComponent();
        }

        private void SaveOrderButton_Click(object sender, EventArgs e)
        {
            var ordRep = new OrdersRepository();
            Order order = AdminForm.ordersControl.OrdersList.SelectedRows[0].DataBoundItem as Order;
            order.State = StatusBox.SelectedItem.ToString();
            
            ordRep.Save(order);
            AdminForm.ordersControl.BringToFront();
            AdminForm.ordersControl.OrdersList.Update();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Сохранить изменения?", "Сохранение изменений",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                this.SaveOrderButton_Click(this.SaveOrderButton, e);
            }
            else AdminForm.ordersControl.BringToFront();
        }

    }
}
