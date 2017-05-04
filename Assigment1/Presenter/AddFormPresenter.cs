using Assigment1.Model;
using Assigment1.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment1.Presenter
{
    public class AddFormPresenter
    {
        private AddForm addFormView;
        private AddFormRepository addFormRepository;

        public AddFormPresenter(AddForm addFormView, AddFormRepository addFormR)
        {
            this.addFormView = addFormView;
            addFormRepository=addFormR;           
        }
        public void AddFormMethod(){
             addFormRepository.AddForm();
        }
        public void LoadAddForm(){
            addFormRepository.LoadAddForm();
        }
    }
}
