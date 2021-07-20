using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseMark
{
    public class Item:Inventory
    {

        private string name;
        private int weight;
        private int size;


        public string Name
        {
            get { return name; }
            set
            {
                if (value != null)
                {
                    this.name = value;
                }

            }
        }


        public int Weight
        {
            get { return weight; }
            set
            {

                if (value > GetMaxWeight || value <= 0)
                {
                }
                else
                {
                    this.weight = value;

                }
                
            }
        }


        public  int Size
        {
            get { return size; }
            set
            {
                if (value > GetMaxSize || value <= 0)
                {
                }
                else {
                    this.size = value;
                }             
            }
        }


        public Item(string Name, int Weight, int Size)
        {
            this.Name = Name;
            this.Weight = Weight;
            this.Size = Size;
        }
    }
}
