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
using Assigment1.Data;
using Assigment1.Presenter;

namespace Assigment1
{
    public partial class UpdateOrder : Form
    {
        MySqlConnection con;
        MySqlDataAdapter adapt;
        DataSet ds;
        int selectedRow;
        private string connString = "datasource=127.0.0.1;port=3306;username=root;password=;database=assigment1;";
        public UpdateOrder()
        {
            InitializeComponent();
        }
        int indexRow;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // var addForm = new AddForm();
            var updateOrderRepository = new UpdateOrderRepository(this);
            var updateOrderPresenter = new UpdateOrderPresenter(this, updateOrderRepository);
            // addFormPresenter.LoadAddForm();
            updateOrderPresenter.btnAdd_Click();
            updateOrderPresenter.UpdateOrder_Load();
            this.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex; // get the selected Row Index
            DataGridViewRow row = dataGridView1.Rows[indexRow];

            txtID.Text = row.Cells[0].Value.ToString();
            txtCustomer.Text = row.Cells[1].Value.ToString();
            txtAddress.Text = row.Cells[2].Value.ToString();
            txtDeliveryDate.Text = row.Cells[3].Value.ToString();
            txtStatus.Text = row.Cells[4].Value.ToString();
            txtPieces.Text = row.Cells[5].Value.ToString();
            txtValue.Text = row.Cells[6].Value.ToString();
            txtProductID.Text = row.Cells[7].Value.ToString();
        }

        private void UpdateOrder_Load(object sender, EventArgs e)
        {
            var updateOrderRepository = new UpdateOrderRepository(this);
            var updateOrderPresenter = new UpdateOrderPresenter(this, updateOrderRepository);
            // addFormPresenter.LoadAddForm();
            //updateOrderPresenter.btnAdd_Click();
            updateOrderPresenter.UpdateOrder_Load();
            this.Show();
        }

        private void txtPieces_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDeliveryDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbAddress_Click(object sender, EventArgs e)
        {

        }

        private void txtCustomer_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbCustomer_Click(object sender, EventArgs e)
        {

        }

        private void lblUserName_Click(object sender, EventArgs e)
        {

        }

        private void txtStatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProductID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
