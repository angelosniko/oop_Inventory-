﻿using System;
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
            myItem3.Name = "Matheiu";
            myItem3.Size = 60;
            inventory.AddItem(myItem3);
            inventory.AddItem(myItem4);
            inventory.GetItems();
            myItem.Size = 100;
            //Inventory2
            Inventory inventory2 = new Inventory();
            inventory2.MaxSize = 300;
            inventory2.MaxWeight = 300;
            inventory2.AddItem(myItem);
            inventory2.AddItem(myItem2);
            inventory2.RemoveItem(myItem2);
            inventory2.GetItems();
        }
    }
}
