using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
  
        public class MyEventArgs : EventArgs
        {

            public decimal first_number { get; set; }
            public decimal second_number { get; set; }
            public decimal ans { get; set; }
            public char operation { get; set; }


            //parameterized constructoe
            MyEventArgs(decimal a, decimal b)
            {
                first_number = a;
                second_number = b;
            }
        }
    }
