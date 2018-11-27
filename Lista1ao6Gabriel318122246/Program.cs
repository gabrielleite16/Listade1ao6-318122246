using System;

namespace Listade1ao6GabrielLeite318122246
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Questão 1 */

            int[] vetor = new int[4];

            int Quantidade = 0;
            int TrocaUm = 0;
            int TrocaDois = 0;
            int NumeroUm = 0;
            int NumeroDois = 0;
            int NumeroTres = 0;
            int NumeroQuatro = 0;

            Console.WriteLine("Digitar seu número de 4 digitos");
            Quantidade = Convert.ToInt32(Console.ReadLine());

            NumeroUm = Quantidade / 1000;
            NumeroDois = Quantidade / 100 % 10;
            NumeroTres = Quantidade / 10 % 10;
            NumeroQuatro = Quantidade % 10;

            NumeroUm = (NumeroUm + 7) / 10;
            NumeroDois = (NumeroDois + 7) / 10;
            NumeroTres = (NumeroTres + 7) / 10;
            NumeroQuatro = (NumeroQuatro + 7) / 10;

            vetor[1] = NumeroUm;
            vetor[2] = NumeroDois;
            vetor[3] = NumeroTres;
            vetor[4] = NumeroQuatro;

            TrocaUm = vetor[0];
            vetor[1] = vetor[3];
            vetor[3] = TrocaUm;

            TrocaDois = vetor[1];
            vetor[2] = vetor[4];
            vetor[4] = TrocaDois;

            for (int j = 0; j < vetor.Length; j++)

            {
                Console.Write(vetor[j] + " ");

            }

            Console.WriteLine("  --> Numero Criptografado");

            Console.ReadLine();
            Console.Clear();


            /* Questão 2 */

            int saldo = 0;

            Console.WriteLine("Informe saldo: \n");
            saldo = Convert.ToInt32(Console.ReadLine());

            Cliente cliente = new Cliente(saldo, 200, 500, 450, 5000);
            Console.WriteLine("Novo: \n");
            Console.WriteLine(cliente.NovoValor());

            cliente.AtualizaSaldo();

            if (cliente.Limiteexcedido())
                Console.WriteLine("Limite excedido !");
            else
                Console.WriteLine("Possui crédito disponivel.");

            Console.ReadKey();
            Console.Clear();

            /* Questão 3 */


            int num = 0;
            Console.WriteLine("\t\t\t\t (TRUE) PAR ----- (FALSE) IMPAR \n");

            while (num <= 10)
            {
                Console.WriteLine("Número : " + num + " " + PAR(num)); 
                num = num + 1;
            }

            Console.ReadKey();
            Console.Clear();


            /* Questão 4 */

            int digito1 = 0;
            int digito2 = 0;
            int digito3 = 0;

            Console.WriteLine("Digite o primeiro valor do triângulo :");
            digito1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o Segundo valor do triângulo :");
            digito2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o Terceiro valor do triângulo :");
            digito3 = Convert.ToInt32(Console.ReadLine());

            if (digito1 == digito2 && digito2 == digito3)
                Console.WriteLine("Equilátero -> 3 lados iguais : 1° Lado = " + digito1 + " --> 2° Lado = " + digito2 + " --> 3º Lado = " + digito3);

            else if (digito1 != digito2 && digito1 != digito3 && digito2 != digito3)
                Console.WriteLine("Escaleno -> 3 lados diferentes : 1° Lado = " + digito1 + " --> 2° Lado = " + digito2 + " --> 3º Lado = " + digito3);
            else
                Console.WriteLine("Isoceles -> 2 lados iguais : 1° Lado = " + digito1 + " --> 2° Lado = " + digito2 + " --> 3º Lado = " + digito3);

            Console.ReadKey();
            Console.Clear();


            /* Questão 5 */

            string letraA = "a";
            string letraE = "e";
            string letraI = "i";
            string letraO = "o";
            string letraU = "u";


            string InsiraLetra;


            Console.WriteLine("Digite uma letra do alfabeto");
            InsiraLetra = Convert.ToString(Console.ReadLine());

            if (InsiraLetra.Length > letraA.Length || InsiraLetra.Length > letraE.Length || InsiraLetra.Length > letraI.Length || InsiraLetra.Length > letraO.Length || InsiraLetra.Length > letraU.Length)

                Console.WriteLine("Digite apenas 1 caractere");


            else if (InsiraLetra == letraA || InsiraLetra == letraE || InsiraLetra == letraI || InsiraLetra == letraO || InsiraLetra == letraU)
                Console.WriteLine(" A letra é uma Vogal");

            else
                Console.WriteLine(" A letra é uma Consoante");
            Console.ReadKey();
            Console.Clear();


            /* Questão 6 */

            int numero;
            int i;
            int soma = 0;
            Console.WriteLine("Numero inteiro positivo ===> ");
            numero = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= numero; i++) 

            {
                int aux = 0;


                aux = numero % i; 

                if (aux == 0)
                {
                    soma = soma + 1;
                }
            }

            if (soma == 2)
                Console.WriteLine("Número primo");
            else
                Console.WriteLine("Número não primo");

            Console.ReadKey();
            Console.Clear();

        }
		
		/* Função número 3 */
        static bool PAR(int num) 
        {
            if (num % 2 == 0)
                return true;
            else
                return false;
        }

    }
}