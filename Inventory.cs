using System.Collections.Generic;

namespace CSharpAssignment
{
    public class Inventory
    {
        public List<string> GoodsAvailable = new List<string> { "eggs", "milk", "apples", "bananas", "juice", "chicken" };
        public List<string> MyGoods = new List<string>();

        public void Buy(string item)
        {
            if (GoodsAvailable.Contains(item))
            {
                MyGoods.Add(item);
            }
        }
    }
    
}