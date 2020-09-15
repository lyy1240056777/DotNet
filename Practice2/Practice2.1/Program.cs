using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rec = new Rectangle();
            rec.Show();
            Triangle tri = new Triangle();
            tri.Show();
            Square sq = new Square();
            sq.Show();
        }
    }
    public interface Shape
    {
        double Area { get; }
        bool IsValid();
        void Show();
    }
    class Rectangle: Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public bool IsValid()
        {
            if (Length > 0 && Width > 0) return true;
            else return false;
        }
        public double Area
        {
            get
            {
                return Length * Width;
            }
        }
        public void Show()
        {
            Console.Write("请输入长方形的长:");
            Length = double.Parse(Console.ReadLine());
            Console.Write("请输入长方形的宽:");
            Width = double.Parse(Console.ReadLine());
            if (!IsValid()) Console.WriteLine("图形不合法!");
            else Console.WriteLine("图形面积:" + Area);
        }
    }
    class Triangle: Shape
    {
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }
        public double Area
        {
            get
            {
                double p = (Side1 + Side2 + Side3)/2;
                return Math.Sqrt(p * (p-Side1) * (p-Side2) * (p-Side3));
            }
        }
        public bool IsValid()
        {
            if (Side1 + Side2 > Side3 && Side1 + Side3 > Side2 && Side2 + Side3 > Side1)
                return true;
            else return false;
        }
        public void Show()
        {
            Console.Write("请输入三角形的第一条边长:");
            Side1 = double.Parse(Console.ReadLine());
            Console.Write("请输入三角形的第二条边长:");
            Side2 = double.Parse(Console.ReadLine());
            Console.Write("请输入三角形的第三条边长:");
            Side3 = double.Parse(Console.ReadLine());
            if (!IsValid()) Console.WriteLine("图形不合法!");
            else Console.WriteLine("图形面积:" + Area);
        }
    }
    class Square: Shape
    {
        public double Side { get; set; }
        public double Area
        {
            get
            {
                return Side * Side;
            }
        }
        public bool IsValid()
        {
            if (Side > 0) return true;
            else return false;
        }
        public void Show()
        {
            Console.Write("请输入正方形边长:");
            Side = double.Parse(Console.ReadLine());
            if (!IsValid()) Console.WriteLine("图形不合法!");
            else Console.WriteLine("图形面积:" + Area);
        }
    }
}