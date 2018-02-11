using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSYSTEM
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numberOfLines; i++)
            {
                string line = Console.ReadLine();
                string[] numbers = line.Split(' ');
                int number1 = changeToInt(numbers[0]);
                int number2 = changeToInt(numbers[1]);
                Console.WriteLine(changeToString(number1 + number2));
            }
        }

        static int changeToInt(string number)
        {
            int total = 0;
            string temp = string.Empty;
            for (int i = 0; i < number.Length; i++)
            {
                if (char.IsDigit(number[i]))
                {
                    temp += number[i];
                }
                else
                {
                    switch (number[i]) ///3m33c3x4i
                    {
                        case 'm':
                            if (temp == string.Empty)
                            {
                                total += 1000;
                            }
                            else
                                total += Int32.Parse(temp) * 1000;
                            break;
                        case 'c':
                            if (temp == string.Empty)
                            {
                                total += 100;
                            }
                            else
                                total += Int32.Parse(temp) * 100;
                            break;
                        case 'x':
                            if (temp == string.Empty)
                            {
                                total += 10;
                            }
                            else
                                total += Int32.Parse(temp) * 10;
                            break;
                        case 'i':
                            if (temp == string.Empty)
                            {
                                total += 1;
                            }
                            else
                                total += Int32.Parse(temp) * 1;
                            break;
                        default:
                            break;
                    }
                    temp = string.Empty;
                };
                if (Char.IsDigit(number[i]) && (i == number.Length - 1))
                {
                    total += Int32.Parse(temp);
                }

            }
            return total;
        }

        static string changeToString(int number)
        {
            string nDigit = string.Empty;
            int denominator;
            if (number >= 1000)
            {
                denominator = 1000;
            }
            else if (number >= 100)
            {
                denominator = 100;
            }
            else if (number >= 10)
            {
                denominator = 10;
            }
            else
            {
                denominator = 1;
            }
            while (denominator != 0)
            {
                int remaind = number / denominator;
                if (remaind != 0 && remaind != 1)
                {
                    nDigit += remaind;
                }
                number = number - remaind * denominator;
                switch (denominator)
                {
                    case (1000):
                        if (remaind == 0)
                            break;
                        nDigit += "m";
                        break;
                    case (100):
                        if (remaind == 0)
                            break;
                        nDigit += "c";
                        break;
                    case (10):
                        if (remaind == 0)
                            break;
                        nDigit += "x";
                        break;
                    case (1):
                        if (remaind == 0)
                            break;
                        nDigit += "i";
                        break;
                    default:
                        break;
                }
                denominator = denominator / 10;
            }
            return nDigit;
        }
    }
}
