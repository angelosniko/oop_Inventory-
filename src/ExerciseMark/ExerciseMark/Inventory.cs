using System;
using System.Collections.Generic;

namespace ExerciseMark
{
    public class Inventory
    {
        List<Item> itemA;
       public int maxSize;
       public int maxWeight;

        public Inventory(/*int in_maxSize,int in_maxWidth*/)
        {
            //maxSize = in_maxSize;
            //maxSize = in_maxWidth;
            itemA = new List<Item>();

        }

        public void setmaxSize(int setmaxSize) {

            this.maxSize = setmaxSize;
        
        }

        public void setmaxWeight(int setmaxWeight)
        {

            this.maxWeight = setmaxWeight;

        }




        public void AddItem(Item in_item)
        {
            itemA.Add(in_item);


            if (getSumWeight()< maxWeight && getSumSize() < maxSize)
            {

                


            }
            else {
                itemA.Remove(in_item);
                Console.WriteLine("Cannot be added the inventory, the item with the Name: "+in_item.Name); 
            }
                 
        }

        public Item GetItem(int index)
        {
            return itemA[index];
        }


        public int getSumSize() {
            int sum1 = 0;


            for (int i = 0; i < itemA.Count; i++)
            {
               

                sum1 = sum1 + itemA[i].Size;

            }


            return sum1;


                    }


        public int getSumWeight() {

            int sum = 0;


            for (int i = 0; i < itemA.Count; i++)
            {
                sum = sum + itemA[i].Weight;
               

            }

            return sum;


        }


        public int GetItems() {

           
               var item=itemA.Count;

            return item;
        
        }


        public void removeItem(int index) {
            itemA.RemoveAt(index);
        }

       
    }
}
