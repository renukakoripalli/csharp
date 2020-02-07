using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy_consoleApplication
{
    class ProductBo
    {

        public void ElectronicProductList()
        {

            List<ProductList> ElectronicGoods = new List<ProductList>() {
        new ProductList() { pId= 1, ProductName = "MSI Laptop GL63 8RCS 058MY", UnitPrice = 2999.00M,productquantity=10},
        new ProductList() { pId = 2, ProductName = "MSI Laptop GL63 8RC 057MY", UnitPrice = 3799.00M,productquantity=20},
        new ProductList() { pId= 3, ProductName = "Logitech M330 Wireless Mouse", UnitPrice = 59.00M,productquantity=50},
        new ProductList() { pId = 4, ProductName = "Mechanical Keyboard with Backlight", UnitPrice = 160.00M,productquantity=70},
        new ProductList() { pId= 5, ProductName = "Dell Wireless Keyboard and Mouse Combo ", UnitPrice = 70.00M,productquantity=100}
             };
            foreach (ProductList list1 in ElectronicGoods)
            {
                Console.WriteLine(list1.pId + " " + list1.ProductName + "" + list1.UnitPrice + "" + list1.productquantity);
            }

        }
        public void TvsAppliancesList()
        {

            List<ProductList> TvAppliances = new List<ProductList>() {
        new ProductList() { pId= 1, ProductName = "SUMSUNG", UnitPrice = 2990.00M,productquantity=10},
        new ProductList() { pId = 2, ProductName = "LG", UnitPrice = 3899.00M,productquantity=20},
        new ProductList() { pId= 3, ProductName = "SONY", UnitPrice = 60.00M,productquantity=50},
        new ProductList() { pId = 4, ProductName = "MI", UnitPrice = 170.00M,productquantity=70},
        new ProductList() { pId= 5, ProductName = "PANASONIC ", UnitPrice = 65.00M,productquantity=100}
             };
            foreach (ProductList list1 in TvAppliances)
            {
                Console.WriteLine(list1.pId + " " + list1.ProductName + "" + list1.UnitPrice + "" + list1.productquantity);
            }

        }
        

    }
}