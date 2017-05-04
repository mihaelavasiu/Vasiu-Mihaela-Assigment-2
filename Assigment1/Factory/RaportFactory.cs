using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assigment1.Factory
{
    public class RaportFactory
    {
        public static List<Report> LoadReport(GenerateReport activity)
        {
            List<Report> reports = new List<Report>();
           try
            {
                int id = Convert.ToInt32(activity.txtID.Text);
                DateTime d1 = activity.dateTimePicker1.Value;
                DateTime d2 = activity.dateTimePicker2.Value;
                string connString = "datasource=127.0.0.1;port=3306;username=root;password=;database=assigment1;";             
                Report raport;
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT `id`, `name`, `description`, `date`, `employee_id` FROM `activities` WHERE employee_id=@id AND date>@d1 AND date<@d2;";
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@d1", d1);
                    cmd.Parameters.AddWithValue("@d2", d2);
                    cmd.Prepare();


                    using (MySqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            string idc = rdr["id"].ToString();
                            string namec = rdr["name"].ToString();
                            string descriptionc = rdr["description"].ToString();
                            string datec = rdr["date"].ToString();
                            string employeec = rdr["employee_id"].ToString();
                            raport = new Report(idc, namec, descriptionc, datec, employeec);
                            reports.Add(raport);


                        }
                       
                    }
                }
            }
           catch (Exception ex)
           {
               MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
           return reports;
        }
    }
}
