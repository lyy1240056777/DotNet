using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2._2
{
    class Program
    {
        public static string[] ShapeList = { null,"rectangle", "triangle", "square" };
        static void Main(string[] args)
        {
            char isContinue = 'y';
            do
            {
                Console.WriteLine("请选择要生成的图形:(1:长方形 2:三角形 3:正方形)");
                int index = Int32.Parse(Console.ReadLine());
                Shape shape;
                shape = ShapeFactory.getShape(ShapeList[index]);
                Console.WriteLine("是否继续:(y/n)");
                isContinue = char.Parse(Console.ReadLine());
            } while (isContinue != 'n');
        }
        public interface Shape
        {
            double Area { get; }
            bool IsValid();
            void Show();
        }
        class ShapeFactory
        {
            public static Shape getShape(string type)
            {
                Shape shape = null;
                if(type.Equals("rectangle"))
                {
                    shape = new Rectangle();
                    shape.Show();
                }
                else if(type.Equals("triangle"))
                {
                    shape = new Triangle();
                    shape.Show();
                }
                else if(type.Equals("square"))
                {
                    shape = new Square();
                    shape.Show();
                }
                return shape;
            }
        }
        class Rectangle : Shape
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
        class Triangle : Shape
        {
            public double Side1 { get; set; }
            public double Side2 { get; set; }
            public double Side3 { get; set; }
            public double Area
            {
                get
                {
                    double p = (Side1 + Side2 + Side3) / 2;
                    return Math.Sqrt(p * (p - Side1) * (p - Side2) * (p - Side3));
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
        class Square : Shape
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
}
