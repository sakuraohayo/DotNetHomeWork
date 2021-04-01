using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Factory
{
    public abstract class Shape
    {
        //面积
        public abstract double Area();
        public abstract bool IsLegal();
    }
    public class Circle : Shape
    {
        double _r;
        public double R
        {
            get { return _r; }
            set
            {
                _r = value;
            }
        }
        public Circle(double r)
        {
            this.R = r;
        }
        public override bool IsLegal()
        {
            if (R > 0)
                return true;
            else
                return false;
        }
        public override double Area()
        {
            if (IsLegal())
                return Math.PI * this.R * this.R;
            else
                return 0;
        }

    }
    public class Rectangle : Shape
    {
        private double _height;
        private double _width;
        public double Height
        {
            get { return _height; }
            set { _height = value; }
        }
        public double Width
        {
            get { return _width; }
            set { _width = value; }
        }

        public Rectangle(double height, double width)
        {
            this.Height = height;
            this.Width = width;
        }
        public override bool IsLegal()
        {
            if (Height > 0 && Width > 0)
                return true;
            else
                return false;
        }
        public override double Area()
        {
            if (IsLegal())
                return this.Width * this.Height;
            else
                return 0;
        }

    }
    public class Square : Rectangle
    {
        private double _side;
        public double Side
        {
            get { return _side; }
            set { _side = value; }
        }
        public Square(double side) : base(side, side)
        {
            this.Side = side;
        }
        public override bool IsLegal()
        {
            if (Side > 0)
                return true;
            else
                return false;
        }
        public override double Area()
        {
            return this.Side * this.Side;
        }
    }
    public class Triangle : Shape
    {
        double _aside, _bside, _cside;
        public double aSide
        {
            get { return _aside; }
            set { _aside = value; }
        }
        public double bSide
        {
            get { return _bside; }
            set { _bside = value; }
        }
        public double cSide
        {
            get { return _cside; }
            set { _cside = value; }
        }
        public Triangle(double aside, double bside, double cside)
        {
            this.aSide = aside;
            this.bSide = bside;
            this.cSide = cside;
        }
        public override bool IsLegal()
        {
            if (aSide > 0 && bSide > 0 && cSide > 0 && aSide + bSide > cSide && aSide + cSide > bSide && bSide + cSide > aSide)
                return true;
            else
                return false;
        }
        public override double Area()
        {
            double s = (aSide + bSide + cSide) / 2;
            double S = (float)Math.Sqrt(s * (s - aSide) * (s - bSide) * (s - cSide));
            if (IsLegal())
                return S;
            else
                return 0;
        }
    }
    public class Factory                                       //工厂类
    {
        public static Shape getShape(String arg, double n1 = 0.0, double n2 = 0.0, double n3 = 0.0)         //工厂方法
        {
            Shape shape = null;
            switch (arg)
            {
                case "Circle":
                    shape = new Circle(n1);
                    break;
                case "Rectangle":
                    shape = new Rectangle(n1, n2);
                    break;
                case "Square":
                    shape = new Square(n1);
                    break;
                case "Triangle":
                    shape = new Triangle(n1, n2, n3);
                    break;
                default:
                    Console.WriteLine("类型错误！");
                    break;
            }
            return shape;
        }
    }

    class Program
    {
        static void Main(String[] args)
        {
            String[] types = { "Circle", "Rectangle", "Square", "Triangle" };
            Shape[] shapes = new Shape[10];
            Random random = new Random();
            double sum = 0.0;

            for (int i = 0; i < 10; i++)
            {
                int num = random.Next(0, 3);                     //随机生成图形的形状
                String type = types[num];
                switch (num)                                       //根据图形形状，使用工厂方法交互生成图形
                {
                    case 0:
                        Console.WriteLine("请输入圆形的半径：");
                        double r = Double.Parse(Console.ReadLine());
                        shapes[i] = Factory.getShape("Circle", r);
                        break;
                    case 1:
                        Console.WriteLine("请输入长方形的长：");
                        double length = Double.Parse(Console.ReadLine());
                        Console.WriteLine("请输入长方形的宽：");
                        double width = Double.Parse(Console.ReadLine());
                        shapes[i] = Factory.getShape("Rectangle", length, width);
                        break;
                    case 2:
                        Console.WriteLine("请输入正方形的边长：");
                        double side = Double.Parse(Console.ReadLine());
                        shapes[i] = Factory.getShape("Square", side);
                        break;
                    case 3:
                        Console.WriteLine("请输入三角形第一条边长：");
                        double aside = Double.Parse(Console.ReadLine());
                        Console.WriteLine("请输入三角形第二条边长：");
                        double bside = Double.Parse(Console.ReadLine());
                        Console.WriteLine("请输入三角形第三条边长：");
                        double cside = Double.Parse(Console.ReadLine());
                        shapes[i] = Factory.getShape("Triangle", aside, bside, cside);
                        break;

                }

            }
            foreach (Shape shape in shapes)                          //求所有图形的面积之和
            {
                double area = shape.Area();
                sum += area;
            }
            Console.WriteLine("十个形状的面积之和为:" + sum);
            Console.ReadKey();
        }
    }

}


