using System;
using System.Globalization;

namespace Week2Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            ExerciseOne();
            ExerciseTwo();
            ExerciseThree();
            ExerciseFour();
            ExerciseFive();
        }

        private static void ExerciseOne() 
        {
            string firstName;
            string lastName;
            int age;
            char gender;
            long PESEL;
            long employeeNo;
        }


        private static void ExerciseTwo()
        {
            char firstLetter = 'a';
            char secondLetter = 'b';
            char thirdLetter = 'c';

            WriteLettersInReverseOrder(firstLetter, secondLetter, thirdLetter);
        }

        private static void WriteLettersInReverseOrder(char firstLetter, char secondLetter, char thirdLetter)
        {
            Console.WriteLine(thirdLetter);
            Console.WriteLine(secondLetter);
            Console.WriteLine(firstLetter);
        }


        private static void ExerciseThree()
        {
            Console.WriteLine("Please type rectangle's width:");
            double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Please type rectangle's height:");
            double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double rectangleDiagonalLength = CalculateRectangleDiagonalLength(width, height); ;

            Console.WriteLine($"Rectangle's diagonal length is {rectangleDiagonalLength}");
        }

        private static double CalculateRectangleDiagonalLength(double rectangleWidth, double rectangleHeight)
            => Math.Sqrt(Math.Pow(rectangleWidth, 2) + Math.Pow(rectangleHeight, 2));


        private static void ExerciseFour()
        {
            int firstNumber = 10;
            string coolSchool = "Szkoła Dotneta";
            double secondNumber = 12.5;
        }


        private static void ExerciseFive() 
        {
            Console.WriteLine("Enter your first name:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter your last name:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter your phone number:");
            long phone = long.Parse(Console.ReadLine());

            Console.WriteLine("Enter your email:");
            string email = Console.ReadLine();

            Console.WriteLine("Enter your height in cm:");
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your weight in kg:");
            double weight = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter money value in your bank account:");
            decimal money = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter your favourite .NET coding school name:");
            string schoolName = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine($"Your complete personal data: {firstName}, {lastName} {phone}, {email}, {height}cm, {weight}kg, {money:0:C2}, {schoolName}");
        }
    }
}