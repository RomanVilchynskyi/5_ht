using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

class DictionaryApp
{
    static Dictionary<string, List<string>> dictionary = new();
    static string filePath;
    static string dictionaryType;

    static void ChooseDictionaryType()
    {
        Console.WriteLine("Choose dictionary type:");
        Console.WriteLine("1. Ukrainian-English");
        Console.WriteLine("2. English-Ukrainian");
        Console.Write("Your choice: ");

        string choice = Console.ReadLine();
        if (choice == "1")
        {
            dictionaryType = "Ukrainian-English";
            filePath = "ua-en_dictionary.json";
        }
        else
        {
            dictionaryType = "English-Ukrainian";
            filePath = "en-ua_dictionary.json";
        }
    }

    static void AddWord()
    {
        Console.Write("Enter word: ");
        string word = Console.ReadLine();
        Console.Write("Enter translation: ");
        string translation = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(word) || string.IsNullOrWhiteSpace(translation))
        {
            Console.WriteLine("Word and translation cannot be empty");
            return;
        }

        if (!dictionary.ContainsKey(word))
            dictionary[word] = new List<string>();

        if (!dictionary[word].Contains(translation))
            dictionary[word].Add(translation);
        else
            Console.WriteLine("Translation already exists for this word");
    }

    static void ReplaceWord()
    {
        Console.Write("Enter the word to replace: ");
        string oldWord = Console.ReadLine();

        if (!dictionary.ContainsKey(oldWord))
        {
            Console.WriteLine("Word not found");
            return;
        }

        Console.Write("Enter the new word: ");
        string newWord = Console.ReadLine();

        if (dictionary.ContainsKey(newWord))
        {
            Console.WriteLine("This word already exists");
            return;
        }

        dictionary[newWord] = dictionary[oldWord];
        dictionary.Remove(oldWord);
    }

    static void ReplaceTranslation()
    {
        Console.Write("Enter word: ");
        string word = Console.ReadLine();

        if (!dictionary.ContainsKey(word))
        {
            Console.WriteLine("Word not found!");
            return;
        }

        Console.Write("Enter old translation: ");
        string oldTranslation = Console.ReadLine();

        if (!dictionary[word].Contains(oldTranslation))
        {
            Console.WriteLine("Translation not found!");
            return;
        }

        Console.Write("Enter new translation: ");
        string newTranslation = Console.ReadLine();

        dictionary[word].Remove(oldTranslation);
        dictionary[word].Add(newTranslation);
    }

    

    static void Main()
    {
        ChooseDictionaryType();
        

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Dictionary Type: " + dictionaryType);
            Console.WriteLine("1 Add Word");
            Console.WriteLine("2 Replace Word");
            Console.WriteLine("3 Replace Translation");
            Console.WriteLine("4 Delete Word/Translation");
            Console.WriteLine("5 Search Translation");
            Console.WriteLine("6 Export Word");
            Console.WriteLine("7 Exit");
            Console.Write("Choose an option: ");

            switch (Console.ReadLine())
            {
                case "1": AddWord(); break;
                case "2": ReplaceWord(); break;
                case "3": ReplaceTranslation(); break;
                case "4": DeleteWordOrTranslation(); break;
                case "5": SearchWord(); break;
                case "6": ExportWord(); break;
                case "7": SaveDictionary(); return;
                default: Console.WriteLine("Invalid choice"); break;
            }
            
        }
    }

    
}
