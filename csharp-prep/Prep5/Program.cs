using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        
        string username  = PromptUserName();
        int number = PromptUserNumber();
        DisplayResult(username, SquareNumber(number));
        
        
        void DisplayWelcome(){
            Console.WriteLine("Welcome to the Program!");
        }

        string PromptUserName(){
            Console.Write("Please enter your name: ");
            return Console.ReadLine();
        }
        int PromptUserNumber(){
            Console.Write("Please enter your favorite number: ");
            return int.Parse(Console.ReadLine());
        }
        
        int SquareNumber(int x){
            return x * x;
        }
        void DisplayResult(string name,int num){
            Console.WriteLine($"{name}, the square of your number is {num}");
        }

    } 
}