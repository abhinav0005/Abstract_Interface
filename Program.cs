using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Interface
{
    public abstract class Draw
    {
        public abstract void display();
    }
    public class Circle : Draw
    {
        public override void display()
        {
            Console.WriteLine("Draw circle...");
        }
    }
    public class Rectangle : Draw
    {
        public override void display()
        {
            Console.WriteLine("Draw rectangle...");
        }
    }
    class AbstractEx
    {
        static void Main(string[] args)
        {
            Draw d = new Circle();
            d.display();
            Draw d1 = new Rectangle();
            d1.display();
            Console.Read();
        }
    }
}
