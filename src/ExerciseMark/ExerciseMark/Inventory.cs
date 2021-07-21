using System;
using System.Collections.Generic;
using System.Linq;

namespace ExerciseMark
{
    public class Inventory
    {
        List<Item> items;
        private int? maxSize;
        private int? maxWeight;

        public int MaxSize { 
            get {

                int sum=items.Sum(x => x.Size);
                if (sum < maxSize)
                {
                    return (int)maxSize;
                }
                else {  throw (new ArgumentException("The sum is bigger than the maxSize")); }
                 } 
            set {
                if (null == maxSize)
                {
                    maxSize = value;
                }
                else { throw (new InvalidOperationException("The value of Size cannot be changed")); }
                } }

        public int MaxWeight
        {
            get
            {

                int sum = items.Sum(x => x.Weight);
                if (sum < maxWeight)
                {
                    return (int)maxWeight;
                }
                else { throw (new ArgumentException("The sum is bigger than the maxWeight")); }
            }
            set {
                if (null == maxWeight)
                {
                    maxWeight = value;
                }
                else { throw new InvalidOperationException("The value of Weight cannot be changed"); }
                }
        }

        public Inventory()
        {

            items = new List<Item>();

        }


        public void ShowInventory() {
            Console.WriteLine("Sum of Weight:" + getSumWeight() + " of "+ maxWeight);
            Console.WriteLine("Sum of Size:" + getSumSize() + " of " + maxSize);
                for (int i = 0; i < GetItems(); i++)
            {
                Console.WriteLine(GetItem(i).Name +" "+GetItem(i).Weight+" "+GetItem(i).Size);
            }
        }

        public void AddItem(Item in_item)
        {
            items.Add(in_item);


            if (getSumWeight() < maxWeight && getSumSize() < maxSize)
            {
                in_item.Inventory = this;
            }
            else
            {
                items.Remove(in_item);
                //Console.WriteLine("Cannot be added the inventory, the item with the Name: " + in_item.Name);
                throw (new ArgumentException("Item with the Name:"+in_item.Name+" cannot be added to the inventory"));
            }

        }

        public Item GetItem(int index)
        {
            return items[index];
        }


        public int getSumSize()
        {
            int sum1 = 0;


            for (int i = 0; i < items.Count; i++)
            {
                sum1 = sum1 + items[i].Size;

            }

            return sum1;

        }


        public int getSumWeight()
        {

            int sum = 0;


            for (int i = 0; i < items.Count; i++)
            {
                sum = sum + items[i].Weight;

            }

            return sum;

        }


        public int GetItems()
        {

            var item = items.Count;

            return item;

        }


        public void removeItem(int index)
        {
            items.RemoveAt(index);
        }


    }
}
