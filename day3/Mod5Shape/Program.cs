using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod5Shape
{
    abstract class Shape
    {
        private int x;
        private int y;
        public Shape()
        {

        }
        public Shape(int a, int b)
        {
            x = a;
            y = b;
        }
        public virtual void Draw()
        {
            Console.WriteLine("x={0} y={1}", x, y);
        }

        public abstract double GetArea();
        //public virtual double GetArea()
        //{
        //    return 0;
        //}
    }

    class Triangle : Shape
    {
        public override double GetArea()
        {
            throw new NotImplementedException();
        }
    }

    class Rect : Shape
    {
        int width;
        int height;
        public Rect(int x, int y, int width, int height)
            : base(x, y)
        {
            this.width = width;
            this.height = height;
        }
        public override void Draw()
        {
            base.Draw();
            Console.WriteLine("width={0} height={1}", width, height);
        }
        public override double GetArea()
        {
            return width * height;
        }

    }
    class Circle : Shape
    {
        int radius;
        public Circle(int x, int y, int r)
            : base(x, y)
        {
            this.radius = r;
        }
        public override void Draw()
        {
            base.Draw();
            Console.WriteLine("radius={0}", radius);
        }
        public override double GetArea()
        {
            return 3.14 * radius * radius;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] p = new Shape[2];
            p[0] = new Rect(10, 10, 100, 100);
            p[1] = new Circle(10, 10, 5);
            foreach (Shape s in p)
            {
                s.Draw();
                Console.WriteLine("면적:{0}", s.GetArea());
            }
        }
    }
}
