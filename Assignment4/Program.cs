using System;
using System.Collections.Generic;
using System.Linq;

namespace C_Assignment4
{
   public class Program
    {
        static void Main()
        {
            while(true){
            try{
            
            int opt;
          Display objdisplay = new Display();
 
          Console.WriteLine("------------------------------------------------------------------------------");
          
          start:
            Console.WriteLine("You are getting into a gigantic program. What do you wanna do????");
            Console.WriteLine("Press [1] to Display all the products in the product list");
            Console.WriteLine("Press [2] to Display all the products in the product list after sorting");
            Console.WriteLine("Press [3] to Display searched items from the product list");
            Console.WriteLine("Press [4] to Display the products after deleting by index from the product list");
            Console.WriteLine("Press [5] to Display the products after deleting by name from the product list");
            Console.WriteLine("Press [6] to Run Awaaayyyyyyyyy");
            opt= int.Parse(Console.ReadLine());

            

            switch (opt){
                case 1:
                objdisplay.Displayall();
                 break;
                case 2:
                objdisplay.Displayaftersorting();
                break;
                case 3:
                Console.WriteLine("Enter the Product Name or a part of the Product Name that you want to search");
                string str1=Console.ReadLine();
                objdisplay.Displayaftersearching(str1);
                break;
                case 4:
                Console.WriteLine("Enter the position of the item that you want to delete");
                int position = int.Parse(Console.ReadLine());
                objdisplay.Displayafterdeletingbyindex(position);
                break;
                case 5:
                Console.WriteLine("Enter the name of the item you want to delete");
                string str2 = Console.ReadLine();
                objdisplay.Displayafterdeletingbyname(str2);
                break;
                case 6:
                return;
                
                default:
                Console.WriteLine("Your choice donot exist. Please make a proper choice");
                goto start;
            }
        cont:
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("Do you want to continue??(yes/no)");
            string str3 = Console.ReadLine().ToUpper();
            if(str3=="YES"){
                Console.WriteLine("------------------------------------------------------------------------------");
                goto start;
            }
            else if(str3=="NO")
            return;
            else
            {
                Console.WriteLine("Make a proper choice.");
                goto cont;
            }
            
        } catch(Exception e) {

            Console.WriteLine("{0}. Please enter an intiger",e.Message);

        }    
            }

            

            
        }
    }
}

