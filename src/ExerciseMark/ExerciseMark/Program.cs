using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseMark
{
    class Program
    {
       public static int x;
       public static int y;

        static void Main(string[] args)
        {
            
            


            Inventory inventory = new Inventory();
            inventory.setmaxSize(x=200);
            inventory.setmaxWeight(y=200);
            Item myItem = new Item("aa",10,10);
            Item myItem2= new Item("aa0", 10, 10);
            Item myItem3 = new Item("Mark", 181, 10);
            Item myItem4 = new Item("Mathieu ", 30, 30);
            
            inventory.AddItem(myItem);
            inventory.AddItem(myItem2);
            inventory.AddItem(myItem3);
            inventory.AddItem(myItem4);

            myItem.Size = 5000;
            myItem.Weight = 5000;
            
          


            Console.WriteLine("Sum of Weight:"+inventory.getSumWeight() + " out of " + y);
            Console.WriteLine("Sum of Size:" + inventory.getSumSize() + " out of " + x);
            for (int i = 0; i < inventory.GetItems(); i++)
            {
                Console.WriteLine(inventory.GetItem(i).Name + " " + inventory.GetItem(i).Weight + " " + inventory.GetItem(i).Size);
            }
                

            
            






        }


    }
}
