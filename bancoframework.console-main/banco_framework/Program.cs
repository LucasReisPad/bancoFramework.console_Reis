using System.Globalization;
using System.Runtime.CompilerServices;
using CpfCnpjLibrary;
using Domain.Model;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Seja bem vindo ao banco Framework");
        Console.WriteLine("Por favor, identifique-se");
        Console.WriteLine("");
        var pessoa = Identificacao();
        pessoa.Ação();
    }

    static Pessoa Identificacao()
    {
        List<string> errorMessages = new List<string>();
        var pessoa = new Pessoa();
        bool flag = false;

        while (!flag)
        {

            Console.WriteLine("Seu número de identificação:");
            pessoa.Id = int.Parse(Console.ReadLine());

            Console.WriteLine("Seu nome:");
            pessoa.Nome = Console.ReadLine()!;

            Console.WriteLine("Seu CPF:");
            pessoa.Cpf = Console.ReadLine()!;
            if (!Cpf.Validar(pessoa.Cpf))
            {
                errorMessages.Add("Cpf Inválido");
            }

            Console.Write("Seu Saldo: ");
            pessoa.Saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (pessoa.Saldo < 0)
            {
                errorMessages.Add("Saldo Inválido, Não pode ser menor que 0");
            }

            if (errorMessages.Count > 0)
            {
                Console.Clear();
                Console.WriteLine("Erros: ");
                Console.WriteLine();
                foreach (var message in errorMessages)
                {
                    Console.WriteLine(message);

                }
                Console.WriteLine("Tente Preencher os dados novamente");
                Console.WriteLine();
                Console.WriteLine("----------------------");
                errorMessages.Clear();
                Thread.Sleep(5000);
                
            }
            else
            {
                flag = true;
            }
        }

        Console.Clear();
        return pessoa;

    }

}