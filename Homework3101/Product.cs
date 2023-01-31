﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Homework3101
{
    public class Product
    {
         string _name;
         double _price;

        public double Price
        {
            set
            {
                if (value > 0) {
                _price = value;}
            }
            get
            {
                return _price;
            }
        }

        public string Name
        {
            set
            {
                if(value.Length>2 && value.Length < 20)
                {
                    _name = value; 
                }
            }
            get
            {
                return _name;
            }

        }
    }
}
