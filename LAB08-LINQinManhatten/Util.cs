using LAB08_LINQinManhatten.Classes;
using Newtonsoft.Json;
using System.IO;

namespace LAB08_LINQinManhatten
{
    class Util
    {
        string DATA_FILE_PATH = "../../../SolutionItems/data.json";

        public void GetManhattanData()
        {
            string text = "";

            using (StreamReader sr = File.OpenText(DATA_FILE_PATH))
            {
                text = sr.ReadToEnd();
            }

            Manhattan data = JsonConvert.DeserializeObject<Manhattan>(text);
        }
        
    }
}
