using С__final;

class Program
{
    static void Main()
    {
        Console.WriteLine("Choose dictionary type:");
        Console.WriteLine("1. Ukrainian-English");
        Console.WriteLine("2. English-Ukrainian");
        Console.Write("Your choice: ");

        string filePath;
        string choice = Console.ReadLine()!;
        if (choice == "1")
            filePath = "ua-en_dictionary.json";
        else
            filePath = "en-ua_dictionary.json";

        DictionaryManager dictionaryManager = new();
        FileManager fileManager = new(filePath);
        UserInterface userinterface = new(dictionaryManager, fileManager);
        userinterface.Work();
    }
}
