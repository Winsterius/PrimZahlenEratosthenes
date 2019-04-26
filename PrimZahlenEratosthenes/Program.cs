using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimZahlenEratosthenes
{
    class Program
    {
        int[] TheArray;
        int length;

        static void Main(string[] args)
        {
            Program p = new Program();
            
            p.ShowRequest("Bestimmen Sie die Länge des Arrays");
            p.CreatingTheArray(p.length);
            p.CheckingTheNumbers(p.TheArray);
            p.ShowTheArray(p.TheArray);

            Console.ReadKey();
        }

        void ShowRequest(string str)
        {
            Console.WriteLine(str);
            while (!int.TryParse(Console.ReadLine(), out this.length)) Console.WriteLine("Falsche Eingabe");
        }
        void CreatingTheArray(int l)
        {
            TheArray = new int[l - 2];
            for (int i = 0; i < TheArray.Length; i++)
            {
                TheArray[i] = i + 2;
            }
        }
        void CheckingTheNumbers(int[] arr)
        {
            for (int i = 0; arr[i] * arr[i] < arr.Length; i++)
            {
                int temp = arr[i];
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] != 0)
                    {
                        if (arr[j] % temp == 0) arr[j] = 0;
                    }
                }                            
            }
            TheArray = arr;
        }
        void ShowTheArray(int[] arr)
        {
            foreach(int i in arr)
            {
                if (i != 0) Console.Write("{0,10}", i);
            }
        }
    }
}
