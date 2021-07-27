using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ExerciseMark
{
    public class Item
    { 
        private string? _name;
        private int? _weight;
        private int? _size;
        public string Name
        {
            get { 
                return _name; 
            }
            set
            {
                //if (Inventory.Test == true)
                //{
                    if (null == _name)
                    {

                        if (value != null)
                        {
                            this._name = value;
                        }

                    }
                    else
                    {

                        throw new InvalidOperationException("Value of Name cannot be changed");
                    }

                //}
                //else {

                //    this._name = value;
                //}

                }            
        }

        public Inventory Inventory { get; set; }

          public int Weight
        {
            get { 
                return (int)_weight; 
            }
            set
            {
                if (null == _weight)
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
                            this._weight = value;
                        }
                    }
                    else
                    {
                        _weight = value;

                    }
                }
                else {
                    throw new InvalidOperationException("Value of Weight cannot be changed");

                }

            }

        }


        public  int Size
        {
            get { return (int)_size; }
            set
            {
               
                if (null == _size)
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
                            this._size = value;
                        }
                    }
                    else
                    {
                        _size = value;

                    }
                }
                else {
                    //throw new InvalidOperationException("Value of Size cannot be changed");
                }
            }
        }

        public Item(string name, int weight, int size)
        {
            Name = name;
            Weight = weight;
            Size = size;
        }
    }
}
