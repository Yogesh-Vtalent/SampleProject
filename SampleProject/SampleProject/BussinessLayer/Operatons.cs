using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleProject.BussinessLayer
{
    public class Operatons
    {
        public int Addition(int A, int B)
        {
            return A + B;
        }
        public int Subtraction(int A, int B)
        {
            return A - B;
        }
        public int Multiplication(int C)
        {
            int a = 5, b = 2;
            return C = a * b;
        }
    }
}