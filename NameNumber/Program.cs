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

            Console.Write("Введите число от 0 до 1000000 (включительно): ");

            try
            {
                var number = Convert.ToInt32(Console.ReadLine());
                NameNambers nameNumbers = new NameNambers(number);

                if (number > 1000000)
                {
                    Console.WriteLine("Извините, но Вы ввели слишком большое число.");
                }

                if (number == 0)
                {
                    Console.WriteLine("Перевод: zero");
                }

                else if (number > 1 && number < 10) //цифры от 1 до 9
                {
                    result = nameNumbers.Unit;
                }

                else if (number == 10 || number >= 20 && number < 100) // цифры 10 и от 20 до 99
                {
                    result = nameNumbers.Ten;
                }

                else if (number >= 11 && number < 20) // цифры от 11 до 19
                {
                    result = nameNumbers.Teen;
                }

                else if (number >= 100 && number < 1000) // цифры от 100 до 1000
                {
                    result = nameNumbers.Hundread;
                }

                else if (number >= 1000 && number < 1000000)
                {
                    result = nameNumbers.Thousand;
                }

                else if (number == 1000000)
                {
                    result = nameNumbers.Million;
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
