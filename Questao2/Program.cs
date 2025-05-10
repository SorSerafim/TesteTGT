using System;

class Program
{
  static void Main(string[] args)
  {
    Console.Write("Informe um número para verificar se pertence à sequência de Fibonacci: ");
    if (int.TryParse(Console.ReadLine(), out int numeroInformado))
    {
      bool pertence = VerificaFibonacci(numeroInformado);

      if (pertence)
        Console.WriteLine($"{numeroInformado} pertence à sequência de Fibonacci.");
      else
        Console.WriteLine($"{numeroInformado} NÃO pertence à sequência de Fibonacci.");
    }
    else
    {
      Console.WriteLine("Número inválido.");
    }
  }

  static bool VerificaFibonacci(int numero)
  {
    int a = 0;
    int b = 1;

    while (a <= numero)
    {
      if (a == numero)
        return true;

      int temp = a;
      a = b;
      b = temp + b;
    }

    return false;
  }
}
