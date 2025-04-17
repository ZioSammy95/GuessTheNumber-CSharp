using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("🎮 Benvenuto al gioco 'Indovina il numero'!");
        Console.WriteLine("Scegli il livello di difficoltà:");
        Console.WriteLine("1. Facile (da 1 a 50)");
        Console.WriteLine("2. Medio (da 1 a 100)");
        Console.WriteLine("3. Difficile (da 1 a 500)");

        int maxNumber = 100;
        string scelta = Console.ReadLine();

        switch (scelta)
        {
            case "1":
                maxNumber = 50;
                break;
            case "2":
                maxNumber = 100;
                break;
            case "3":
                maxNumber = 500;
                break;
            default:
                Console.WriteLine("Scelta non valida. Livello Medio selezionato per default (1–100).");
                break;
        }

        Random random = new Random();
        int numeroSegreto = random.Next(1, maxNumber + 1);
        int tentativi = 0;
        int inputUtente = 0;

        Console.WriteLine($"Indovina il numero! (tra 1 e {maxNumber})");

        while (inputUtente != numeroSegreto)
        {
            Console.Write("Inserisci un numero: ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out inputUtente) || inputUtente < 1 || inputUtente > maxNumber)
            {
                Console.WriteLine($"Per favore inserisci un numero valido tra 1 e {maxNumber}.");
                continue;
            }

            tentativi++;

            if (inputUtente < numeroSegreto)
                Console.WriteLine("Troppo basso!");
            else if (inputUtente > numeroSegreto)
                Console.WriteLine("Troppo alto!");
            else
                Console.WriteLine($"🎉 Complimenti! Hai indovinato in {tentativi} tentativi.");
        }
    }
}