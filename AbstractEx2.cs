using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Interface
{
    public abstract class Cricket
    {
        public abstract void Team();
        public abstract void Player();
        public void Ipl()
        {
            Console.WriteLine("KKR");
            Console.WriteLine("RR");
            Console.WriteLine("CSK");

        }
    }
    public class Mumbai : Cricket
    {
        public override void Team()
        {
            Console.WriteLine("MI");
        }
        public override void Player()
        {
            Console.WriteLine("ROHIT");
        }
    }
    public class Bangaluru : Cricket
    {
        public override void Team()
        {
            Console.WriteLine("RCB");
        }
        public override void Player()
        {
            Console.WriteLine("VIRAT");
        }
    }
    class AbstractEx2
    {
        static void Main(string[] args)
        {
            Cricket c1 = new Mumbai();
            c1.Team();
            c1.Player();
            c1.Ipl();
            Cricket c2 = new Bangaluru();
            c2.Team();
            c2.Player();
            Console.Read();
        }
    }
}
