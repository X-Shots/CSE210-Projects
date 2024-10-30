using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What grade did you recive? ");
        int num = int.Parse(Console.ReadLine());
        String letter = "";
        if(num >= 90){
            letter = "A";
        }
        else if(num >= 80){
            letter = "B";

        }
        else if(num >= 70){
            letter = "C";
        }
        else if(num >= 60){
            letter = "D";
        }
        else{
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}");
        if(num >= 70){
            Console.WriteLine("You passed the class!");
        }
        else {
            Console.WriteLine("You failed the class!");
        }


        // Stretch challenges 

        String grade = letter;

        int num2 = num%10;
        
        if(num < 97 && num > 59){
            if(num2 >= 7){
                grade = grade + "+";
            }
            else if (num2 < 3){
                grade = grade + "-";
            }
        }
        Console.WriteLine($"Your grade with +/- : {grade}");
    }
}

        





