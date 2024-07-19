using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////assignment 1 question 1: 
            //Assignment1_que1 calculator = new Assignment1_que1();
            //Console.WriteLine("Enter First Number: ");
            //int n1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter Second Number: ");
            //int n2 = Convert.ToInt32(Console.ReadLine());
            //Operation operation;
            //operation = calculator.AddNumber;
            //operation += calculator.MultiplyNumber;
            //operation(n1, n2);
            //Console.ReadLine();


            //Assignment1_que2 calculator = new Assignment1_que2();
            //Console.WriteLine("Enter First Number: ");
            //int n1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter Second Number: ");
            //int n2 = Convert.ToInt32(Console.ReadLine());
            //calculator.AddNumber(n1, n2);
            //calculator.MultiplyNumber(n1, n2);
            //Console.ReadLine();




            Assignment1_que3 a = new Assignment1_que3();
            Assignment1_que3.Calculator cal = new Assignment1_que3.Calculator();
            cal.PerformOperation();
        }
    }
}
