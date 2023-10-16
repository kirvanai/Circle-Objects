namespace Circle_Objects
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Circle Tester!");
            Console.WriteLine("Please input a radius:");
            double radiusInput = Validator.DoubleValidator(Console.ReadLine());
            Circle circle = new Circle(radiusInput);
            CircleProgram(circle);
            string yOrN = Validator.YesOrNoValidator(Console.ReadLine());
            while (yOrN == "y")
            {
                circle.Grow(circle);
                CircleProgram(circle);
                yOrN = Validator.YesOrNoValidator(Console.ReadLine());
            }
            if (yOrN == "n")
            {
                Console.WriteLine($"Goodbye! The circle's final radius is {circle.GetRadius(circle)}!");
            }
            
        }

        public static void CircleProgram (Circle circle)
        {
            Console.WriteLine("Diamter: " + circle.CalculateDiamter(circle.GetRadius(circle)));
            Console.WriteLine("Circumference: " + circle.CalculateCircumference(circle.GetRadius(circle)));
            Console.WriteLine("Area: " + circle.CalculateArea(circle.GetRadius(circle)));
            Console.WriteLine("Should the circle grow? y/n");
        }


    }
}