using System;

public class ExcecaoAcimaDeCem : Exception
{
    public ExcecaoAcimaDeCem() : base("A soma ultrapassou 100.")
    {
    }
}
