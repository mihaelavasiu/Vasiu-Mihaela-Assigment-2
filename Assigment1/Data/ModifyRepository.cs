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
    public class ModifyRepository
    {
        MySqlConnection con;
        MySqlDataAdapter adapt;
        DataSet ds;
        int selectedRow;
        public Modify modifyView;
        private string connString = "datasource=127.0.0.1;port=3306;username=root;password=;database=assigment1;";
        int indexRow;
         public ModifyRepository(Modify modifyView)
        {
            this.modifyView = modifyView;
           
        }
         public void Modify_Load()
         {
             try
             {
                 con = new MySqlConnection();
                 con.ConnectionString = @"datasource=127.0.0.1;port=3306;username=root;password=;database=assigment1;Convert Zero Datetime=True;";
                 con.Open();
                 adapt = new MySqlDataAdapter("SELECT `id`, `customer`, `address`, `delivery_date`, `status`, `pieces`, `value`, `product_id` FROM `order`", con);
                 ds = new System.Data.DataSet();
                 adapt.Fill(ds, "Order_Details");
                 modifyView.dataGridView1.DataSource = ds.Tables[0];
             }
             catch (Exception ex)
             {
                 MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
         }


         public void btnAdd_Click_1()
         {
             DataGridViewRow newDataRow = modifyView.dataGridView1.Rows[indexRow];
             newDataRow.Cells[0].Value = modifyView.txtID.Text;
             newDataRow.Cells[1].Value = modifyView.txtCustomer.Text;
             newDataRow.Cells[2].Value = modifyView.txtAddress.Text;
             newDataRow.Cells[3].Value = modifyView.txtDeliveryDate.Text;
             newDataRow.Cells[4].Value = modifyView.txtStatus.Text;
             newDataRow.Cells[5].Value = modifyView.txtPieces.Text;
             newDataRow.Cells[6].Value = modifyView.txtValue.Text;
             newDataRow.Cells[7].Value = modifyView.txtProductID.Text;
             try
             {
                 OrderModel order = new OrderModel();
                 order.ID = Convert.ToInt32(modifyView.txtID.Text);
                 order.Customer = modifyView.txtCustomer.Text;
                 order.Address = modifyView.txtAddress.Text;
                 order.DeliveryDate = Convert.ToDateTime(modifyView.txtDeliveryDate.Text);
                 order.Status = modifyView.txtStatus.Text;
                 order.Pieces = Convert.ToInt32(modifyView.txtPieces.Text);
                 order.Value = Convert.ToInt32(modifyView.txtValue.Text);
                 order.ProductID = Convert.ToInt32(modifyView.txtProductID.Text);
                 int nrProducts = Convert.ToInt32(modifyView.txtNr.Text);

                 IDBManager db = new MySQLDBManager();
                 db.ModifyOrder(order, nrProducts);
                 BindingSource bindingsource = new BindingSource();
                 modifyView.dataGridView1.DataSource = null;
                 modifyView.dataGridView1.DataSource = bindingsource;
                 modifyView.dataGridView1.Refresh();
                 con = new MySqlConnection();
                 con.ConnectionString = @"datasource=127.0.0.1;port=3306;username=root;password=;database=assigment1;Convert Zero Datetime=True;";
                 con.Open();
                 adapt = new MySqlDataAdapter("SELECT `id`, `customer`, `address`, `delivery_date`, `status`, `pieces`, `value`, `product_id` FROM `order` ", con);
                 ds = new System.Data.DataSet();
                 adapt.Fill(ds, "Order_Details");
                 modifyView.dataGridView1.DataSource = ds.Tables[0];
                 MessageBox.Show("Updated!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
         }
    }
}
