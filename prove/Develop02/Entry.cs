public class Entry{
    public string date;
    public string prompt;

    public string response;


    public Entry(string randPromt){
        prompt = randPromt;

        
        date = DateTime.Today.ToString("d");
        Console.Write($"{randPromt}\n> ");
        response = Console.ReadLine();
        //Console.WriteLine(date);

    }

    

    public Entry(string one, string two, string three){
        date = one;
        prompt = two;
        response = three;

    }
    public string display(){
        return $"Date: {date}\npromt: {prompt}\nResponse: {response}\n";
    }

    public string Load(){
        return $"{date},{prompt},{response}";
    }
        
}
