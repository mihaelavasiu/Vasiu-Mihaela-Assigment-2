using Assigment1.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment1.Presenter
{
    public class UpdateOrderPresenter
    {
        private UpdateOrder updateOrderView;
        private UpdateOrderRepository updateOrderRepository;

        public UpdateOrderPresenter(UpdateOrder updateOrderView, UpdateOrderRepository updateOrderRepository)
        {
            this.updateOrderView = updateOrderView;
            this.updateOrderRepository=updateOrderRepository;           
        }
        public void btnAdd_Click()
        {
            updateOrderRepository.btnAdd_Click();
        }

        public void UpdateOrder_Load()
        {
            updateOrderRepository.UpdateOrder_Load();
        }     
    }
}
