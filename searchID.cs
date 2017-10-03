using System;
using System.Collections.Generic;
using System.Linq;

namespace C_Assignment4{

class Searchgroupid {
   static public int Searchid(string x){
         ProductDetailsFill obj = new ProductDetailsFill();
     
          List<Productgroup> prgp = obj.Productgroupfill();

         foreach(Productgroup p in prgp){
             if(x==p.Name){
                 return p.GroupID;
             }
             
         }
         return 0;
     }
     
 }
}
 