using System;

public class Vetor
{
    public static int[] Preencher(int tamanho)
    {
        int[] vetor = new int[tamanho];
        for (int i = 0; i < tamanho; i++)
        {
            try
            {
                Console.Write($"Digite o valor para a posição {i}: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Erro: Você deve digitar um número inteiro.");
                i--; // Volta uma iteração para tentar novamente preencher a posição atual
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Erro: Posição do vetor inválida.");
                i--; // Volta uma iteração para tentar novamente preencher a posição atual
            }
        }
        return vetor;
    }
}
