using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameNumber
{
    public class NameNambers
    {
        string[] units = { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        string[] teens = { "", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
        string[] tens = { "", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
        string[] more = { "", "thousand", "million" };
        string result;
        int number;

        public NameNambers(int _number)
        {
            this.number = _number;
        }

        public string Unit // единицы
        {
            get
            {
                result = units[number]; //цифры от 1 до 9
                Console.WriteLine("Перевод: {0}", result);

                return result;
            }
        }

        public string Ten // десятки (10, 20-100)
        {
            get
            {
                var decade = tens[number / 10]; // цифры 10 и от 20 до 99
                var remains = number % 10;
                result = decade + " " + Unit;
                Console.WriteLine("Перевод: {0}", result);

                return result;
            }
        }

        public string Teen // десятки (11-19)
        {
            get
            {
                result = teens[number - 10];
                Console.WriteLine("Перевод: {0}", result);

                return result;
            }
        }

        public string Hundread // сотни
        {
            get
            { // цифры от 100 до 1000
                var hundread = units[number / 100]; // сотни в числе
                var remainsDecade = number % 100; // остаток от 100

                if (remainsDecade >= 11 && remainsDecade < 20) // если остаток от 11 до 19
                {
                    var decade = teens[remainsDecade - 10]; // десятки числа

                    result = hundread + " " + "hundread" + " " + "and" + " " + decade; //
                    Console.WriteLine("Перевод: {0}", result);
                }
                else if (remainsDecade == 10 || remainsDecade >= 20 && remainsDecade < 100) // если остаток 10 и от 20 до 99
                {
                    var decade = tens[remainsDecade / 10]; //десятки
                    var unit = remainsDecade % 10;// остаток от единиц (часть от десятка)

                    result = hundread + " " + "hundread" + " " + "and" + " " + decade + " " + units[unit];
                    Console.WriteLine("Перевод: {0}", result);
                }
                else if (remainsDecade >= 1 && remainsDecade < 10) // если остаток от 0 до 9
                {
                    var unit = remainsDecade % 10; // остаток от единиц (часть от десятка)
                    result = hundread + " " + "hundread" + " " + "and " + " " + units[unit];
                    Console.WriteLine("Перевод: {0}", result);
                }
                else if (remainsDecade == 0) // остаток 0 от 100
                {
                    var unit = remainsDecade % 10; // остаток от единиц (часть от десятка)
                    result = hundread + " " + "hundread" + units[unit];
                    Console.WriteLine("Перевод: {0}", result);
                }

                return result;
            }
        }

        public string Thousand
        {
            get
            {
                var thousand = units[number / 1000];
                var remainsThousand = number % 1000;

                if (remainsThousand == 0) // остаток 0 от 1000
                {
                    var unit = remainsThousand % 10; // остаток от единиц (часть от десятка)
                    result = thousand + " " + more[1];
                    Console.WriteLine("Перевод: {0}", result);
                }

                if (remainsThousand >= 1 && remainsThousand < 10) //остаток 1-9 от 1000
                {
                    var unit = remainsThousand % 10; // остаток от единиц (часть от десятка)
                    result = thousand + " " + more[1] + " " + "and" + " " + units[unit];
                    Console.WriteLine("Перевод: {0}", result);
                }

                if (remainsThousand == 10 || remainsThousand >= 20 && remainsThousand < 100) // остаток 10 или 20-99 от 1000
                {
                    var ThousandDecade = tens[remainsThousand / 10]; //десятки
                    var ThousandUnit = remainsThousand % 10;// остаток от единиц (часть от десятка)

                    result = thousand + " " + more[1] + "and" + " " + ThousandDecade + " " + units[ThousandUnit];
                    Console.WriteLine("Перевод: {0}", result);
                }

                if (remainsThousand >= 11 && remainsThousand < 20) // остаток 11-19 от 1000
                {
                    var ThousandDecade = teens[remainsThousand - 10]; // десятки числа

                    result = thousand + " " + more[1] + " " + "and" + " " + ThousandDecade; //
                    Console.WriteLine("Перевод: {0}", result);
                }

                if (remainsThousand >= 100 && remainsThousand < 1000) // остаток 100-99 от 1000
                {
                    // цифры от 100 до 1000
                    var remainsHundread = remainsThousand / 100;
                    var hundread = units[remainsHundread]; // сотни в числе
                    var remainsDecade = remainsThousand % 100; // остаток от 100

                    if (remainsDecade >= 11 && remainsDecade < 20) // если остаток от 11 до 19
                    {
                        var decade = teens[remainsDecade - 10]; // десятки числа

                        result = thousand + " " + more[1] + " " + hundread + " " + "hundread" + " " + "and" + " " + decade; //
                        Console.WriteLine("Перевод: {0}", result);
                    }
                    else if (remainsDecade == 10 || remainsDecade >= 20 && remainsDecade < 100) // если остаток 10 и от 20 до 99
                    {
                        var decade = tens[remainsDecade / 10]; //десятки
                        var unit = remainsDecade % 10;// остаток от единиц (часть от десятка)

                        result = thousand + " " + more[1] + " " + hundread + " " + "hundread" + " " + "and" + " " + decade + " " + units[unit];
                        Console.WriteLine("Перевод: {0}", result);
                    }
                    else if (remainsDecade >= 0 && remainsDecade < 10) // если остаток от 0 до 9
                    {
                        var unit = remainsDecade % 10; // остаток от единиц (часть от десятка)
                        result = thousand + " " + more[1] + " " + hundread + " " + "hundread" + " " + units[unit];
                        Console.WriteLine("Перевод: {0}", result);
                    }
                }

                return result;
            }
        }

        public string Million
        {
            get
            {
                var million = units[number / 1000000];
                result = million + " " + more[2];

                Console.WriteLine("Перевод: {0}", result);
                return result;
            }
        }
    }
}
