using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assigment1;

namespace Assigment1Test
{
    [TestClass]
    public class AssigmentTests
    {
        [TestMethod]
        public void testAddMethod()
        {
            Product p = new Product();
            p.Title = "Test product";
            p.Description = "Test description";
            p.Color = "Test color";
            p.Size = 24;
            p.Price = 24;
            p.Stock = 24;
            MySQLDBManager manager = new MySQLDBManager();
            manager.Create(p);
            Product p1 = manager.SelectProduct(p);
            Assert.AreEqual(p.Title, p1.Title);
            Assert.AreEqual(p.Description, p1.Description);
            Assert.AreEqual(p.Color, p1.Color);
            Assert.AreEqual(p.Size, p1.Size);
            Assert.AreEqual(p.Price, p1.Price);
            Assert.AreEqual(p.Stock, p1.Stock);
        }
    }
}
