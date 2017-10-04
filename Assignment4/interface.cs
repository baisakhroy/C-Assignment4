using System;
using System.Collections.Generic;
namespace C_Assignment4 {
interface IProduct{
     List<Productgroup> Productgroupfill();
    List<Productinfo> Productfill();
    IEnumerable<Productinfo> Productsort(List<Productinfo> PI);

    List<Productinfo> DeleteProduct(List<Productinfo> PD1, int x);


}




}