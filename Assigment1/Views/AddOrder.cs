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
using Assigment1.Presenter;
using Assigment1.Model;

namespace Assigment1
{
    public partial class AddOrder : Form
    {
       // public AddOrderPresenter Presenter { get; set; }
        MySqlConnection con;
        MySqlDataAdapter adapt;
        DataSet ds;
        int selectedRow;
        int indexRow;
       
        public AddOrder()
        {
            InitializeComponent();
            //Presenter = new AddOrderPresenter(this);
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            // var addForm = new AddForm();
            var addOrderRepository = new AddOrderRepository(this);
            var addOrderPresenter = new AddOrderPresenter(this, addOrderRepository);
            // addFormPresenter.LoadAddForm();
            addOrderPresenter.AddOrderMethod();
            addOrderPresenter.LoadAdOrder();
            this.Show();

        }

        private void AddOrder_Load(object sender, EventArgs e)
        {
           // Presenter.LoadAddOrder();
        }
    }
}
