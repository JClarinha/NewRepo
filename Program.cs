using System.Collections.Concurrent;
using System.Net.Cache;
using System.Security.Claims;

namespace RumosSecção2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* //1.
             //a. var array = [1, 2, 3, 4, 5]; -> Um Array tem de ter um tipo definido, é inicializado com "[]";
             //b. public Class Pessoa { }; -> "Class" é com letra minúscula;
             //c. public Struct pixel { }; -> "Struck tem de iniciar com letra minúscula e "píxel" deve ser iniciada com letra maiúscula;

             //2.
             char[] chars = new char[5];

             Console.WriteLine("Por favor insira os 5 caracteres que pretende.");

             for (int i = 0; i < chars.Length; i++)
             {
                 char ar = Console.ReadKey().KeyChar;
                 chars[i] = ar;
                 Console.WriteLine();
             }

             //a

             char[] chars1 = chars;
             Console.WriteLine("_______________________________________________________");
             //b

             for (int i = 0; i < chars1.Length; i++)
             {
                 Console.WriteLine("\n" + chars1[i]);
             }

             Console.WriteLine("_______________________________________________________");

             for (int i = 4; i >= 0 ; i--)
             {
                 Console.WriteLine("\n" + chars1[i]);
             }

             //c

             Console.WriteLine(chars1[2..5]);

             //d

             Console.WriteLine(chars1[0..3]);

             //e

             Console.WriteLine(chars1[0]);

             //f

             Console.WriteLine(chars1[4]);*/

            //3.

            //a

            Date idade = new Date();

            Console.WriteLine("Por favor introduzar a sua data de nascimeto.");
            Console.Write("Dia: "); 
            idade.d = int.Parse(Console.ReadLine());
            Console.Write("Mês: ");
            idade.m = int.Parse(Console.ReadLine());
            Console.Write("Ano: ");
            idade.a = int.Parse(Console.ReadLine());

         
            int yearc = DateTime.Now.Year;
            int monthc = DateTime.Now.Month;
            int dayc = DateTime.Now.Day;


            Console.WriteLine(idade.Age(idade.d, idade.m, idade.a, dayc, monthc,yearc));

            









        }

    }
}
