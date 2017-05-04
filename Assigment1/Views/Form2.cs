using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using Assigment1.Model;
using Assigment1.Presenter;
using Assigment1.Data;

namespace Assigment1
{
    public partial class Form2 : Form
    {
        MySqlConnection con;
        MySqlDataAdapter adapt;
        DataSet ds;
        public Form2()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
            MessageBox.Show("Successfully logged out!", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            View v = new View();
            v.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // var addForm = new AddForm();
            var deleteProduct= new DeleteProduct();
            var deleteProductRepository = new DeleteProductRepository(deleteProduct);
            var deleteProductPresenter = new DeleteProductPresenter(deleteProduct, deleteProductRepository);
            // addFormPresenter.LoadAddForm();
            // deleteProductPresenter.btnAdd_Click();
            deleteProductPresenter.DeleteProduct_Load();
            deleteProduct.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var addForm= new AddForm();
            var addFormRepository = new AddFormRepository(addForm);
            var addFormPresenter = new AddFormPresenter(addForm, addFormRepository);
            addFormPresenter.LoadAddForm();
            addForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //UpdateProduct u = new UpdateProduct();
            // UpdateOrder o = new UpdateOrder();
            var update = new UpdateProduct();
            var updateRepository = new UpdateProductRepository(update);
            var updatePresenter = new UpdateProductPresenter(update, updateRepository);
            updatePresenter.UpdateProduct_Load();
            update.Show();
           // u.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            View1 v = new View1();
            v.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // UpdateOrder o = new UpdateOrder();
            var update = new UpdateOrder();
            var updateRepository = new UpdateOrderRepository(update);
            var updatePresenter = new UpdateOrderPresenter(update, updateRepository);
            updatePresenter.UpdateOrder_Load();
            update.Show();
            //o.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddOrder a = new AddOrder();
            var addOrder = new AddOrder();
            var addOrderRepository = new AddOrderRepository(addOrder);
            var addOrderPresenter = new AddOrderPresenter(addOrder, addOrderRepository);
            addOrderPresenter.LoadAdOrder();
            addOrder.Show();
            a.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {         
            var modify = new Modify();
            var modifyRepository = new ModifyRepository(modify);
            var modifyPresenter = new ModifyPresenter(modify, modifyRepository);
            modifyPresenter.Modify_Load();   
            modify.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
