using System;
using System.Collections.Generic;
using System.Linq;

namespace C_Assignment4{

public class Searchgroupid {
   static public int Searchid(string groupname){
         ProductDetailsFill objProductDetailFill = new ProductDetailsFill();
     
          List<Productgroup> ProductGroup = objProductDetailFill.Productgroupfill();

         foreach(Productgroup p in ProductGroup){
             if(groupname==p.Name){
                 return p.GroupID;
             }
             
         }
         return 0;
     }
     
 }
}
 