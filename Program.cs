using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertitore_BinDec
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool[] binario = { true, false, true, false };
            int[] puntato = { 10, 10, 10, 10 };
            Console.WriteLine(Convert_Binario_To_Decimale(binario));
            Console.WriteLine(Convert_Decimale_Puntato_To_Decimale(puntato));
            Console.ReadLine();
        }

        static int Convert_Binario_To_Decimale(bool[] b)
        {
            int dec = 0;
            Array.Reverse(b);
            for (int i = 0; i < b.Length; i++)
                if (b[i])
                    dec += (int)(Math.Pow(2, i));
            return dec;
        }

        static int Convert_Decimale_Puntato_To_Decimale(int[] decpunt)
        {
            int dec = 0;
            Array.Reverse(decpunt);
            for (int i = 0; i < decpunt.Length; i++)
            {
                dec += decpunt[i] * (int)(Math.Pow(256, i));
            }
            return dec;
        }
    }
}