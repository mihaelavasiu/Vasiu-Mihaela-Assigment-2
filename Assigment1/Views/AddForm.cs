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
    public partial class AddForm : Form
    {
       // public AddFormPresenter Presenter { get; set; }
        MySqlConnection con;
        MySqlDataAdapter adapt;
        DataSet ds;
        int selectedRow;
        public AddForm()
        {
            InitializeComponent();
            //Presenter=new AddFormPresenter(this);
        }

        public void AddForm_Load(object sender, EventArgs e)
        {
           // Presenter.LoadAddForm();
        }

        public void btnAdd_Click(object sender, EventArgs e)
        {
           // var addForm = new AddForm();
            var addFormRepository = new AddFormRepository(this);
            var addFormPresenter = new AddFormPresenter(this, addFormRepository);
           // addFormPresenter.LoadAddForm();
            addFormPresenter.AddFormMethod();
            addFormPresenter.LoadAddForm();
            this.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
