using Assigment1.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment1.Presenter
{
    public class RegisterPresenter
    {
        private Register registerView;
        private RegisterRepsitory registerRepository;

        public RegisterPresenter(Register registerView, RegisterRepsitory registerRepository)
        {
            this.registerView = registerView;
            this.registerRepository=registerRepository;           
        }
        public void btnAdd_Clickkk()
        {
            registerRepository.btnAdd_Clickkk();
        }
    }
}
