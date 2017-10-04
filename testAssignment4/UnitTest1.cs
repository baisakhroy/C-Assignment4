using System;
using Xunit;
using C_Assignment4;
using System.Collections.Generic;
using System.Linq;
namespace testAssignment4
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
             Productinfo objProductInfo6 = new Productinfo(){
                 GroupID=Searchgroupid.Searchid("Dairy"),
                    ID=6,
                    Name="Kokarakko-Cheese",
                    Description="Kokkarakko-Cheese-180g",
                    Rate=300
             };  
                ProductDetailsFill objProdDetailsFill = new ProductDetailsFill();
                List<Productinfo> ProductInfo = objProdDetailsFill.Productfill();

                List<Productinfo> Productaddedlist = objProdDetailsFill.AddProduct(ProductInfo,objProductInfo6);
              int x =  Productaddedlist.Count();

              Assert.Equal(6,x);


        
        }
    }
}
