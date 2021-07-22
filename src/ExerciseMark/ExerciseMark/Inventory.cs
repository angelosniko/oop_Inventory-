using System;
using System.Collections.Generic;
using System.Linq;

namespace ExerciseMark
{
    public class Inventory
    {

        List<Item> ItemsInventory;
        private int? _maxSize;
        private int? _maxWeight;

        public OutsideInventory OutsideInventory { get; set; }

        public int MaxSize
        {
            get
            {

                int sum = ItemsInventory.Sum(x => x.Size);
                if (sum < _maxSize)
                {
                    return (int)_maxSize;
                }
                else { throw (new ArgumentException("The sum is bigger than the maxSize")); }
            }
            set
            {
                if (null == _maxSize)
                {
                    _maxSize = value;
                }
                else { throw (new InvalidOperationException("The value of Size cannot be changed")); }
            }
        }

        public int MaxWeight
        {
            get
            {

                int sum = ItemsInventory.Sum(x => x.Weight);
                if (sum < _maxWeight)
                {
                    return (int)_maxWeight;
                }
                else { throw (new ArgumentException("The sum is bigger than the maxWeight")); }
            }
            set
            {
                if (null == _maxWeight)
                {
                    _maxWeight = value;
                }
                else { throw new InvalidOperationException("The value of Weight cannot be changed"); }
            }
        }

        public Inventory()
        {

            ItemsInventory = new List<Item>();

        }


        public void ShowInventory()
        {
            Console.WriteLine("Inside Inventory");
            Console.WriteLine("Sum of Weight:" + GetWeightSum() + " of " + _maxWeight);
            Console.WriteLine("Sum of Size:" + GetSizeSum() + " of " + _maxSize);
            for (int i = 0; i < GetItemsCount(); i++)
            {
                Console.WriteLine(GetItem(i).Name + " " + GetItem(i).Weight + " " + GetItem(i).Size);
            }
        }

        public void AddItem(Item itemAdd)
        {

            ItemsInventory.Add(itemAdd);

           



            if (GetWeightSum() <= _maxWeight && GetSizeSum() <= _maxSize)
            {
                itemAdd.Inventory = this;
                //OutsideInventory.RemoveItem(itemAdd);
            }
            else
            {
                ItemsInventory.Remove(itemAdd);
                //Console.WriteLine("Cannot be added the inventory, the item with the Name: " + in_item.Name);
                throw (new ArgumentException("Item with the Name:" + itemAdd.Name + " cannot be added to the inventory"));
            }

        }

        public Item GetItem(int index)
        {
            return ItemsInventory[index];
        }


        public int GetSizeSum()
        {
            int sum1 = 0;


            for (int i = 0; i < ItemsInventory.Count; i++)
            {
                sum1 = sum1 + ItemsInventory[i].Size;

            }

            return sum1;

        }


        public int GetWeightSum()
        {

            int sum = 0;


            for (int i = 0; i < ItemsInventory.Count; i++)
            {
                sum = sum + ItemsInventory[i].Weight;

            }

            return sum;

        }


        public int GetItemsCount()
        {

            var itemCount = ItemsInventory.Count;

            return itemCount;

        }


        public void RemoveItem(Item itemRemove)
        {
            OutsideInventory.addItem(itemRemove);
            ItemsInventory.Remove(itemRemove);



        }
    }
}
