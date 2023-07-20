using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reciepe_Book
{
    class ReadAndParseJsonFile
    {
        public readonly string _JsonFilePath;

        public ReadAndParseJsonFile(string JsonFilePath)
        {
            _JsonFilePath = JsonFilePath;
        }

    public RecipeInfo UseUserDefinedObject()
    {
        using StreamReader reader = new(_JsonFilePath);
        var Json = reader.ReadToEnd();
        RecipeInfo Recipe = JsonConvert.DeserializeObject<RecipeInfo>(Json);

        return Recipe;
    }
}
}
