using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        Welcome.welcome();
        string ans = "";
        do{
            Welcome.options();
            Console.WriteLine("What would you like to do? type 'quit' to quit");
            ans = Console.ReadLine();
            Actions.action(ans);
        }while(ans != "quit");
    }

}