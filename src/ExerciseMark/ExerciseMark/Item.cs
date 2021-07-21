using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseMark
{
    public class Item
    {

        private string? name;
        private int? weight;
        private int? size;


        public string Name
        {
            get { 
                return name; 
            }
            set
            {
                if (null == name)
                {

                    if (value != null)
                    {
                        this.name = value;
                    }

                }
                else {

                    throw new InvalidOperationException("Value of Name cannot be changed");
                }
            }
        }

        public Inventory Inventory { get; set; }


        public int Weight
        {
            get { 
                return (int)weight; 
            }
            set
            {
                if (null == weight)
                {
                    if (Inventory != null)
                    {
                        if (value > Inventory.MaxWeight)
                        {
                            throw (new ArgumentException("Value is bigger than Max Weight of Inventory"));
                        }
                        else if (value <= 0)
                        {
                            throw (new ArgumentException("Value is smaller than zero"));

                        }
                        else
                        {
                            this.weight = value;
                        }
                    }
                    else
                    {

                        weight = value;

                    }
                }
                else {
                    throw new InvalidOperationException("Value of Weight cannot be changed");

                }

            }

        }


        public  int Size
        {
            get { return (int)size; }
            set
            {
                if (null == size)
                {
                    if (Inventory != null)
                    {
                        if (value > Inventory.MaxSize)
                        {
                            throw (new ArgumentException("Value is bigger than Max Size of Inventory"));
                        }
                        else if (value <= 0)
                        {
                            throw (new ArgumentException("Value is smaller than zero"));

                        }
                        else
                        {
                            this.size = value;
                        }
                    }
                    else
                    {

                        size = value;

                    }
                }
                else {
                    throw new InvalidOperationException("Value of Size cannot be changed");
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
