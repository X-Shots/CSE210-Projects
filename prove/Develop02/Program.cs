// showed creativity by adding a counter that reports the total amount of journal reposnses weather they are saved or not.

using System;
using System.Globalization;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        
        Journal journal = new Journal();

        string num = "";

        while (num != "5"){
            
            Console.WriteLine("\nWhat would you like to do?(Enter as a single number)");
            Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\n>");
            num = Console.ReadLine();
            Console.WriteLine();
            
            if(num == "1" ){
                journal.getEntry();
            }
            else if (num == "2" ){
                journal.display();
            }
            else if ( num == "3"){
                Console.WriteLine("What file name would you like to load?");
                string name = Console.ReadLine();
                
                journal.loadFile(name);
            }
            else if (num == "4"){
                Console.WriteLine("What name would you like on that file?");
                string name = Console.ReadLine();
                
                journal.saveToFile(name);
            }
            else if (num != "5"){
                Console.WriteLine("Invalid input please try again.");
            }
        }


        

        
        
       
    }
}