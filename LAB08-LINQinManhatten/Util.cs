using LAB08_LINQinManhatten.Classes;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Linq;

namespace LAB08_LINQinManhatten
{
    class Util
    {
        string DATA_FILE_PATH = "../../../../data.json";

        public Manhattan GetManhattanData()
        {
            string text = "";

            using (StreamReader sr = File.OpenText(DATA_FILE_PATH))
            {
                text = sr.ReadToEnd();
            }

            Manhattan data = JsonConvert.DeserializeObject<Manhattan>(text);
            return data;
        }
        
        public void OutputNeighborhood(Manhattan manhattan)
        {
           var neighborhoods = manhattan.Features.Select(x => x.Properties).Select(x => x.Neighborhood);
           foreach (string neighborhood in neighborhoods)
            {
                Console.WriteLine(neighborhood);
            }
        }

        public void FilterNoNameNeighborhood(Manhattan manhattan)
        {
            var neighborhoods = manhattan.Features.Select(x => x.Properties).Select(x => x.Neighborhood).Where(x => x != "");
            foreach (string neighborhood in neighborhoods)
            {
                Console.WriteLine(neighborhood);
            }
        }
        public void RemoveDuplicates(Manhattan manhattan)
        {
            var neighborhoods = manhattan.Features.Select(x => x.Properties).Select(x => x.Neighborhood).Distinct();

            foreach (var neighborhood in neighborhoods)
            {
                Console.WriteLine(neighborhood);
            }
        }

        public void RemoveDuplicateAndNoNameNeighborhood(Manhattan manhattan)
        {
            var neighborhoods = manhattan.Features.Select(x => x.Properties).Select(x => x.Neighborhood).Where(x => x != "").Distinct();

            foreach (var neighborhood in neighborhoods)
            {
                Console.WriteLine(neighborhood);
            }
        }

        public void RewriteWithLINQ(Manhattan manhattan)
        {
            var neighborhoods = (from features in manhattan.Features
                                 where features.Properties.Neighborhood != ""
                                 select features.Properties.Neighborhood).Distinct();

            foreach (var neighborhood in neighborhoods)
            {
                Console.WriteLine(neighborhood);
            }
        }
    }
}

