using System;

public class NumeroPrimo
{
    // Método para verificar se um número é primo
    public static bool EhPrimo(int numero)
    {
        if (numero <= 1) return false;
        for (int i = 2; i <= Math.Sqrt(numero); i++)
        {
            if (numero % i == 0) return false;
        }
        return true;
    }
}
