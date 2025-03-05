using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolySimple2  /*This is when differnt classees implement the same interface 
                        * but provide their own versions of the methods. 
                        * Interface Polymorphism (Different claases implementing the same interface)
                        */

{
    interface IShape
    {
        void Draw();
    }

    class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a circle");
        }
    }

    class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a square");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            IShape shape1 = new Circle();
            IShape shape2 = new Square();

            shape1.Draw();  //Calls the circle's draw
            shape2.Draw();  //Calls the square's draw

        }
    }
}
