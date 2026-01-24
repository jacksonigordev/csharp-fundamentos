using System.Threading.Channels;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("           *********");
                Console.WriteLine("   *************************");
                Console.WriteLine("***********************************");
                Console.WriteLine("Calculadora XingLing Comprado Na 25 de Março");
                Console.WriteLine("********************************");
                Console.WriteLine("   *************************");
                Console.WriteLine("           *********");
                Thread.Sleep(4000);
                Console.Clear();

                Console.WriteLine("Digite o primeiro número: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite o segundo número: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Escolha um operador (+ - / *): ");
                string operador = Console.ReadLine();

                if (operador == "+")
                    Console.WriteLine(num1 + num2);

                else if (operador == "-")
                    Console.WriteLine(num1 - num2);
                else if (operador == "/")
                    Console.WriteLine(num1 / num2);
                else if (operador == "*")
                    Console.WriteLine(num1 * num2);

                Console.WriteLine("Digite qualquer coisa para dar Clear e voltar a calculadora: ");
                Console.ReadKey();
                Console.Clear();

            }
        }
    }
}
