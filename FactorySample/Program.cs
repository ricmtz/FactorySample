using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorySample
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ranNum = new Random();
            Random experience = new Random();
            List<Item> itemDrops = ItemFactory.RandomItems(ranNum.Next(15));
            Console.WriteLine("Congratulations, you defeat the legendary dragon of the impossible mountain.\n");
            Console.WriteLine("The dragon drop you the next item:");
            Console.WriteLine();
            foreach (Item item in itemDrops){
                item.Description();
            }
            Console.WriteLine();
            Console.WriteLine("Also you earned {0} exp.", experience.Next(150, 999));
            Console.ReadKey(true);
        }
    }
}
