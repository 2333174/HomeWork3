using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    public interface Diagram
    {
        void Area();
    }
    //特殊三角形：直角三角形
    class Triangle :Diagram
    {
        private int a, b;
        public Triangle(int a,int b)
        {
            this.a = a;
            this.b = b;
            Console.WriteLine("创建直角三角形");
        }
        public void Area()
        {
            Console.WriteLine(0.5*this.a*this.b);
        }
    }
    //正方形
    class Square:Diagram
    {
        private int a, b;
        public Square(int a, int b)
        {
            this.a = a;
            this.b = b;
            Console.WriteLine("创建正方形");
        }
        public void Area()
        {
            Console.WriteLine(a*b);
        }
    }
    //长方形
    class Rectangle : Diagram
    {
        private int a, b;
        public Rectangle(int a, int b)
        {
            this.a = a;
            this.b = b;
            Console.WriteLine("创建长方形");
        }
        public void Area()
        {
            Console.WriteLine(a * b);
        }
    }
    //圆形
    class Round : Diagram
    {
        private int a, b;
        public Round(int a, int b)
        {
            this.a = a;
            this.b = b;
            Console.WriteLine("创建圆形");
        }
        public void Area()
        {
            Console.WriteLine(3.1415 * a * b);
        }
    }
    class DiagramF
    {
        public static Diagram GetDiagram(string Type,int a,int b)
        {
            Diagram diagram = null;
            if (Type.Equals("Triangle"))
            {
                diagram = new Triangle(a,b);
            }
            else if (Type.Equals("Square"))
            {
                diagram = new Square(a, b);
            }
            else if (Type.Equals("Round"))
            {
                diagram = new Round(a, b);
            }
            else
            {
                diagram = new Rectangle(a,b);
            }
            return diagram;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Diagram diagram;
            diagram = DiagramF.GetDiagram("Round", 2, 2);
            diagram.Area();
        }
    }
}
