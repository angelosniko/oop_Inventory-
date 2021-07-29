using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ExerciseMark
{
    public class Item
    { 
        private string _name;  
        private int _weight;
        private int _size; 

        public string Name
        {
            get { 
                return _name; 
            }
            set {  
                        if (value != null)
                        {   
                           _name = value;
                        }
                    }        
            }
         
          public Inventory Inventory { get; set; }

          public int Weight     
        {
            get { 
                return _weight;   
            }
            set
            { 
                       if (Inventory != null)
                    {
                        if (_weight-value > Inventory.MaxWeight-Inventory.GetWeightSum())
                        {
                            throw new ArgumentException("Value is bigger than Max Weight of Inventory");
                        }
                        else if (value <= 0)
                        {
                            throw new ArgumentException("Value is smaller than zero");
                        }
                        else
                        {
                           _weight = value;
                        }
                    }
                    else
                    {
                        _weight = value;
                    }
                } 
        }


        public  int Size
        {
            get { return _size; }
            set
            {
                        if (Inventory != null)
                    {
                        if (_size-value > Inventory.MaxSize)
                        {
                            throw new ArgumentException("Value is bigger than Max Size of Inventory");
                        }                 
                        else if (value <= 0)
                        {
                            throw new ArgumentException("Value is smaller than zero");
                        }
                        else
                        {
                            _size = value;
                        }
                    }
                    else
                    {
                        _size = value;
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
