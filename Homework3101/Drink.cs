using System;
using System.Collections.Generic;
using System.Text;

namespace Homework3101
{
    public class Drink
    {
      double _alcoholepercent;

        public double Alcoholepercent
        {
            set
            {
                if (value > 0 && value < 100)
                {
                    _alcoholepercent = value;   
                }
            }
            get { return _alcoholepercent; }
        }



    }
}
