namespace Divisibility_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            //متدی بنویسید که دو عدد از کاربر دریافت کرده و بررسی کنو دوعدد بر هم بخش پذیر است یا خیر
            Console.WriteLine("Number1 ?");
            string numberSTR1 = Console.ReadLine();
            Console.WriteLine("Number2 ?");
            string numberSTR2 = Console.ReadLine();
            int number1 = int.Parse(numberSTR1);
            int number2 = int.Parse(numberSTR2);
            //Console.WriteLine($"Answer: {IsDivisible(num1:number1, num2:number2)}");
            if (IsDivisible(number1, number2))
            {
                Console.WriteLine($"Yes! {number1} and {number2} are divisible.");
            }
            else

            {
                Console.WriteLine($"No! {number1} and {number2} are not divisible.");
            }




            //عددی را از کاربر دریافت کنید و بررسی کنید زوج است یا فرد؟
            /*Console.WriteLine("Enter a Number:");
            string numSTR = Console.ReadLine();
            int result = int.Parse(numSTR);
            if (EvenOrOdd(result))
            {
                Console.WriteLine($"{result}: This Number Is Even");
            }
            else
            {
                Console.WriteLine($"{result}: This Number Is Odd");
            }*/



            //عددی را دریافت کنید و بررسی کنید بر5 بخش پذیر است یا خیر
            /*Console.WriteLine("Enter a Number:");
            string numSTR = Console.ReadLine();
            int result = int.Parse(numSTR);
            bool Isvalid = DivisibleByFive(result);
            Console.WriteLine(Isvalid);*/



            //متدی بنویسید که جمع 1 تا 15 را انجام دهد
            /*int sum = AddingNumbersOneToFifteen();
            Console.WriteLine($"Adding numbers one to fifteen: {sum}");*/

            while (true)
            {
                Console.Write("enter A/a for exit: ");
                char key = Console.ReadKey().KeyChar;
                Console.WriteLine();
                if (key == 'A' || key == 'a')
                    break;
            }

        }
        static bool IsDivisible(int num1, int num2)
        {
            return (num1 % num2 == 0 ||  num2 % num1 == 0);
        }

        static bool EvenOrOdd(int num)
        {
            return num % 2 == 0;
        }

        static bool DivisibleByFive(int num)
        {
            if (num % 5 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static int AddingNumbersOneToFifteen()
        {
            int sum = 0;
            for (int i = 1; i <= 15; i++)
            {
                sum += i;
            }
            return sum;
        }
    }
}
