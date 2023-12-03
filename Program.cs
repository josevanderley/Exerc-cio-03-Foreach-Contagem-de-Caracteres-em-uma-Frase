using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_03_Foreach__Contagem_de_Caracteres_em_uma_Frase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*************************BEM VINDO AO PROGRAMA*****************************");

            string frase;
            int contadorVogais = 0;

            Console.WriteLine("Digite uma frase: ");
            frase = Console.ReadLine();

            foreach (char caractere in frase)
            {
                if (caractere == 'a' || caractere == 'e' || caractere == 'i' || caractere == 'o' || caractere == 'u')
                {
                    contadorVogais++;
                }
            }

            Console.WriteLine("A frase contém {0} vogais.", contadorVogais);

            Console.ReadKey();

            Console.WriteLine("Digite 1 para sair");

            Console.ReadKey();
            
        }
    }
}
    
