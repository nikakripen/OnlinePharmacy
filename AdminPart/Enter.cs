using Repository.Models;
using Repository.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
//using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminPart
{
    public partial class EnterForm : Form
    {
        string CommandText = "SELECT * FROM pharmacies";
        public EnterForm()
        {
            InitializeComponent(); 
        }

        private void Enter_Load(object sender, EventArgs e)
        {
            IRepository<Medicine> rep = new MedicinesRepository();
            
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = rep.GetAll();
            
            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Name";
            column.Name = "Наименование";
            dataGridView1.Columns.Add(column);

            // Initialize and add a check box column.
            column = new DataGridViewCheckBoxColumn();
            column.DataPropertyName = "Available";
            column.Name = "В наличии";
            dataGridView1.Columns.Add(column);

            //dataGridView1.Columns[0].Name = "Имя";//.DataPropertyName = "Name";
            //dataGridView1.Columns[1].DataPropertyName = "PrducrForm";
            //dataGridView1.Columns[2].DataPropertyName = "Manufacturer";
            //dataGridView1.Columns[3].DataPropertyName = "Recipe";
            //dataGridView1.Columns[4].DataPropertyName = "Price";
            //dataGridView1.Columns[5].DataPropertyName = "Available";
            
        }

        public void Auth()
        {
            try
            {
                SqlConnectionStringBuilder bldr = new SqlConnectionStringBuilder();
                bldr.InitialCatalog = "pharmacy";
                bldr.UserID = textBox1.Text;
                bldr.Password = textBox2.Text;
                bldr.DataSource = "VERONIKA";
                bldr.IntegratedSecurity = false;
                SqlDataAdapter dataAdapter = new SqlDataAdapter(CommandText, bldr.ConnectionString);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds, "Лекарства");
                dataGridView1.DataSource = ds.Tables["Лекарства"].DefaultView;
            }
            catch (SqlException e)
            {
                MessageBox.Show("Error!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Auth();
        }
    }
}
