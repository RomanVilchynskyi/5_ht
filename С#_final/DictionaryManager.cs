using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace С__final
{
    class DictionaryManager
    {
        private Dictionary<string, List<string>> dictionary = new();

        public void AddWord(string word, string translation)
        {
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

        public void ReplaceWord(string oldWord, string newWord)
        {
            if (!dictionary.ContainsKey(oldWord))
            {
                Console.WriteLine("Word not found");
                return;
            }

            if (dictionary.ContainsKey(newWord))
            {
                Console.WriteLine("This word already exists");
                return;
            }

            dictionary[newWord] = dictionary[oldWord];
            dictionary.Remove(oldWord);
        }

        public void ReplaceTranslation(string word, string oldTranslation, string newTranslation)
        {
            if (!dictionary.ContainsKey(word) || !dictionary[word].Contains(oldTranslation))
            {
                Console.WriteLine("Word or translation not found");
                return;
            }

            dictionary[word].Remove(oldTranslation);
            dictionary[word].Add(newTranslation);
        }

        public void DeleteWord(string word)
        {
            if (dictionary.Remove(word))
                Console.WriteLine("Word deleted");
            else
                Console.WriteLine("Word not found");
        }

        public void DeleteTranslation(string word, string translation)
        {
            if (!dictionary.ContainsKey(word))
            {
                Console.WriteLine("Word not found");
                return;
            }

            if (dictionary[word].Count == 1)
            {
                Console.WriteLine("This is the only translation for this word, it can't be deleted");
                return;
            }

            if (dictionary[word].Remove(translation))
                Console.WriteLine("Translation deleted");
            else
                Console.WriteLine("Translation not found");
        }

        public void SearchWord(string word)
        {
            if (dictionary.ContainsKey(word))
                Console.WriteLine("Translations: " + string.Join(", ", dictionary[word]));
            else
                Console.WriteLine("Word not found!");
        }

        public Dictionary<string, List<string>> GetDictionary() => dictionary;

        public void SetDictionary(Dictionary<string, List<string>> loadedDictionary)
        {
            dictionary = loadedDictionary ?? new Dictionary<string, List<string>>();
        }
    }
}
