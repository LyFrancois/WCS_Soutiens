using System;

namespace ExerciceSoutien
{
    class Program
    {
        static void Main(string[] args)
        {

            Calculator calculator = new Calculator();

            calculator.Integers = new float[4] { 1, 2, 4, 3 };
            calculator.Display();
            Console.WriteLine( "_\n"+"Somme : "+ calculator.Sum());
            Console.WriteLine("_\n" + "Moyenne : " + calculator.Average());
        }
    
    }
}
