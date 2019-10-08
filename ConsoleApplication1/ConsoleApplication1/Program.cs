using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine('A');
            //char c = 'A';
            //Console.WriteLine(c);
            //short s = 0x41;
            //Console.WriteLine((char) s);
            //c = (char)s;
            //Console.WriteLine(c);
            //c++;
            //Console.WriteLine(c);

            Print_a_2_z();
            Print_z_2_a();
            Print_A_2_Z();
            OPASC('c');
            LowOrUp('H');
            Change('H');
        }

        public static void Print_a_2_z()
        {
            short s = 97;
            for (int i = 0; i < 26; i++)
            {
                Console.WriteLine((char)s);
                s++;
            }
        }

        public static void Print_z_2_a()
        {
            short s = 122;
            for (int i = 0; i < 26; i++)
            {
                Console.WriteLine((char)s);
                s--;
            }
        }

        public static void Print_A_2_Z()
        {
            short s = 65;
            for (int i = 0; i < 26; i++)
            {
                Console.WriteLine((char)s);
                s++;
            }
        }

        public static void OPASC(char c)
        {
            Console.WriteLine((short)c);
        }

        public static void LowOrUp(char c)
        {
            if ((short)c <= 90 && (short)c >= 65)
            {
                Console.WriteLine("Inputted character is upper case");
            }
            else if ((short)c <= 122 && (short)c >= 97)
            {
                Console.WriteLine("Inputted character is lower case");
            }
        }

        public static void Change(char c)
        {
            short change = (short)c;
            if (change >= 97)
            {
                change -= 32;
            }
            else
                change += 32;
            Console.WriteLine(c);
            Console.WriteLine((char)change);
        }
    }
}
