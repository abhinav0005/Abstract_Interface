using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Interface
{
    interface Cal1
    {
        int add(int i, int j);
    }
    interface cal2
    {
        int sub(int i, int j);
    }
    interface cal3
    {
        int mul(int i, int j);
    }
    interface cal4
    {
        int div(int i, int j);
    }
    public class Calculation : Cal1,cal2,cal3,cal4
    {
        public int add(int x, int y)
        {
            return x + y;
        }
        public int sub(int x, int y)
        {
            return x - y;
        }
        public int mul(int x, int y)
        {
            return x * y;
        }
        public int div(int x, int y)
        {
            return x / y;
        }
    }
    class MultipleInheritanceEx
    {
        static void Main(string[] args)
        {
            Calculation cal = new Calculation();
            Console.WriteLine("Sum of num is : " +cal.add(15, 5));
            Console.WriteLine("Difference of num is : "+cal.sub(15, 5));
            Console.WriteLine("Product of num is : "+cal.mul(15, 5));
            Console.WriteLine("Division of num is : "+cal.div(15, 5));
            Console.Read();
        }
    }
}
