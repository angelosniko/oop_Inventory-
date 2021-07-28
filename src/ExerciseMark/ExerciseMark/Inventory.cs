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
    
        public void GetItems()
        { 
            Console.WriteLine("---"+"INVENTORY"+"---");
            Console.WriteLine("Sum of Weight:" + GetWeightSum() + " of " + _maxWeight);
            Console.WriteLine("Sum of Size:" + GetSizeSum() + " of " + _maxSize);
            Console.WriteLine("---Details---");
            Console.WriteLine("Name "+"Weight "+"Size ");
            for (int i = 0; i < GetItemsInventoryCount(); i++)
            {
                Console.WriteLine(GetItemInventory(i).Name + "  " + GetItemInventory(i).Weight + "  " + GetItemInventory(i).Size);
            }
            Console.WriteLine("---------------------------");
        }

        public void AddItem(Item itemAdd)
        {
            ItemsInventory.Add(itemAdd);

            if (GetWeightSum() <= _maxWeight && GetSizeSum() <= _maxSize)
            {
                
                itemAdd.Inventory = this;
            }
            else
            {
                ItemsInventory.Remove(itemAdd);
                    throw (new ArgumentException("Item with the Name: " + itemAdd.Name +" with Size value "+itemAdd.Size+
                        " with Weight value "+itemAdd.Weight+ " cannot be added to the inventory"));
            }
        }

        public Item GetItemInventory(int index)
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

        public int GetItemsInventoryCount()
        {
            var itemCount = ItemsInventory.Count;
            return itemCount;
        }

        public void RemoveItem(Item itemRemove)
        {            
            ItemsInventory.Remove(itemRemove);
        }
    }
}
