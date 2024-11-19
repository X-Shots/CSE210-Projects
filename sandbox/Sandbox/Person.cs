public class Person{
    int age;
    static int llmao;
    public Person(){
        Console.WriteLine("What is your age? ");
        age = Int32.Parse(Console.ReadLine());
    }
    public int getAge(){
        return age;
    }

}