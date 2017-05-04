using Assigment1.Presenter;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assigment1.Model
{
    public class AddOrderRepository
    {
        MySqlConnection con;
        MySqlDataAdapter adapt;
        DataSet ds;
        int selectedRow;
        public AddOrder addOrderView;
        int indexRow;
        private string connString = "datasource=127.0.0.1;port=3306;username=root;password=;database=assigment1;";
        public AddOrderRepository(AddOrder addOrderView)
        {
            this.addOrderView = addOrderView; 
           
        }


        public void AddOrder()
        {
            DataGridViewRow newDataRow = addOrderView.dataGridView1.Rows[indexRow];
            newDataRow.Cells[0].Value = addOrderView.txtID.Text;
            newDataRow.Cells[1].Value = addOrderView.txtCustomer.Text;
            newDataRow.Cells[2].Value = addOrderView.txtAddress.Text;
            newDataRow.Cells[3].Value = addOrderView.dateTimePicker1.Text;
            newDataRow.Cells[4].Value = addOrderView.txtStatus.Text;
            newDataRow.Cells[5].Value = addOrderView.txtPieces.Text;
            newDataRow.Cells[6].Value = addOrderView.txtValue.Text;
            newDataRow.Cells[7].Value = addOrderView.txtProductID.Text;
            try
            {
                OrderModel order = new OrderModel();
                order.ID = Convert.ToInt32(addOrderView.txtID.Text);
                order.Customer = addOrderView.txtCustomer.Text;
                order.Address = addOrderView.txtAddress.Text;
                order.DeliveryDate = addOrderView.dateTimePicker1.Value;
                order.Status = addOrderView.txtStatus.Text;
                order.Pieces = Convert.ToInt32(addOrderView.txtPieces.Text);
                order.Value = Convert.ToInt32(addOrderView.txtValue.Text);
                order.ProductID = Convert.ToInt32(addOrderView.txtProductID.Text);


                IDBManager db = new MySQLDBManager();
                db.AddOrder(order);
                BindingSource bindingsource = new BindingSource();
                addOrderView.dataGridView1.DataSource = null;
                addOrderView.dataGridView1.DataSource = bindingsource;
                addOrderView.dataGridView1.Refresh();
                con = new MySqlConnection();
                con.ConnectionString = @"datasource=127.0.0.1;port=3306;username=root;password=;database=assigment1;Convert Zero Datetime=True;";
                con.Open();
                adapt = new MySqlDataAdapter("SELECT `id`, `customer`, `address`, `delivery_date`, `status`, `pieces`, `value`, `product_id` FROM `order` ", con);
                ds = new System.Data.DataSet();
                adapt.Fill(ds, "Order_Details");
                addOrderView.dataGridView1.DataSource = ds.Tables[0];
                MessageBox.Show("Added!", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }


        public void LoadAddOrder(){
            try
            {
                con = new MySqlConnection();
                con.ConnectionString = @"datasource=127.0.0.1;port=3306;username=root;password=;database=assigment1;Convert Zero Datetime=True;";
                con.Open();
                adapt = new MySqlDataAdapter("SELECT `id`, `customer`, `address`, `delivery_date`, `status`, `pieces`, `value`, `product_id` FROM `order` ", con);
                ds = new System.Data.DataSet();
                adapt.Fill(ds, "Order_Details");
                addOrderView.dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
