using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assigment1.Views
{
    public interface IAddForm
    {
        void AddForm_Load(object sender, EventArgs e);


        void btnAdd_Click(object sender, EventArgs e);


        void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e);

    }
}