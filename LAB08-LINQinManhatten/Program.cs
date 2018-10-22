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
            Console.WriteLine("*************************************************************");
            Console.WriteLine("1) Output all of the neighborhoods in this data list");
            util.OutputNeighborhood(manhattan);
            Console.WriteLine("*************************************************************");
            Console.WriteLine("2) Filtered out all the neighborhoods that do not have any names");
            util.FilterNoNameNeighborhood(manhattan);
            Console.WriteLine("*************************************************************");
            Console.WriteLine("3) Remove the Duplicates");
            util.RemoveDuplicates(manhattan);

            Console.WriteLine("*************************************************************");
            Console.WriteLine("4) Remove the Duplicates");
            Console.WriteLine("4) Filtered out all the neighborhoods that do not have any names");
            util.RemoveDuplicateAndNoNameNeighborhood(manhattan);

            Console.WriteLine("*************************************************************");
            Console.WriteLine("5) In LINQ");
            util.RewriteWithLINQ(manhattan);

        }
    }
}
