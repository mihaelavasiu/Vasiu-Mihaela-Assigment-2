using Assigment1.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment1.Presenter
{
    public  class DeleteProductPresenter
    {
        private DeleteProduct deleteProductView;
        private DeleteProductRepository deleteProductRepository;

        public DeleteProductPresenter(DeleteProduct deleteProductView, DeleteProductRepository deleteProductR)
        {
            this.deleteProductView = deleteProductView;
            deleteProductRepository=deleteProductR;           
        }
         public void btnAdd_Click()
        {
            deleteProductRepository.btnAdd_Click();
        }


        public void DeleteProduct_Load()
        {
            deleteProductRepository.DeleteProduct_Load();
        }
   
    }
}
