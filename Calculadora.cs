using System;

public class Calculadora
{
    public static double Calcular(double num1, double num2, char operacao)
    {
        double resultado = 0;
        switch (operacao)
        {
            case '+':
                resultado = num1 + num2;
                break;
            case '-':
                resultado = num1 - num2;
                break;
            case '*':
                resultado = num1 * num2;
                break;
            case '/':
                resultado = num1 / num2;
                break;
            case '%':
                resultado = num1 % num2;
                break;
            default:
                throw new InvalidOperationException("Operação inválida.");
        }
        return resultado;
    }
}
