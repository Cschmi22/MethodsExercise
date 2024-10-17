namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //MadLib();

            int added = Add(2,2);
            Console.WriteLine(added);

            int subtracted = Subtract(4, 2);
            Console.WriteLine(subtracted);

            int multiplied = Multiply(7, 8);
            Console.WriteLine(multiplied);

            int divided = Divide(6, 3);
            Console.WriteLine(divided);

            int result = Sum(5, 5, 5, 5, 5, 5, 5, 5);
            Console.WriteLine(result);
        }

        public static void MadLib()
        {
            Console.WriteLine("What is your name");
            string userName = Console.ReadLine();
            Console.WriteLine($"Hello, {userName}! What is your favorite color?");
            string favColor = Console.ReadLine();
            Console.WriteLine("Favorite band?");
            string favBand = Console.ReadLine();
            Console.WriteLine("Favorite Animal");
            string favAnimal = Console.ReadLine();

            Console.WriteLine($"One day {userName} was walking in the woods while wearing a {favColor} shirt. \n" +
                              $"{userName} spotted a {favAnimal} and it reminded {userName} of the best song by {favBand}, '{favAnimal} Ain't Supposed To Be Here'");
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }
        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        public static int Divide(int num1, int num2)
        {
            return num1 / num2;
        }

        public static int Sum(params int[] numbers)
        {
            int sum = 0;
            foreach(int number in numbers)
            {
                sum += number;
            }
            return sum;
        }
    }
}
