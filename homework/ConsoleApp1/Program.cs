
using System.ComponentModel.Design;

namespace ConsoleApp1
{
    internal class Program
    {



        public class Circle
        {

            private double radius;
            private double diameter;


            public Circle()
            {

                radius = 10;
                diameter = 5;
            }

            public Circle(double radius)
            {
                SetRadius(radius);
            }

            public void PrintInfo()
            {
                if (radius == 0 && diameter == 0)
                {
                    Console.WriteLine("Values are not set!");
                }
                else
                {
                    Console.WriteLine($"Circle radius is {radius} and circle diameter is {diameter}");
                }
            }


            public void SetRadius(double radius)
            {
                this.radius = radius;
                this.diameter = radius * 2;
            }


            public void SetDiameter(double diameter)
            {
                this.diameter = diameter;
                this.radius = diameter / 2;
            }


            public void CalculateArea()
            {
                double area = Math.PI * Math.Pow(radius, 2);
                Console.WriteLine($"Circle area is {Math.Round(area, 2)}");
            }


            public void CalculateCircumference()
            {
                double circumference = 2 * Math.PI * radius;
                Console.WriteLine($"Circle circumference is {Math.Round(circumference, 2)}");
            }
        }

        class Final
        {
            static void Main(string[] args)
            {

                Circle circle1 = new Circle();
                circle1.PrintInfo();


                circle1.SetRadius(5);


                circle1.CalculateArea();
                circle1.CalculateCircumference();


                Circle circle2 = new Circle(3);
                circle2.PrintInfo();


                circle2.SetDiameter(10);

                circle2.CalculateArea();
                circle2.CalculateCircumference();
            }
        }
    }

}






