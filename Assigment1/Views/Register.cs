using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Assigment1.Data;
using Assigment1.Presenter;

namespace Assigment1
{
    public partial class Register : Form
    {
         MySqlConnection con;
        public Register()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // var addForm = new AddForm();
            var registerRepository = new RegisterRepsitory(this);
            var registerPresenter = new RegisterPresenter(this, registerRepository);
            // addFormPresenter.LoadAddForm();
            registerPresenter.btnAdd_Clickkk();
            this.Show();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
