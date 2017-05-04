using Assigment1.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment1.Presenter
{
    public class ModifyPresenter
    {
        private Modify modifyView;
        private ModifyRepository modifyRepository;

        public ModifyPresenter(Modify modifyView, ModifyRepository modifyRepository)
        {
            this.modifyView = modifyView;
            this.modifyRepository=modifyRepository;           
        }
        
        public void Modify_Load()
         {
             modifyRepository.Modify_Load();
         }


         public void btnAdd_Click_1()
         {
             modifyRepository.btnAdd_Click_1();
         }
    }
}
