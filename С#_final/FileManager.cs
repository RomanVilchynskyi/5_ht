using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace С__final
{
    class FileManager
    {
        private string filePath;

        public FileManager(string filePath)
        {
            this.filePath = filePath;
        }

        public Dictionary<string, List<string>> LoadDictionary()
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("Dictionary file not found. A new dictionary will be created");
                return new Dictionary<string, List<string>>();
            }

            var json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<Dictionary<string, List<string>>>(json) ?? new Dictionary<string, List<string>>();
        }

        public void SaveDictionary(Dictionary<string, List<string>> dictionary)
        {
            var json = JsonConvert.SerializeObject(dictionary, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }

        public void ExportWord(string word, List<string> translations)
        {
            File.WriteAllText("export.json", JsonConvert.SerializeObject(new { word, translations }, Formatting.Indented));
            Console.WriteLine("Word exported");
        }
    }
}
