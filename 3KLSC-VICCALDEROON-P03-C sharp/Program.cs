//3KLSC-VICCALDERON-P03-C sharp
using System;

internal class Program
{
    static void Main()
    {
        int[] numeros = { 10, 20, 30, 40, 50, 60 };
        int[] n = new int[] { 3, 4, 5 }; 
        char[] c = { 'L', 'u', 'i', 's' };
        string s = "MONA LISA"; 
        int datossumados = 0; 

        for (int i = 0; i < 3; i++)
        {
            datossumados += n[i];
        }
        for(int i=0; i<4; i++)
        {
            Console.WriteLine("elementos de la de 4 elementos " + i + ": " + c[i]);
        }

        Console.WriteLine("La suma de los 3 elementos es " + datossumados);
        Console.WriteLine("EL CUADRO DE DA VINCI ES " + s);

        Console.WriteLine("");
        Console.ReadKey();
    }
}


