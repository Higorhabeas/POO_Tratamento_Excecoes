using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Atividade 1: Verificar se um número é primo
        Console.WriteLine("Atividade 1 - Verificar se um número é primo");
        int numeroPrimo = 0;
        bool valido = false;
        while (!valido)
        {
            try
            {
                Console.Write("Digite um número inteiro: ");
                numeroPrimo = int.Parse(Console.ReadLine());
                valido = true;
            }
            catch (FormatException)
            {
                Console.WriteLine("Erro: Você deve digitar um número inteiro.");
            }
        }
        if (NumeroPrimo.EhPrimo(numeroPrimo))
        {
            Console.WriteLine(numeroPrimo + " é um número primo.");
        }
        else
        {
            Console.WriteLine(numeroPrimo + " não é um número primo.");
        }

        // Atividade 2: Simular uma calculadora básica
        Console.WriteLine("\nAtividade 2 - Simular uma calculadora básica");
        double num1, num2, resultado = 0;
        char operacao;
        valido = false;
        while (!valido)
        {
            try
            {
                Console.Write("Digite o primeiro número: ");
                num1 = double.Parse(Console.ReadLine());
                Console.Write("Digite o segundo número: ");
                num2 = double.Parse(Console.ReadLine());
                Console.Write("Digite a operação (+, -, *, /, %): ");
                operacao = char.Parse(Console.ReadLine());
                resultado = Calculadora.Calcular(num1, num2, operacao);
                Console.WriteLine("Resultado: " + resultado);
                valido = true;
            }
            catch (FormatException)
            {
                Console.WriteLine("Erro: Você deve digitar um número.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Erro: Divisão por zero.");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }
        }

        // Atividade 3: Preencher valores de um vetor
        Console.WriteLine("\nAtividade 3 - Preencher valores de um vetor");
        Console.Write("Digite o tamanho do vetor: ");
        int tamanho = int.Parse(Console.ReadLine());
        int[] vetor = Vetor.Preencher(tamanho);

        // Atividade 4: Somar números até a soma ultrapassar 100
        Console.WriteLine("\nAtividade 4 - Somar números até a soma ultrapassar 100");
        int soma = 0;
        int quantidadeNumeros = 0;
        double media = 0;
        while (soma <= 100)
        {
            try
            {
                Console.Write("Digite um número: ");
                int numero = int.Parse(Console.ReadLine());
                soma += numero;
                quantidadeNumeros++;
                if (soma > 100)
                {
                    throw new ExcecaoAcimaDeCem();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Erro: Você deve digitar um número inteiro.");
            }
            catch (ExcecaoAcimaDeCem e)
            {
                Console.WriteLine(e.Message);
            }
        }
        media = (double)soma / quantidadeNumeros;
        Console.WriteLine("Soma: " + soma);
        Console.WriteLine("Quantidade de números somados: " + quantidadeNumeros);
        Console.WriteLine("Média: " + media);
    }
}
