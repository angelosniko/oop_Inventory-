using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseMark
{
    class Program
    {
        static void Main(string[] args)
        {    //Inventory 
            Inventory inventory = new Inventory();
            
            inventory.MaxSize = 200;
            inventory.MaxWeight = 200;
            Item myItem = new Item("aa",10,10);
            Item myItem2= new Item("aa0", 10, 10);
            Item myItem3 = new Item("Mark", 150, 10);
            Item myItem4 = new Item("Mathieu ", 30, 30);



            myItem3.Size = 60;

            inventory.AddItem(myItem3);
            inventory.AddItem(myItem4);
            inventory.GetItems();
          
        }
    }
}
