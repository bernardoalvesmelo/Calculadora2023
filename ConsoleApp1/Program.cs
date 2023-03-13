namespace ConsoleApp1
{
    internal class Program
    {
        public static void Main()
        {


            while (true)
            {
                Console.Clear();
                Console.WriteLine("Calculadora");
                Console.WriteLine("Digite 1 para somar");
                Console.WriteLine("Digite 2 para subtrair");
                Console.WriteLine("Digite 3 para multiplicar");
                Console.WriteLine("Digite 4 para dividir");
                Console.WriteLine("Digite s para fechar a calculadora");



                string operacao = Console.ReadLine();

                if (operacao == "s" || operacao == "S")
                {
                    Console.WriteLine("Fim da operação");
                    break;
                }

                if (operacao != "1" && operacao != "2" && operacao != "3" && operacao != "4")
                {
                    Console.WriteLine("Operação inválida");
                    Console.ReadLine();
                    continue;
                }


                Console.Write("Digite o primerio número: ");
                decimal numero1 = Convert.ToDecimal(Console.ReadLine());


                Console.Write("Digite o segundo número: ");
                decimal numero2 = Convert.ToDecimal(Console.ReadLine());

                if (operacao == "4" && numero2 == 0)
                {
                    Console.WriteLine("Nâo pode dividir por zero");
                    Console.ReadLine();
                    continue;
                }

                decimal resultado = 0;
                switch (operacao)
                {
                    case "1":
                        resultado = numero1 + numero2;
                        break;
                    case "2":
                        resultado = numero1 - numero2;
                        break;
                    case "3":
                        resultado = numero1 * numero2;
                        break;
                    case "4":
                        resultado = numero2 / numero1;
                        break;
                }

                Console.WriteLine("O resultado da operação é: " + Math.Round(resultado, 2));
                Console.ReadLine();
            }

        }
    }
}