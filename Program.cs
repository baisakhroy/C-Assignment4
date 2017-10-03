using System;
using System.Collections.Generic;
using System.Linq;

namespace C_Assignment4
{
    


 
     
     
     





   public class Program
    {
        static void Main()
        {
            int opt;
          Display disp = new Display();
          start:
            Console.WriteLine("You are getting into a gigantic program. What do you wanna do????");
            Console.WriteLine("1.Display all the products");
            Console.WriteLine("2.Display all the products after sorting");
            Console.WriteLine("3.Display searched items");
            Console.WriteLine("4.Display the products after deleting");
            opt= int.Parse(Console.ReadLine());

            switch (opt){
                case 1:
                disp.Displayall();
                 break;
                case 2:
                disp.Displayaftersorting();
                break;
                case 3:
                Console.WriteLine("Enter the keyword that you want to search");
                string s=Console.ReadLine();
                disp.Displayaftersearching(s);
                break;
                case 4:
                Console.WriteLine("Enter the position of the item that you want to delete");
                int x = int.Parse(Console.ReadLine());
                disp.Displayafterdeleting(x);
                break;
                default:
                Console.WriteLine("Your choice donot exist. Please make a proper choice");
                goto start;
            }
            
        }     

            

            

    }
}

