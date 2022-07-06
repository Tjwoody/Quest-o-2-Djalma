using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão_2_Djalma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mesX = null;
            int cdg, dia, mes, ano;
            string datadeHJ;
            Console.Write("1 - Atibaia  2 - Bragança Paulista  3 - Nazaré  4 - Mariporã  5  - Terra Preta  6 - Extrema  7 - Vargem\t ");
            Console.WriteLine("\t\tinforme codigo da cidade desejada:");
            cdg = Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe a Data Atual");
            var dA = Convert.ToDateTime(Console.ReadLine());
            dia = dA.Day;
            mes = dA.Month;
            ano = dA.Year;


            switch (mes)
            {
                case 1:
                    mesX = "Janeiro";
                    break;
                case 2:
                    mesX = "Fevereiro";
                    break;
                case 3:
                    mesX = "Março";
                    break;
                case 4:
                    mesX = "Abril";
                    break;
                case 5:
                    mesX = "Maio";
                    break;
                case 6:
                    mesX = "Junho";
                    break;
                case 7:
                    mesX = "Julho";
                    break;
                case 8:
                    mesX = "Agosto";
                    break;
                case 9:
                    mesX = "Setembro";
                    break;
                case 10:
                    mesX = "Outubro";
                    break;
                case 11:
                    mesX = "Novembro";
                    break;
                case 12:
                    mesX = "Dezembro";
                    break;
            }
            datadeHJ = dia + " de " + mesX + " de " + ano;
            if (cdg == 1)
            {
                Console.WriteLine("Em Atibaia hoje é " + datadeHJ);
            }
            if (cdg == 2)
            {
                Console.WriteLine("Em Bragança Paulista hoje é " + datadeHJ);
            }
            if (cdg == 3)
            {
                Console.WriteLine("Em Mairiporã hoje é " + datadeHJ);
            }
            if (cdg == 4)
            {
                Console.WriteLine("Em Nazaré hoje é " + datadeHJ);
            }
            if (cdg == 5)
            {
                Console.WriteLine("Em Terra Preta hoje é " + datadeHJ);
            }
            if (cdg == 6)
            {
                Console.WriteLine("Em Extrema hoje é " + datadeHJ);
            }
            if (cdg == 7)
            {
                Console.WriteLine("Em Vargem hoje é " + datadeHJ);
            }

            Console.ReadKey();
        }
    }
}