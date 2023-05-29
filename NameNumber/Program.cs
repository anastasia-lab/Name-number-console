using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string result;

            Console.Write("Введите целое число от 0 до 1000000 (включительно): ");

            try
            {
                string UserInputNumber = Console.ReadLine();

                if (UserInputNumber == "" || !int.TryParse(UserInputNumber, out int outNumber))
                    Console.WriteLine("Проверите правильное написание числа");
                else
                {
                    int IntNumber = int.Parse(UserInputNumber);
                    NameNambers nameNumbers = new NameNambers(IntNumber);


                    if (IntNumber > 1000000)
                    {
                        Console.WriteLine("Извините, но Вы ввели слишком большое число.");
                    }

                    if (IntNumber == 0)
                    {
                        Console.WriteLine("Перевод: zero");
                    }

                    else if (IntNumber > 1 && IntNumber < 10) //цифры от 1 до 9
                    {
                        result = nameNumbers.Unit;
                    }

                    else if (IntNumber == 10 || IntNumber >= 20 && IntNumber < 100) // цифры 10 и от 20 до 99
                    {
                        result = nameNumbers.Ten;
                    }

                    else if (IntNumber >= 11 && IntNumber < 20) // цифры от 11 до 19
                    {
                        result = nameNumbers.Teen;
                    }

                    else if (IntNumber >= 100 && IntNumber < 1000) // цифры от 100 до 1000
                    {
                        var remainsDecade = IntNumber % 100; // остаток от 100

                        if (remainsDecade >= 0 && remainsDecade < 1000)
                        {
                            result = nameNumbers.Hundread;
                        }
                    }

                    else if (IntNumber >= 1000 && IntNumber < 1000000)
                    {

                        result = nameNumbers.Thousand;
                    }

                    else if (IntNumber == 1000000)
                    {
                        result = nameNumbers.Million;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            Console.ReadKey();
        }
    }
}
