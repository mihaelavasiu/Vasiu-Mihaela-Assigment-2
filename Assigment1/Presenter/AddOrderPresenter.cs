using Assigment1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment1.Presenter
{
    public class AddOrderPresenter
    {
        private AddOrder addOrderView;
        private AddOrderRepository addOrderRepository;

         public AddOrderPresenter(AddOrder addOrderView, AddOrderRepository addOrderR)
        {
            this.addOrderView = addOrderView;
            addOrderRepository=addOrderR;           
        }
        public void AddOrderMethod(){
             addOrderRepository.AddOrder();
        }
        public void LoadAdOrder(){
            addOrderRepository.LoadAddOrder();
        }
    }
}
