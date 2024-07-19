﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    delegate float Operation1(float num1, float num2);
    internal class Assignment1_que3
    {
        public int Add(int a, int b) => a + b;
        public int Multiply(int a, int b) => a * b;

         delegate int Operation1(int a, int b);

        public class Calculator
        {
            public void PerformOperation()
            {
                Assignment1_que3 arithmetic = new Assignment1_que3();
                Operation1 operation;

                Console.Write("Enter first number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter second number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Choose an operation:");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Multiplication");
                Console.WriteLine("3. Both");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)

                {
                    case 1:
                        operation = arithmetic.Add;
                        break;
                    case 2:
                        operation = arithmetic.Multiply;
                        break;
                    case 3:
                        operation = (a, b) =>
                        {
                            int sum = arithmetic.Add(a, b);
                            int product = arithmetic.Multiply(a, b);
                            Console.WriteLine($"Sum: {sum}, Product: {product}");
                            return sum + product;
                            Console.ReadKey();

                        };
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        return;
                }

                int result = operation.Invoke(num1, num2);
                Console.WriteLine($"Result: {result}");
                Console.ReadKey();
            }
        }

        }
}
