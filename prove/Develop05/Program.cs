using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
            while (!Actions.ShoudlQuit()){
            
            Console.WriteLine($"\nYou have {Goals.getScore()} points!");
            Console.WriteLine("\nMenu Options:\n  1. Create New Goal\n  2. List Goals\n  3. Save Goals\n  4. Load Goals\n  5. Record Event\n  6. Quit ");
            Console.WriteLine("Select a choice from the menu: ");
            Actions.runAction(Console.ReadLine());

        }
    }
}