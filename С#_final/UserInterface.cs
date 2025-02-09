using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace С__final
{
    class UserInterface
    {
        private DictionaryManager dictionaryManager;
        private FileManager fileManager;

        public UserInterface(DictionaryManager dictionaryManager, FileManager fileManager)
        {
            this.dictionaryManager = dictionaryManager;
            this.fileManager = fileManager;
            dictionaryManager.SetDictionary(fileManager.LoadDictionary());
        }

        public void Work()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1 Add Word");
                Console.WriteLine("2 Replace Word");
                Console.WriteLine("3 Replace Translation");
                Console.WriteLine("4 Delete Word");
                Console.WriteLine("5 Delete Translation");
                Console.WriteLine("6 Search Word");
                Console.WriteLine("7 Export Word");
                Console.WriteLine("8 Exit");
                Console.Write("Choose an option: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Write("Enter word: ");
                        string word = Console.ReadLine()!;
                        Console.Write("Enter translation: ");
                        string translation = Console.ReadLine()!;
                        dictionaryManager.AddWord(word, translation);
                        break;

                    case "2":
                        Console.Write("Enter the word to replace: ");
                        string oldWord = Console.ReadLine()!;
                        Console.Write("Enter the new word: ");
                        string newWord = Console.ReadLine()!;
                        dictionaryManager.ReplaceWord(oldWord, newWord);
                        break;

                    case "3":
                        Console.Write("Enter word: ");
                        string wordToReplace = Console.ReadLine()!;
                        Console.Write("Enter old translation: ");
                        string oldTranslation = Console.ReadLine()!;
                        Console.Write("Enter new translation: ");
                        string newTranslation = Console.ReadLine()!;
                        dictionaryManager.ReplaceTranslation(wordToReplace, oldTranslation, newTranslation);
                        break;

                    case "4":
                        Console.Write("Enter word to delete: ");
                        dictionaryManager.DeleteWord(Console.ReadLine()!);
                        break;

                    case "5":
                        Console.Write("Enter word to delete translation: ");
                        string wordToDelete = Console.ReadLine()!;
                        Console.Write("Enter translation to delete: ");
                        string translationToDelete = Console.ReadLine()!;
                        dictionaryManager.DeleteTranslation(wordToDelete, translationToDelete);
                        break;

                    case "6":
                        Console.Write("Enter word to search: ");
                        dictionaryManager.SearchWord(Console.ReadLine()!);
                        break;

                    case "7":
                        Console.Write("Enter word to export: ");
                        string exportWord = Console.ReadLine()!;
                        if (dictionaryManager.GetDictionary().ContainsKey(exportWord))
                        {
                            fileManager.ExportWord(exportWord, dictionaryManager.GetDictionary()[exportWord]);
                        }
                        else
                        {
                            Console.WriteLine("Word not found");
                        }
                        break;

                    case "8":
                        fileManager.SaveDictionary(dictionaryManager.GetDictionary());
                        return;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
                Console.WriteLine("Press Enter to continue");
                Console.ReadLine();
            }
        }
    }
}
