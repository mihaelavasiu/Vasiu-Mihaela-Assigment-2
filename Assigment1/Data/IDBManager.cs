using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment1
{
    public interface IDBManager
    {
        void RegisterUser(UserModel user);
        void Create(ProductModel product);
        void Update(ProductModel product);
        void UpdateOrder(OrderModel order);
        void AddOrder(OrderModel order);
        void ModifyOrder(OrderModel order, int addPieces);
        void AddEmployee(EmployeeModel e);
        void UpdateEmployee(EmployeeModel e);
        void DeleteEmployee(EmployeeModel e);
        ProductModel SelectProduct(ProductModel p);

    }
}
