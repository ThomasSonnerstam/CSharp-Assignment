using System.Collections.Generic;

namespace CSharpAssignment
{
    public class Inventory
    {
        public Dictionary<string, int> GoodsAvailable = new Dictionary<string, int>();
        public List<string> MyGoods = new List<string>();

        public Inventory()
        {
            GoodsAvailable.Add("eggs", 30);
            GoodsAvailable.Add("juice", 25);
            GoodsAvailable.Add("chicken", 60);
            GoodsAvailable.Add("bread", 20);
            GoodsAvailable.Add("cucumber", 15);
            GoodsAvailable.Add("beef", 80);
            GoodsAvailable.Add("salad", 25);
        }
        

        public void Buy(string item)
        {
            if (GoodsAvailable.ContainsKey(item))
            {
                MyGoods.Add(item);
            }
        }
    }
    
}