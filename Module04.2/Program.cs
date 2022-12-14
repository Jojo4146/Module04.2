
namespace Module04 {

    class Program {

        static void Main(string[] args)
        {

            double result;
            char choice;

            do
            {

                Console.WriteLine("Please, select from the following options: ");
                Console.WriteLine("\ta (or A). to find the AREA of a CIRCLE: ");
                Console.WriteLine("\tb (or B). to find the AREA of a SQUARE: ");
                Console.WriteLine("\tc (or C). to find the AREA of a RECTANGLE: ");
                Console.WriteLine("\td (or D). to EXIT program: ");
                choice = char.Parse(Console.ReadLine()!);

                switch (choice)
                {
                    case 'A':
                    case 'a':
                        double radius;

                        Console.WriteLine("\nArea of a Circle");
                        Console.WriteLine("\tPlease, type the radius of the Circle: ");
                        // First format exception block allowing for 'typos' or typing anything other
                        // than a number
                        try
                        {
                            radius = double.Parse(Console.ReadLine()!);
                        }
                        catch (FormatException fe)
                        {
                            Console.WriteLine(fe.Message);
                            Console.WriteLine("\t\tPlease, try again now!\n\n");
                            radius = double.Parse(Console.ReadLine()!);
                        }

                        // Solving Circle Area Method
                        result = CircleArea(radius);
                        Console.WriteLine("\n\tThe area of the circle is {0:f2}\n", result);
                        Console.WriteLine();
                        break;
                    case 'B':
                    case 'b':
                        double side;

                        Console.WriteLine("\nArea of a Square");
                        Console.WriteLine("\tPlease, type the side measure of the Square: ");
                        // Second exception block allowing for 'typos' or typing anything other
                        // than a number
                        try
                        {
                            side = double.Parse(Console.ReadLine()!);
                        }
                        catch (FormatException fe)
                        {
                            Console.WriteLine(fe.Message);
                            Console.WriteLine("\t\tPlease, try again now!\n\n");
                            side = double.Parse(Console.ReadLine()!);
                        }

                        // Solving area of Square
                        result = SquareArea(side);
                        Console.WriteLine("\n\tThe area of the square is {0:f2}\n", result);
                        Console.WriteLine();
                        break;
                    case 'C':
                    case 'c':
                        double lt = 0.0; // length
                        double wd = 0.0; // width

                        Console.WriteLine("\nArea of a Rectangle");
                        Console.WriteLine("\tPlease, type the length of the Square: ");
                        // Third format exception try catch block
                        try
                        {
                            lt = double.Parse(Console.ReadLine()!);
                        }
                        catch (FormatException fe)
                        {
                            Console.WriteLine(fe.Message);
                            Console.WriteLine("\t\tPlease, try again now!\n\n");
                            lt = double.Parse(Console.ReadLine()!);
                        }

                        Console.WriteLine("\tNow, type the width of the Square: ");
                        // Fourth try catch exception block
                        try
                        {
                            wd = double.Parse(Console.ReadLine()!);
                        }
                        catch (FormatException fe)
                        {
                            Console.WriteLine(fe.Message);
                            Console.WriteLine("\t\tPlease, try again!");
                            wd = double.Parse(Console.ReadLine()!);
                        }

                        // Solving area of square
                        result = RectangleArea(lt, wd);
                        Console.WriteLine("\n\tThe area of the rectangle is {0:f2}\n", result);
                        Console.WriteLine();
                        break;
                    case 'D':
                    case 'd':
                        break;

                    default:
                        Console.WriteLine("\n\tChoose from the choices, and try again!\n\n");
                        break;
                }

            } while (choice != 'D' && choice != 'd');
        }

        private static double CircleArea(double radius)
            {
                // Calculation of Area of Circle
                double result = Math.PI * (radius * radius);
                return result;
            }

            private static double SquareArea(double side)
            {
                // Calculation of the Area of a Square
                double result = side * side;
                return result;
            }

            private static double RectangleArea(double lt, double wd)
            {
                // Calculation of the Area of the Rectangle
                double result = lt * wd;
                return result;
            }

    }
}
