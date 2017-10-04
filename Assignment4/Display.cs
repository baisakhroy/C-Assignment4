using System;
using System.Collections.Generic;
using System.Linq;

namespace C_Assignment4{

class Display{


public void Displayall(){

    try{

ProductDetailsFill objProductDetailsFill = new ProductDetailsFill();
List<Productgroup> ProductGrouplist = objProductDetailsFill.Productgroupfill();
List<Productinfo> Productinfolist = objProductDetailsFill.Productfill();

foreach(Productgroup pg in ProductGrouplist){
    foreach(Productinfo pi in Productinfolist){
        if(pg.GroupID==pi.GroupID){
            int indexofitem = Productinfolist.IndexOf(pi);
            Console.WriteLine("Index: {0} || Product GroupName: {1} || Product Name: {2} || Product Description: {3} || Product Rate: {4}",indexofitem, pg.Name,pi.Name,pi.Description,pi.Rate);
        }
}
}
    }
    catch(Exception e){
        Console.WriteLine(e.Message);
    }
}
public void Displayaftersorting(){
    try{
    ProductDetailsFill objProductDetailsFill = new ProductDetailsFill();
    List<Productinfo> Productinfolist = objProductDetailsFill.Productfill();
    List<Productgroup> ProductGrouplist = objProductDetailsFill.Productgroupfill();
    IEnumerable<Productinfo> productinfo =  objProductDetailsFill.Productsort(Productinfolist);
     List<Productinfo> Productinfolistaftersorted = productinfo.ToList();
     
foreach(Productinfo pi in Productinfolistaftersorted){
    foreach(Productgroup pg in ProductGrouplist){
    
        if(pg.GroupID==pi.GroupID){
            int indexofitem = Productinfolistaftersorted.IndexOf(pi);
            Console.WriteLine("Index:{0} || Product GroupName: {1} || Product Name: {2} || Product Description: {3} || Product Rate: {4}",indexofitem, pg.Name,pi.Name,pi.Description,pi.Rate);
        }
}
}
}
catch(Exception e){
    Console.WriteLine(e.Message);
}
}
public void Displayafterdeletingbyindex(int index_to_be_deleted){
    try{
    ProductDetailsFill objProductDetailsFill = new ProductDetailsFill();
    List<Productinfo> Productinfolist = objProductDetailsFill.Productfill();
    List<Productgroup> ProductGrouplist = objProductDetailsFill.Productgroupfill();

        if(index_to_be_deleted>Productinfolist.Count()){
            throw new Exception ("The list donot contain these many values");
            
        }

    List<Productinfo> ProductDeletedlist = objProductDetailsFill.DeleteProduct(Productinfolist,index_to_be_deleted);
    foreach(Productgroup pg in ProductGrouplist){
    foreach(Productinfo pi in ProductDeletedlist){
        if(pg.GroupID==pi.GroupID){
            int indexofitem = ProductDeletedlist.IndexOf(pi);
            Console.WriteLine("Index: {0} || Product GroupName: {1} || Product Name: {2} || Product Description: {3} || Product Rate: {4}",indexofitem, pg.Name,pi.Name,pi.Description,pi.Rate);
        }
}
} 
    }
    catch(Exception e){
        Console.WriteLine(e.Message);
    }
}

public void Displayafterdeletingbyname(string str){
try{
    int index = 0;
     ProductDetailsFill objProductDetailsFill = new ProductDetailsFill();
    List<Productinfo> Productinfolist = objProductDetailsFill.Productfill();
    List<Productgroup> ProductGrouplist = objProductDetailsFill.Productgroupfill();

    foreach(Productinfo pi in Productinfolist){
        if (str==pi.Name){
             index = Productinfolist.IndexOf(pi);
             break;
            }
    }
    if(index==0){
        throw new Exception ("The product you entered does not exist in the list.");
    }

    List<Productinfo> Productinfolistafterdeletingbyname = objProductDetailsFill.DeleteProductbyname(Productinfolist, index);
        foreach(Productgroup pg in ProductGrouplist){
            foreach(Productinfo pi in Productinfolistafterdeletingbyname){
                if(pg.GroupID==pi.GroupID){
                  int  indexofitem = Productinfolistafterdeletingbyname.IndexOf(pi);
            Console.WriteLine("Index: {0} || Product GroupName: {1} || Product Name: {2} || Product Description: {3} || Product Rate: {4}",indexofitem, pg.Name,pi.Name,pi.Description,pi.Rate);
        }
            }
        }

    
}
catch(Exception e){
     Console.WriteLine(e.Message);

}
}
public void Displayaftersearching(string str){

    try{
        
        ProductDetailsFill objProductDetailsFill = new ProductDetailsFill();
    List<Productinfo> Productinfolist = objProductDetailsFill.Productfill();
    List<Productgroup> ProductGrouplist = objProductDetailsFill.Productgroupfill();
   var infosearch = Productinfolist.Where(p=>p.Name.ToUpper().Contains(str.ToUpper()));
   List<Productinfo> Productinfolistaftersearching = infosearch.ToList();
   if(infosearch.Count()<1){
       Console.WriteLine("The list donot contain the product that you are searching for. ");
   }
   else{
   foreach(Productgroup pg in ProductGrouplist ){
   foreach(var pi in Productinfolistaftersearching){
       if(pg.GroupID==pi.GroupID){

      int indexofitem = Productinfolistaftersearching.IndexOf(pi);
        Console.WriteLine("Index: {0} || Product GroupName: {1} || Product Name: {2} || Product Description: {3} || Product Rate: {3}",indexofitem, pg.Name,pi.Name,pi.Description,pi.Rate);
       }
   }
   }
} 
}
catch(Exception e){
    Console.WriteLine(e.Message);
}
}
}
}