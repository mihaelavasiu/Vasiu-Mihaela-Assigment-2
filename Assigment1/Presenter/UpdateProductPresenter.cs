using Assigment1.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment1.Presenter
{
    public class UpdateProductPresenter
    {
        private UpdateProduct updateProductView;
        private UpdateProductRepository updateProductRepository;

        public UpdateProductPresenter(UpdateProduct updateProductView, UpdateProductRepository updateProductRepository)
        {
            this.updateProductView = updateProductView;
            this.updateProductRepository=updateProductRepository;           
        }
        public void UpdateProduct_Load()
        {
            updateProductRepository.UpdateProduct_Load();
        }

        public void btnAdd_Click()
        {
            updateProductRepository.btnAdd_Click();
        }
    }
}
