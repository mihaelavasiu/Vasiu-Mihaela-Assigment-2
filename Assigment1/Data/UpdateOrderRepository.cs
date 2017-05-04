using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assigment1.Data
{
    public class UpdateOrderRepository
    {
        MySqlConnection con;
        MySqlDataAdapter adapt;
        DataSet ds;
        int selectedRow;
        public UpdateOrder updateOrderView;
        private string connString = "datasource=127.0.0.1;port=3306;username=root;password=;database=assigment1;";
        int indexRow;
         public UpdateOrderRepository(UpdateOrder updateOrderView)
        {
            this.updateOrderView = updateOrderView;
           
        }
         public void btnAdd_Click()
         {
             DataGridViewRow newDataRow = updateOrderView.dataGridView1.Rows[indexRow];
             newDataRow.Cells[0].Value = updateOrderView.txtID.Text;
             newDataRow.Cells[1].Value = updateOrderView.txtCustomer.Text;
             newDataRow.Cells[2].Value = updateOrderView.txtAddress.Text;
             newDataRow.Cells[3].Value = updateOrderView.txtDeliveryDate.Text;
             newDataRow.Cells[4].Value = updateOrderView.txtStatus.Text;
             newDataRow.Cells[5].Value = updateOrderView.txtPieces.Text;
             newDataRow.Cells[6].Value = updateOrderView.txtValue.Text;
             newDataRow.Cells[7].Value = updateOrderView.txtProductID.Text;
             try
             {
                 OrderModel order = new OrderModel();
                 order.ID = Convert.ToInt32(updateOrderView.txtID.Text);
                 order.Customer = updateOrderView.txtCustomer.Text;
                 order.Address = updateOrderView.txtAddress.Text;
                 order.DeliveryDate = Convert.ToDateTime(updateOrderView.txtDeliveryDate.Text);
                 order.Status = updateOrderView.txtStatus.Text;
                 order.Pieces = Convert.ToInt32(updateOrderView.txtPieces.Text);
                 order.Value = Convert.ToInt32(updateOrderView.txtValue.Text);
                 order.ProductID = Convert.ToInt32(updateOrderView.txtProductID.Text);


                 IDBManager db = new MySQLDBManager();
                 db.UpdateOrder(order);
                 BindingSource bindingsource = new BindingSource();
                 updateOrderView.dataGridView1.DataSource = null;
                 updateOrderView.dataGridView1.DataSource = bindingsource;
                 updateOrderView.dataGridView1.Refresh();
                 con = new MySqlConnection();
                 con.ConnectionString = @"datasource=127.0.0.1;port=3306;username=root;password=;database=assigment1;Convert Zero Datetime=True;";
                 con.Open();
                 adapt = new MySqlDataAdapter("SELECT `id`, `customer`, `address`, `delivery_date`, `status`, `pieces`, `value`, `product_id` FROM `order` ", con);
                 ds = new System.Data.DataSet();
                 adapt.Fill(ds, "Order_Details");
                 updateOrderView.dataGridView1.DataSource = ds.Tables[0];
                 MessageBox.Show("Updated!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
         }

         public void UpdateOrder_Load()
         {
             try
             {
                 con = new MySqlConnection();
                 con.ConnectionString = @"datasource=127.0.0.1;port=3306;username=root;password=;database=assigment1;Convert Zero Datetime=True;";
                 con.Open();
                 adapt = new MySqlDataAdapter("SELECT `id`, `customer`, `address`, `delivery_date`, `status`, `pieces`, `value`, `product_id` FROM `order`", con);
                 ds = new System.Data.DataSet();
                 adapt.Fill(ds, "Order_Details");
                 updateOrderView.dataGridView1.DataSource = ds.Tables[0];
             }
             catch (Exception ex)
             {
                 MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
         }     
    }
}
