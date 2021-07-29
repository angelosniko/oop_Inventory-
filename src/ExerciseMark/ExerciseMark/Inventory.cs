using System;
using System.Collections.Generic;
using System.Linq;

namespace ExerciseMark
{
    public class Inventory
    {
        private List<Item> _inventoryList;
        private int _maxSize;
        private int _maxWeight;

        public Inventory()
        {
            _inventoryList = new List<Item>();
        }

        public List<Item> GetItems() {
            return _inventoryList;
        }

        public int MaxSize
        {
            get
            {           
                return _maxSize;
            }
            set
            {
              _maxSize = value; 
            }
        }

        public int MaxWeight
        {
            get
            {
                    return _maxWeight;
               }
            set
            {
                 _maxWeight = value; 
            }
        }

        public void DisplayInventory()
        { 
            Console.WriteLine("---!"+"INVENTORY"+"!---");
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
            _inventoryList.Add(itemAdd);

            if (GetWeightSum() <= _maxWeight && GetSizeSum() <= _maxSize)
            {
                
                itemAdd.Inventory = this;
            }
            else
            {
                _inventoryList.Remove(itemAdd);
                //throw (new ArgumentException("Item with the Name: " + itemAdd.Name + " with Size value " + itemAdd.Size +
                //    " with Weight value " + itemAdd.Weight + " cannot be added to the inventory"));
            }
        }

      

        public Item GetItemInventory(int index)
        {
            return _inventoryList[index];
        }
        public int GetSizeSum()
        {
            int sum1 = 0;
            for (int i = 0; i < _inventoryList.Count; i++)
            {
                sum1 = sum1 + _inventoryList[i].Size;
            }
            return sum1;
        }
    
        public int GetWeightSum()
        {
            int sum = 0;
            for (int i = 0; i < _inventoryList.Count; i++)
            {
                sum = sum + _inventoryList[i].Weight;
            }
            return sum;
        }

        public int GetItemsInventoryCount()
        {
            var itemCount = _inventoryList.Count;
            return itemCount;
        }

        public void RemoveItem(Item itemRemove)
        {            
            _inventoryList.Remove(itemRemove);
        }
    }
}
