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
    public partial class Modify : Form
    {
        MySqlConnection con;
        MySqlDataAdapter adapt;
        DataSet ds;
        int indexRow;
        public Modify()
        {
            InitializeComponent();
        }

        private void Modify_Load(object sender, EventArgs e)
        {
            // var addForm = new AddForm();
            var modifyRepository = new ModifyRepository(this);
            var modifyPresenter = new ModifyPresenter(this, modifyRepository);
            // addFormPresenter.LoadAddForm();
            modifyPresenter.Modify_Load();
            this.Show();
        }


        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
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

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            // var addForm = new AddForm();
            var modifyRepository = new ModifyRepository(this);
            var modifyPresenter = new ModifyPresenter(this, modifyRepository);
            // addFormPresenter.LoadAddForm();
            modifyPresenter.btnAdd_Click_1();
            modifyPresenter.Modify_Load();
            this.Show();
        }
    }
}
