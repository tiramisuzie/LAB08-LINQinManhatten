using LAB08_LINQinManhatten.Classes;
using System;

namespace LAB08_LINQinManhatten
{
    class Program
    {
        static void Main(string[] args)
        {
            Util util = new Util();
            Manhattan manhattan = util.GetManhattanData();
            Console.WriteLine("Output all of the neighborhoods in this data list");
            util.OutputNeighborhood(manhattan);
            Console.WriteLine("Filtered out all the neighborhoods that do not have any names");
            util.FilterNoNameNeighborhood(manhattan);
        }
    }
}
