using System;

class Program
{
  static void Main()
  {
    Console.Write("Digite uma palavra ou frase: ");
    string entrada = Console.ReadLine();

    string invertida = InverterString(entrada);

    Console.WriteLine("String invertida: " + invertida);
  }

  static string InverterString(string texto)
  {
    char[] caracteres = new char[texto.Length];
    int j = 0;

    for (int i = texto.Length - 1; i >= 0; i--)
    {
      caracteres[j] = texto[i];
      j++;
    }

    return new string(caracteres);
  }
}
