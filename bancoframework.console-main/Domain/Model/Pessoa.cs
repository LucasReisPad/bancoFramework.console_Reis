using System.ComponentModel.Design;

namespace Domain.Model
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }

        public double Saldo { get; set; }

        public void Ação()
        {
            int x = 0;
            while(x != 3)
            {
                Console.WriteLine($"Como posso ajudar {Nome}?");
                Console.WriteLine("1- Depósito");
                Console.WriteLine("2- Saque");
                Console.WriteLine("3- Sair ");
                Console.WriteLine("--------");
                Console.Write("Selecione uma opção: ");
                x = int.Parse( Console.ReadLine() );
                switch(x)
                {
                    case  1:
                            Console.WriteLine("Depósito");
                        Thread.Sleep(2000);
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine("Saque");
                        Thread.Sleep(2000);
                        Console.Clear();
                        break;
                    case 3:
                        Console.WriteLine("Obrigado pela preferencia, volte sempre!!");
                        Thread.Sleep(2000);
                        Console.Clear();
                        break;
                    default: Console.WriteLine("Caracter invalido, tente novamente!");
                        Thread.Sleep(2000);
                        Console.Clear();
                        break;
                        
                }
            }
        }
    }
}
