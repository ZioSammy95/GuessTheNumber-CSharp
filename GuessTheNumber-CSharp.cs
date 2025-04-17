using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int numeroSegreto = random.Next(1, 101);
        int tentativi = 0;
        int inputUtente = 0;

        Console.WriteLine("Indovina il numero! (tra 1 e 100)");

        while (inputUtente != numeroSegreto)
        {
            Console.Write("Inserisci un numero: ");
            string input = Console.ReadLine();
            int.TryParse(input, out inputUtente);
            tentativi++;

            if (inputUtente < numeroSegreto)
                Console.WriteLine("Troppo basso!");
            else if (inputUtente > numeroSegreto)
                Console.WriteLine("Troppo alto!");
            else
                Console.WriteLine($"Complimenti! Hai indovinato in {tentativi} tentativi.");
        }
    }
}