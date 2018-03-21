using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Interface
{
    public interface Animal
    {
        void Aname();
    }
    public class Dog : Animal
    {
       public void Aname()
        {
            Console.WriteLine("Dog..");
        }
    }
    public class Cat : Animal
    {
        public void Aname()
        {
            Console.WriteLine("Cat..");
        }
    }
    class InterfaceEx
    {
        static void Main(string[] args)
        {
            Animal a;
            a = new Dog();
            a.Aname();
            a = new Cat();
            a.Aname();
            Console.Read();
        }
    }
}
