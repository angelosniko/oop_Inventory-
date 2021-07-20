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
            inventory.setMaxSize = 200;
            inventory.setMaxWeight = 200;
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

            //Inventory1
            Inventory inventory1 = new Inventory();
            inventory1.setMaxSize=200;
            inventory1.setMaxWeight=220;
            Item myItema = new Item("aa2", 10, 10);
            Item myItemb = new Item("aa02", 10, 10);
            inventory1.AddItem(myItema);
            inventory1.AddItem(myItemb);

            //Display Inventory
            inventory.ShowInventory();
            inventory1.ShowInventory();

            //testing for code breaking 
            inventory.setMaxSize = 600000;
            inventory.setMaxWeight = 9000000;
            inventory1.setMaxSize = 60440000;
            inventory1.setMaxWeight = 87553400;
        }
    }
}
