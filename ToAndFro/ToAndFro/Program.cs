using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToAndFro
{

}
class Program
{
    static void Main(string[] args)
    {
        int numberOfColumns = Convert.ToInt32(Console.ReadLine());
        string criptedCode = Console.ReadLine();
        while (numberOfColumns != 0)
        {
            int start = 0;
            int numberOfRows = criptedCode.Length / numberOfColumns;
            string uncriptedReversedCode = string.Empty;
            for (int i = 0; i < numberOfRows; i++)
            {
                string temp = string.Empty;
                if (start < criptedCode.Length)
                {
                    temp = criptedCode.Substring(start, numberOfColumns);
                    start += numberOfColumns;
                    if (i % 2 != 0)
                    {
                        char[] tempArr = temp.ToCharArray();
                        Array.Reverse(tempArr);
                        temp = new string(tempArr);
                    }
                    uncriptedReversedCode += temp;
                }
            }
            string dicriptedMessage = string.Empty;
            for (int i = 0; i < numberOfColumns; i++)
            {
                for (int col = 0; col < uncriptedReversedCode.Length; col += numberOfColumns)
                {
                    dicriptedMessage += uncriptedReversedCode[col + i];
                }
            }
            Console.WriteLine(dicriptedMessage);
            numberOfColumns = Convert.ToInt32(Console.ReadLine());
            criptedCode = Console.ReadLine();
        }
    }
}

