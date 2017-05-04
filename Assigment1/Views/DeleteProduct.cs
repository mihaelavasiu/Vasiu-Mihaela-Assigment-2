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
    public partial class DeleteProduct : Form
    {
        MySqlConnection con;
        MySqlDataAdapter adapt;
        DataSet ds;
        int selectedRow;
       
        public DeleteProduct()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // var addForm = new AddForm();
            var deleteProductRepository = new DeleteProductRepository(this);
            var deleteProductPresenter = new DeleteProductPresenter(this, deleteProductRepository);
            // addFormPresenter.LoadAddForm();
            deleteProductPresenter.btnAdd_Click();
            deleteProductPresenter.DeleteProduct_Load();
            this.Show();
            }
        

        private void DeleteProduct_Load(object sender, EventArgs e)
        {
            // var addForm = new AddForm();
            var deleteProductRepository = new DeleteProductRepository(this);
            var deleteProductPresenter = new DeleteProductPresenter(this, deleteProductRepository);
            // addFormPresenter.LoadAddForm();
           // deleteProductPresenter.btnAdd_Click();
            deleteProductPresenter.DeleteProduct_Load();
            this.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
