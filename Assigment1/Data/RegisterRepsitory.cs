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
    public class RegisterRepsitory
    {
        MySqlConnection con;
        MySqlDataAdapter adapt;
        DataSet ds;
        int selectedRow;
        public Register registerView;
        private string connString = "datasource=127.0.0.1;port=3306;username=root;password=;database=assigment1;";
        int indexRow;
         public RegisterRepsitory(Register registerView)
        {
            this.registerView = registerView;
           
        }
         public void btnAdd_Clickkk()
         {
             try
             {
                 UserModel user = new UserModel();
                 user.UserName = registerView.txtUserName.Text;
                 user.Password = registerView.txtPassword.Text;
                 user.FistName = registerView.txtFirstName.Text;
                 user.LastName = registerView.textBox1.Text;
                 if (!(user.UserName.Equals("admin")))
                 {
                     IDBManager db = new MySQLDBManager();
                     db.RegisterUser(user);
                     MessageBox.Show("Successfully registered!", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     registerView.Hide();
                 }
                 else
                 {
                     MessageBox.Show("Invalid username!!!", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
         }
    }
}
