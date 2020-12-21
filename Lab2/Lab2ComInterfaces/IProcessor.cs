using System;
using System.Runtime.InteropServices;

namespace Lab2ComInterfaces
{
    [Guid("C9BE7FD9-A4D5-411A-9701-C34F3392047D")]
    interface IProcessor
    {
        double Sum(double a, double b);
        double Factorial(int a);
    }
}
