using System;
using System.Collections.Generic;

namespace ExerciseMark
{
    public class Inventory
    {
        List<Item> itemA;
        private static int maxSize;
        private static int maxWeight;

        public Inventory()
        {

            itemA = new List<Item>();

        }


        public void ShowInventory() {
            Console.WriteLine("Sum of Weight:" + getSumWeight() + " of "+GetMaxWeight);
            Console.WriteLine("Sum of Size:" + getSumSize() + " of " + GetMaxSize);
                for (int i = 0; i < GetItems(); i++)
            {
                Console.WriteLine(GetItem(i).Name +" "+GetItem(i).Weight+" "+GetItem(i).Size);
            }
        }

    public  int GetMaxSize { get { return maxSize; }  }

        public   int GetMaxWeight { get { return maxWeight; } }

        public void setmaxSize(int setmaxSize)
        {

            maxSize = setmaxSize;

        }

        public void setmaxWeight(int setmaxWeight)
        {

            maxWeight = setmaxWeight;

        }


        public void AddItem(Item in_item)
        {
            itemA.Add(in_item);


            if (getSumWeight() < maxWeight && getSumSize() < maxSize)
            {
            }
            else
            {
                itemA.Remove(in_item);
                Console.WriteLine("Cannot be added the inventory, the item with the Name: " + in_item.Name);
            }

        }

        public Item GetItem(int index)
        {
            return itemA[index];
        }


        public int getSumSize()
        {
            int sum1 = 0;


            for (int i = 0; i < itemA.Count; i++)
            {
                sum1 = sum1 + itemA[i].Size;

            }

            return sum1;

        }


        public int getSumWeight()
        {

            int sum = 0;


            for (int i = 0; i < itemA.Count; i++)
            {
                sum = sum + itemA[i].Weight;

            }

            return sum;


        }


        public int GetItems()
        {

            var item = itemA.Count;

            return item;

        }


        public void removeItem(int index)
        {
            itemA.RemoveAt(index);
        }


    }
}
