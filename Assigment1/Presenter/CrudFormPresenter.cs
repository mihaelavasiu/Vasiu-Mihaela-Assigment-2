using Assigment1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment1.Presenter
{
    public class CrudFormPresenter
    {
        private CrudForm crudFormView;
        private CrudFormRepository crudFormRepository;

        public CrudFormPresenter(CrudForm crudFormView1, CrudFormRepository crudFormR)
        {
            this.crudFormView = crudFormView1;
            this.crudFormRepository = crudFormR;
        }
        public void CrudForm_Load()
        {
            crudFormRepository.CrudForm_Load();
        }

        public void btnAdd_Click()
        {
            crudFormRepository.btnAdd_Click();
        }

        public void button3_Click()
        {
            crudFormRepository.button3_Click();
        }

        public void button1_Click()
        {
            crudFormRepository.button1_Click();
        }

        public void button2_Click()
        {
            crudFormRepository.button2_Click();
        }

       
    }
}
