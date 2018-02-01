using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nhập vào chiều rộng hình chữ nhật
            Console.Write("Enter the width of the rectangle : ");
            double width = double.Parse(Console.ReadLine());

            //Nhập vào chiều cao hình chữ nhật
            Console.Write("Enter the height of the rectangle : ");
            double height = double.Parse(Console.ReadLine());

            //Khởi tạo đối tượng của lớp Rectangle
            Rectangle rectangleObject = new Rectangle(height, width);

            //Gọi phương thức hiển thị hình chữ nhật
            rectangleObject.Display();

            Console.ReadLine();
        }
    }

    public class Rectangle
    {
        private double _height;
        public double Height
        {
            get { return _height; }
            set { _height = value; }
        }

        private double _width;
        public double Width
        {
            get { return _width; }
            set { _width = value; }
        }

        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }

        public double GetPerimeter()
        {
            return (Height + Width) * 2.0;
        }

        public double GetArea()
        {
            return Height * Width;
        }

        public void Display()
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("The width of the rectangle is: {0}", Width);
            Console.WriteLine("The height of the rectangle is: {0}", Height);
            Console.WriteLine("The perimeter of the rectangle is: {0}", GetPerimeter());
            Console.WriteLine("The area of the rectangle is: {0}", GetArea());
        }
    }

}
