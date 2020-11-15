using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciceSoutien
{
    class Calculator                               
    {
        public float [] Integers { get; set; }

       
        public void Display()
        {
            foreach (float values in Integers) 
            {
                Console.WriteLine(values);
            }
        }

        public float Sum()
        {
            float stock = 0;
            for(int i =0;i < Integers.Length;i++)
            {
                stock = stock + Integers[i];
            }

            return stock;  
        }

        public float Average()
        {
            float average = Sum() / Integers.Length;
            return average;
        }
       

    }
}
