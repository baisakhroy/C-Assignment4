using System;
using System.Collections.Generic;
using System.Linq;

namespace C_Assignment4{

class Display{


public void Displayall(){

ProductDetailsFill pdf = new ProductDetailsFill();
List<Productgroup> prgp = pdf.Productgroupfill();
List<Productinfo> prin = pdf.Productfill();

foreach(Productgroup pg in prgp){
    foreach(Productinfo pi in prin){
        if(pg.GroupID==pi.GroupID){
            Console.WriteLine("{0} {1} {2} {3}", pg.Name,pi.Name,pi.Description,pi.Rate);
        }
}
}
}
public void Displayaftersorting(){
    ProductDetailsFill pdf = new ProductDetailsFill();
    List<Productinfo> prin = pdf.Productfill();
    List<Productgroup> prgp = pdf.Productgroupfill();
    IEnumerable<Productinfo> pinfo =  pdf.Productsort(prin);
    foreach(Productgroup pg in prgp){
    foreach(Productinfo pi in pinfo){
        if(pg.GroupID==pi.GroupID){
            Console.WriteLine("{0} {1} {2} {3}", pg.Name,pi.Name,pi.Description,pi.Rate);
        }
}
}
}
public void Displayafterdeleting(int x){
    
    ProductDetailsFill pdf = new ProductDetailsFill();
    List<Productinfo> prin = pdf.Productfill();
    List<Productgroup> prgp = pdf.Productgroupfill();

        if(x>=prin.Count()){
            throw new Exception ("The list donot contain these many values");
            
        }

    List<Productinfo> pdel = pdf.Productdelete(prin,x);
    foreach(Productgroup pg in prgp){
    foreach(Productinfo pi in pdel){
        if(pg.GroupID==pi.GroupID){
            Console.WriteLine("{0} {1} {2} {3}", pg.Name,pi.Name,pi.Description,pi.Rate);
        }
}
}

}
public void Displayaftersearching(string s){
        
        ProductDetailsFill pdf = new ProductDetailsFill();
    List<Productinfo> prin = pdf.Productfill();
    List<Productgroup> prgp = pdf.Productgroupfill();
   var infosrch = prin.Where(p=>p.Name.ToUpper().Contains(s.ToUpper()));
   if(infosrch.Count()<1){
       Console.WriteLine("The list donot contain the product that you are searching for. ");
   }
   else{
   foreach(Productgroup pg in prgp ){
   foreach(var pi in infosrch){
       if(pg.GroupID==pi.GroupID){
        Console.WriteLine("{0} {1} {2} {3}", pg.Name,pi.Name,pi.Description,pi.Rate);
       }
   }
   }
}
}
}
}