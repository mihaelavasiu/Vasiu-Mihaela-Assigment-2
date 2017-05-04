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
    public class UpdateProductRepository
    {
        MySqlConnection con;
        MySqlDataAdapter adapt;
        DataSet ds;
        int selectedRow;
        public UpdateProduct updateView;
        private string connString = "datasource=127.0.0.1;port=3306;username=root;password=;database=assigment1;";
        int indexRow;
        public UpdateProductRepository(UpdateProduct updateView)
        {
            this.updateView = updateView;
           
        }
        public void UpdateProduct_Load()
        {
            try
            {
                con = new MySqlConnection();
                con.ConnectionString = @"datasource=127.0.0.1;port=3306;username=root;password=;database=assigment1;Convert Zero Datetime=True;";
                con.Open();
                adapt = new MySqlDataAdapter("select title ,description,color,size,price,stock from product", con);
                ds = new System.Data.DataSet();
                adapt.Fill(ds, "Product_Details");
                updateView.dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void btnAdd_Click()
        {
            DataGridViewRow newDataRow = updateView.dataGridView1.Rows[indexRow];
            newDataRow.Cells[0].Value = updateView.txtTitle.Text;
            newDataRow.Cells[1].Value = updateView.txtDescription.Text;
            newDataRow.Cells[2].Value = updateView.txtColor.Text;
            newDataRow.Cells[3].Value = updateView.txtSize.Text;
            newDataRow.Cells[4].Value = updateView.txtPrice.Text;
            newDataRow.Cells[5].Value = updateView.txtStock.Text;
            try
            {
                ProductModel product = new ProductModel();
                product.Title = updateView.txtTitle.Text;
                product.Description = updateView.txtDescription.Text;
                product.Color = updateView.txtColor.Text;
                product.Size = Convert.ToDouble(updateView.txtSize.Text);
                product.Price = Convert.ToDouble(updateView.txtPrice.Text);
                product.Stock = Convert.ToInt32(updateView.txtSize.Text);

                IDBManager db = new MySQLDBManager();
                db.Update(product);
                BindingSource bindingsource = new BindingSource();
                updateView.dataGridView1.DataSource = null;
                updateView.dataGridView1.DataSource = bindingsource;
                updateView.dataGridView1.Refresh();
                con = new MySqlConnection();
                con.ConnectionString = @"datasource=127.0.0.1;port=3306;username=root;password=;database=assigment1;Convert Zero Datetime=True;";
                con.Open();
                adapt = new MySqlDataAdapter("select title ,description,color,size,price,stock from product", con);
                ds = new System.Data.DataSet();
                adapt.Fill(ds, "Product_Details");
                updateView.dataGridView1.DataSource = ds.Tables[0];
                MessageBox.Show("Updated!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
