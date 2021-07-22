using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseMark
{
    public class OutsideInventory
    {
        List<Item> outsideInventory;
        public OutsideInventory()
        {
            outsideInventory = new List<Item>();

        }


        public void addItem(Item item) {

            outsideInventory.Add(item);
        
        }

        public void RemoveItem(Item item) {

            outsideInventory.Remove(item);
        
        }

        public Item GetItem(int index)
        {
            return outsideInventory[index];
        }

        public int GetItemsCount()
        {

            var itemCount = outsideInventory.Count;

            return itemCount;

        }

        public void ShowOutsideInventory() {

            Console.WriteLine("Outside Inventory");

            for (int i = 0; i < GetItemsCount(); i++)
            {
                Console.WriteLine(GetItem(i).Name + " " + GetItem(i).Weight + " " + GetItem(i).Size);
            }


        }



    }
}
