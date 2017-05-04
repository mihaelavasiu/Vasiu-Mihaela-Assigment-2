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
    public class AddFormRepository
    {
        MySqlConnection con;
        MySqlDataAdapter adapt;
        DataSet ds;
        int selectedRow;
        public AddForm addFormView;

        public AddFormRepository(AddForm addFormView)
        {
            this.addFormView = addFormView;
           
        }


        public void AddForm()
        {
            try
            {
                ProductModel product = new ProductModel();
                product.Title = addFormView.txtTitle.Text;
                product.Description = addFormView.txtDescription.Text;
                product.Color = addFormView.txtColor.Text;
                product.Size = Convert.ToDouble(addFormView.txtSize.Text);
                product.Price = Convert.ToDouble(addFormView.txtPrice.Text);
                product.Stock = Convert.ToInt32(addFormView.txtSize.Text);

                IDBManager db = new MySQLDBManager();
                db.Create(product);
                BindingSource bindingsource = new BindingSource();
                addFormView.dataGridView1.DataSource = null;
                addFormView.dataGridView1.DataSource = bindingsource;
                addFormView.dataGridView1.Refresh();
                con = new MySqlConnection();
                con.ConnectionString = @"datasource=127.0.0.1;port=3306;username=root;password=;database=assigment1;Convert Zero Datetime=True;";
                con.Open();
                adapt = new MySqlDataAdapter("select title ,description,color,size,price,stock from product", con);
                ds = new System.Data.DataSet();
                adapt.Fill(ds, "Product_Details");
                addFormView.dataGridView1.DataSource = ds.Tables[0];
                MessageBox.Show("Created!", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void LoadAddForm(){
            try
            {
                con = new MySqlConnection();
                con.ConnectionString = @"datasource=127.0.0.1;port=3306;username=root;password=;database=assigment1;Convert Zero Datetime=True;";
                con.Open();
                adapt = new MySqlDataAdapter("select title ,description,color,size,price,stock from product", con);
                ds = new System.Data.DataSet();
                adapt.Fill(ds, "Product_Details");
                addFormView.dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
