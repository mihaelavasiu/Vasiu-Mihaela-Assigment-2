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
    public class DeleteProductRepository
    {
        MySqlConnection con;
        MySqlDataAdapter adapt;
        DataSet ds;
        int selectedRow;
        public DeleteProduct deleteProductView;
        private string connString = "datasource=127.0.0.1;port=3306;username=root;password=;database=assigment1;";
        public DeleteProductRepository(DeleteProduct deleteProductView1)
        {
            this.deleteProductView = deleteProductView1;
           
        }
        public void btnAdd_Click()
        {
            for (int i = 0; i < deleteProductView.dataGridView1.Rows.Count; i++)
            {
                DataGridViewRow delrow = deleteProductView.dataGridView1.Rows[i];
                if (delrow.Selected == true)
                {
                    deleteProductView.dataGridView1.Rows.RemoveAt(i);
                    try
                    {
                        using (MySqlConnection conn = new MySqlConnection(connString))
                        {
                            conn.Open();
                            MySqlCommand cmd = new MySqlCommand();
                            cmd.Connection = conn;
                            i = i + 5;
                            cmd.CommandText = "DELETE FROM product WHERE id=" + i + "";

                            cmd.Prepare();

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Deleted!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
        }


        public void DeleteProduct_Load()
        {
            try
            {
                con = new MySqlConnection();
                con.ConnectionString = @"datasource=127.0.0.1;port=3306;username=root;password=;database=assigment1;Convert Zero Datetime=True;";
                con.Open();
                adapt = new MySqlDataAdapter("select title ,description,color,size,price,stock from product", con);
                ds = new System.Data.DataSet();
                adapt.Fill(ds, "Product_Details");
                deleteProductView.dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
