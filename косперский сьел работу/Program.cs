using System;
namespace Prog
{
    public class CustomException : Exception
    {
        public CustomException(string message) : base(message) { }
    }
    class Program
    {
        static void CheckNumber(double number) {
            if (number < 0)
            {
                throw new CustomException("Число не должно быть отрицательным.");
            }
            if (number == 0)
            {
                throw new DivideByZeroException();
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите число");
                    string input = Console.ReadLine();
                    int number = Convert.ToInt32(input);
                    CheckNumber(number);
                    
                    int result = 100 / number;
                    Console.WriteLine($"100 разделить на {number} = {result}");
                }
                catch (CustomException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Ошибка: Деление на ноль недопустимо.");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка: Ввод должен быть числом.");
                }
            }
        }
    }
}