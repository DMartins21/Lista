using System;
using System.Globalization;
using System.Collections.Generic;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos funcionarios serao registrados?");
            int n = int.Parse(Console.ReadLine());

            List<Funcionario> lista = new List<Funcionario>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Funcionario " + i);
                Console.WriteLine("ID:");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Nome");
                string nome = Console.ReadLine();
                Console.WriteLine("Salario");
                double sal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                lista.Add(new Funcionario(id, nome, sal));
            }
            Console.WriteLine("Entre com a id do funcionario que devera receber um aumento:");
            int procurarId = int.Parse(Console.ReadLine());
            Funcionario f = lista.Find(x => x.Id == procurarId);
            if (f != null)
            {
                Console.WriteLine("Qual a porcentagem do aumento?");
                double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                f.AumentarSal(x);
            }
            else
            {
                Console.WriteLine("Essa Id nao existe");
            }
            Console.WriteLine("Lista Atualizada:");
            foreach (Funcionario func in lista)
            {
                Console.WriteLine(func);
            }
        }
    }
}
