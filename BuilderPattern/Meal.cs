using System;
using System.Collections.Generic;

namespace BuilderPattern
{
    public class Meal
    {
        private List<IItem> items = new List<IItem>();

        public void AddItem(IItem item)
        {
            this.items.Add(item);
        }

        public float GetCost()
        {
            float cost = 0.0f;

            foreach (IItem item in this.items)
            {
                cost += item.Price();
            }
            return cost;
        }

        public void ShowItems()
        {
            foreach (IItem item in this.items)
            {
                Console.Write("Item: " + item.Name());
                Console.Write(", Pakcing: " + item.Packing().pack());
                Console.WriteLine(", Price: " + item.Price());
            }
        }
    }
}
