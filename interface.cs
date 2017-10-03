using System;
using System.Collections.Generic;
namespace C_Assignment4 {
interface IProduct{
     List<Productgroup> Productgroupfill();
    List<Productinfo> Productfill();
    IEnumerable<Productinfo> Productsort(List<Productinfo> PI);

    List<Productinfo> Productdelete(List<Productinfo> PD1, int x);


}



public class ProductDetailsFill:IProduct{
public List<Productgroup>  Productgroupfill()
          {
                Productgroup PG1 = new Productgroup(){
                    GroupID= 1,
                    Name="Dairy"
                };

                Productgroup PG2 = new Productgroup(){
                    GroupID= 2,
                    Name="Chocolate"
                };
                List<Productgroup> PGlist = new List<Productgroup>();
                PGlist.Add(PG1);
                PGlist.Add(PG2);

                return PGlist;
            }   
        public List<Productinfo> Productfill(){
                Productinfo PI1 = new Productinfo(){
                    GroupID=Searchgroupid.Searchid("Dairy"),
                    ID=1,
                    Name="Go-Cheese",
                    Description="Go-Cheese-180g",
                    Rate=115
                };
                Productinfo PI2 = new Productinfo(){
                    GroupID=Searchgroupid.Searchid("Dairy"),
                    ID=2,
                    Name="Amul-Cheese",
                    Description="Amul-Cheese-210g",
                    Rate=125
                };
                Productinfo PI3 = new Productinfo(){
                    GroupID=Searchgroupid.Searchid("Dairy"),
                    ID=3,
                    Name="Britania-Cheese",
                    Description="Britania-Cheese-200g",
                    Rate=100
                };
                Productinfo PI4 = new Productinfo(){
                    GroupID=Searchgroupid.Searchid("Chocolate"),
                    ID=4,
                    Name="Arindam-Chocolate",
                    Description="Arindam-Chocolate-250g",
                    Rate=250
                };
                Productinfo PI5 = new Productinfo(){
                    GroupID=Searchgroupid.Searchid("Chocolate"),
                    ID=5,
                    Name="Shashank-Chocolate",
                    Description="Shashank-Chocolate-500g",
                    Rate=300
                };
                List<Productinfo> PIlist = new List<Productinfo>();
                PIlist.Add(PI1);
                PIlist.Add(PI2);
                PIlist.Add(PI3);
                PIlist.Add(PI4);
                PIlist.Add(PI5);

                return PIlist;

}
public IEnumerable<Productinfo> Productsort(List<Productinfo> PI){

             
            PI.Sort((x,y)=>x.Name.CompareTo(y.Name));

            return PI;

            }    

            public List<Productinfo> Productdelete(List<Productinfo> PD, int x){
                    PD.RemoveAt(x);
                    return PD;
            }

}
}