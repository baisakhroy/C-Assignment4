using System;
using System.Collections.Generic;
using System.Linq;

namespace C_Assignment4{

public class ProductDetailsFill:IProduct{
public List<Productgroup>  Productgroupfill()
          {
                Productgroup objProductgroup1 = new Productgroup(){
                    GroupID= 1,
                    Name="Dairy"
                };

                Productgroup objProductgroup2 = new Productgroup(){
                    GroupID= 2,
                    Name="Chocolate"
                };
                List<Productgroup> PGlist = new List<Productgroup>();
                PGlist.Add(objProductgroup1);
                PGlist.Add(objProductgroup2);

                return PGlist;
            }   
        public List<Productinfo> Productfill(){
                Productinfo objProductInfo1 = new Productinfo(){
                    GroupID=Searchgroupid.Searchid("Dairy"),
                    ID=1,
                    Name="Go-Cheese",
                    Description="Go-Cheese-180g",
                    Rate=115
                };
                Productinfo objProductInfo2 = new Productinfo(){
                    GroupID=Searchgroupid.Searchid("Dairy"),
                    ID=2,
                    Name="Amul-Cheese",
                    Description="Amul-Cheese-210g",
                    Rate=125
                };
                Productinfo objProductInfo3 = new Productinfo(){
                    GroupID=Searchgroupid.Searchid("Dairy"),
                    ID=3,
                    Name="Britania-Cheese",
                    Description="Britania-Cheese-200g",
                    Rate=100
                };
                Productinfo objProductInfo4 = new Productinfo(){
                    GroupID=Searchgroupid.Searchid("Chocolate"),
                    ID=4,
                    Name="Arindam-Chocolate",
                    Description="Arindam-Chocolate-250g",
                    Rate=250
                };
                Productinfo objProductInfo5 = new Productinfo(){
                    GroupID=Searchgroupid.Searchid("Chocolate"),
                    ID=5,
                    Name="Shashank-Chocolate",
                    Description="Shashank-Chocolate-500g",
                    Rate=300
                };
                List<Productinfo> ProductInfolist = new List<Productinfo>();
                ProductInfolist.Add(objProductInfo1);
                ProductInfolist.Add(objProductInfo2);
                ProductInfolist.Add(objProductInfo3);
                ProductInfolist.Add(objProductInfo4);
                ProductInfolist.Add(objProductInfo5);

                return ProductInfolist;

}
public IEnumerable<Productinfo> Productsort(List<Productinfo> ProductInfosorted){

             
            ProductInfosorted.Sort((x,y)=>x.Name.CompareTo(y.Name));

            return ProductInfosorted;

            }    

            public List<Productinfo> DeleteProduct(List<Productinfo> ProductDeletedlist, int index_to_be_deleted){
                    ProductDeletedlist.RemoveAt((index_to_be_deleted-1));
                    return ProductDeletedlist;
            }

            public List<Productinfo> DeleteProductbyname(List<Productinfo> Listtobedeletedbyname,int index){

                
                Listtobedeletedbyname.RemoveAt(index);
                return Listtobedeletedbyname;
            }

            public List<Productinfo> AddProduct(List<Productinfo> productinfo, Productinfo product_to_be_added){

                productinfo.Add(product_to_be_added);
                return productinfo;
            }

}


}