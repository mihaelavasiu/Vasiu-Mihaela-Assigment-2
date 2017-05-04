﻿using Assigment1.Model;
using Assigment1.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assigment1
{
    public partial class Admin : Form
    {
        public Admin()
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

        private void button1_Click(object sender, EventArgs e)
        {
            var crudForm = new CrudForm();
            var crudFormRepository = new CrudFormRepository(crudForm);
            var crudFormPresenter = new CrudFormPresenter(crudForm, crudFormRepository);
            crudFormPresenter.CrudForm_Load();
            crudForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GenerateReport r = new GenerateReport();
            r.Show();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }
    }
}
