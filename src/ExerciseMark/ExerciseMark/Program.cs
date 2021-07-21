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
            Item myItem3 = new Item("Mark", 181, 10);
            Item myItem4 = new Item("Mathieu ", 30, 30);
            inventory.AddItem(myItem);
            inventory.AddItem(myItem2);
            inventory.AddItem(myItem3);
            inventory.AddItem(myItem4);
            
            //Inventory2
            Inventory inventory2 = new Inventory();
            inventory2.MaxSize=200;
            inventory2.MaxWeight=220;
            Item myItema = new Item("aa2", 10, 10);
            Item myItemb = new Item("aa02", 10, 10);
            inventory2.AddItem(myItema);
            inventory2.AddItem(myItemb);

            //Display Inventory
            inventory.ShowInventory();
            inventory2.ShowInventory();
        }
    }
}
