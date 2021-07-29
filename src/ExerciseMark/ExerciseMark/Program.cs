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
            Item myItem = new Item("aabc",10,10);
            Item myItem2= new Item("abcd", 10, 10);
            Item myItem3 = new Item("Mark", 150, 10);
            Item myItem4 = new Item("Math ", 30, 30);
            Item myItem5 = new Item("Math2 ", 100, 30);
            myItem3.Name = "Matheiu";
            myItem3.Weight = 110;
            inventory.AddItem(myItem3);
            inventory.AddItem(myItem4);
            inventory.AddItem(myItem2);
            //inventory.AddItem(myItem2);
            inventory.DisplayInventory();
        }
    }
}
