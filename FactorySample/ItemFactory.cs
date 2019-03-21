using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorySample
{
    class ItemFactory
    {
        private static String[] items = { "sword", "armor", "potion", "jewwl" };

        public static Item CreateItem(string type){
            Item auxItem;
            type = type.ToLower();
            switch (type)
            {
                case "sword":
                    auxItem = new Sword();
                    break;
                case "armor":
                    auxItem = new Armor();
                    break;
                case "potion":
                    auxItem = new Potion();
                    break;
                case "jewwl":
                default:
                    auxItem = new Jewel();
                    break;
            }
            return auxItem;
        }

        public static List<Item> RandomItems(int count)
        {
            List<Item> auxItems = new List<Item>();
            Random ranItem = new Random();
            for(int i=0; i<count; i++){
                auxItems.Add(CreateItem(items[ranItem.Next(items.Length)]));
            }
            return auxItems;
        }
    }
}
