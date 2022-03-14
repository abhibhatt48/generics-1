using System;  
using System.Collections.Generic; 

namespace src
{
    public class Program
    
    {
       public static void Main(string[] args)  
    {  
        var prod = new Dictionary<string, List<Product>>(); 

        prod.Add("Leafy green", new List<Product>()) ;
        prod.Add("Cruciferous", new List<Product>()) ;
        prod.Add("Marrow", new List<Product>()) ;
        prod.Add("Root", new List<Product>()) ;
        

        prod["Leafy green"].Add (new Product { pname = "lettuce", price = "10.5 RS", quantity= 50 , type = "Leafy green" });
        prod["Leafy green"].Add (new Product { pname = "spinach", price = "10 RS", quantity= 100 , type = "Leafy green" });
        prod["Leafy green"].Add (new Product { pname = "garlic", price = "30 RS", quantity= 20 , type = "Leafy green" });

        int count = prod["Leafy green"].Count;


        prod["Cruciferous"].Add (new Product { pname = "cabbage", price = "20 RS", quantity = 100 , type = "Cruciferous" });
        prod["Cruciferous"].Add (new Product { pname = "cauliflower", price = "10 RS", quantity = 25, type = "Cruciferous" });
        prod["Cruciferous"].Add (new Product { pname = "broccoli", price = "20.2 RS", quantity = 75, type = "Cruciferous" });

        int count1 = prod["Cruciferous"].Count;

        prod["Marrow"].Add (new Product { pname = "pumpkin", price = "30 RS", quantity = 30 , type = "Marrow" });
        prod["Marrow"].Add (new Product { pname = "zucchini", price = "20.5 RS", quantity = 50, type = "Marrow" });
        prod["Marrow"].Add (new Product { pname = "silverbeet", price = "10 RS", quantity = 50, type = "Marrow" });

        int count2 = prod["Marrow"].Count;

        prod["Root"].Add (new Product { pname = "yam", price = "30 RS", quantity = 50, type = "Root" });
        
        int count3 = prod["Root"].Count;
        int total = count + count1 + count2 + count3;
        int quntity = y+z;
        int z = 100;

        
        Console.WriteLine("total product is: "  + total);

                System.Console.WriteLine("enter any one value from 1.Leafy green 2.Cruciferous 3.Marrow 4.Root");
   
                System.Console.WriteLine("enter type name to search it :  ") ;
                
                var a = Console.ReadLine() ;
        
        if (a == "Leafy green")
        {
            foreach (var item1 in prod)
            { 
                if (a == item1.Key)
                {
                    foreach(var b in item1.Value)
                 {
                     Console.WriteLine(" \n product name: " + b.pname + " \n product price: " + b.price + " \n product quantity: "+ b.quantity + "\n");
                 }
                }                    
            }    
        }
        else if (a == "Cruciferous")
        {
            foreach (var item2 in prod)
            {
                if (a == item2.Key)
                {
                    foreach(var c in item2.Value)
                 {
                     Console.WriteLine(" \n product name: " + c.pname + " \n product price: " + c.price + " \n product quantity: "+ c.quantity + "\n");
                 }
                }        
            }    
        }
        else if (a == "Marrow")
        {
            foreach (var item3 in prod)
            {
                if (a == item3.Key)
                {
                    foreach(var d in item3.Value)
                 {
                     Console.WriteLine(" \n product name: " + d.pname + " \n product price: " + d.price + " \n product quantity: "+ d.quantity + "\n");
                 }
                }                   
            }    
        }
        else if (a == "Root")
        {
            foreach (var item4 in prod)
            {
                if (a == item4.Key)
                {
                    foreach(var e in item4.Value)
                 {
                     Console.WriteLine(" \n product name: " + e.pname + " \n product price: " + e.price + " \n product quantity: "+ e.quantity + "\n");
                 }
                }                  
            }    
        }
        else 
        {
            System.Console.WriteLine("you can't search it");

        }

        System.Console.WriteLine("if you want to add potato press 1 press 2 to remove garlic");
        int x = Convert.ToInt32(Console.ReadLine());

        if (x == 1)
        {
            prod["Root"].Add (new Product { pname = "Potato", price = "10 RS", quantity = 50, type = "Root" });
            int count4 = prod["Root"].Count;
            int t = count + count1 + count2 + count4;
            foreach (var item in prod)  
        {  
            Console.WriteLine(item.Key); 
            foreach (var pro in item.Value) 
            {
                
               
             Console.WriteLine(" \n product name: " + pro.pname + " \n product price: " + pro.price + " \n product quantity: "+ pro.quantity + "\n product type" + pro.type + "\n");

             
            }
            
        }Console.WriteLine("total product is: "  + t); 
        } 
        else if (x == 2)
        {    
            //prod["Leafy green"].Remove (new Product { pname = "garlic", price = "30 RS", quantity= 20 , type = "Leafy green" });
        }
        else 
        {
            System.Console.WriteLine("you can't add potato");
        }
        System.Console.WriteLine("add number of cabbage you want : ");
        int y = Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine("final cabbage in inventory after added by user:" );    
    }
       

        
    }  
    
}

    