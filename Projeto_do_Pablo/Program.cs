using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_do_Pablo
{
    class Program
    {
        static void Main(string[] args)
        {
            string email;
            bool arroba, com;
            int i, j;

            arroba = false;
            com = false;

            email = Console.ReadLine();

            if (string.IsNullOrEmpty(email))
            {
                while (string.IsNullOrEmpty(email))
                {
                    Console.WriteLine("String vazia, digite novamente.");
                    email = Console.ReadLine();
                }
            }
            else {
                Console.WriteLine("String lida com sucesso.");
            }

            for (i = 0; i < email.Length; i++)
            {
                if (email[i] == Convert.ToChar(64))
                {
                    arroba = true;
                }
            }

            for (i =0; i < email.Length; i++)
            {
                if (string.Equals(email[i], '.') && string.Equals(email[i + 1], 'c') && string.Equals(email[i + 2], 'o') && string.Equals(email[i + 3], 'm'))
                {
                    com = true;
                }
            }

                if (arroba == true && com == true)
                {
                  Console.WriteLine("Isso é um email.");
                }
                else
                {
                Console.WriteLine("Isso não é um email.");
                }

            Console.ReadLine();

        }
    }
}
