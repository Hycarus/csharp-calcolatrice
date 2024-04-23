using System.Runtime.ConstrainedExecution;

namespace csharp_calcolatrice;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Somma di due interi: {Helper.Somma(5, 6)}");
        Console.WriteLine($"Somma di due double: {Helper.Somma(5.5, 6.2)}");
        Console.WriteLine($"Differenza di due interi: {Helper.Differenza(4, 6)}");
        Console.WriteLine($"Differenza di due double: {Helper.Differenza(2.5, 6.8)}");
        Console.WriteLine($"Moltiplicazione di due interi: {Helper.Moltiplicazione(8, 12)}");
        Console.WriteLine($"Moltiplicazione di due double: {Helper.Moltiplicazione(2.8, 15.4)}");
        Console.WriteLine($"Valore assoluto di un intero: {Helper.ValoreAssoluto(-5)}");
        Console.WriteLine($"Valore assoluto di un double: {Helper.ValoreAssoluto(-5.5)}");
        Console.WriteLine($"Minimo tra due interi: {Helper.Minimo(5, 9)}");
        Console.WriteLine($"Minimo tra due double: {Helper.Minimo(5.3, 9.2)}");
        Console.WriteLine($"Massimo tra due interi: {Helper.Massimo(5, 9)}");
        Console.WriteLine($"Massimo tra due double: {Helper.Massimo(5.8, 9.4)}");

        //Il fatto di dover scrivere lo stesso metodo per tipi di parametro diversi applica nella pratica uno dei principi di programmazione ad oggetti che abbiamo visto oggi…Quale ?
        // IL POLIMORFISMO

        //Bonus
        Console.WriteLine($"Elevazione a potenza: {Helper.Potenza(0, 1)}");

        string? switchCase;
        Console.WriteLine("Che operazione vuoi effettuare?");
        Console.WriteLine("1. Somma");
        Console.WriteLine("2. Differenza");
        Console.WriteLine("3. Moltiplicazione");
        Console.WriteLine("4. Valore assoluto");
        Console.WriteLine("5. Minimo");
        Console.WriteLine("6. Massimo");
        Console.WriteLine("7. Elevazione a potenza");
        Console.WriteLine("0. Termina il programma");
        switchCase = Console.ReadLine();

        while (switchCase != "0")
        {
            switch (switchCase)
            {
                case "1": // somma
                    Console.WriteLine("Inserisci i due numeri che vuoi sommare");
                    Console.WriteLine("Inserisci il primo numero: ");
                    double num1 = Helper.TruncateIfNeeded(Convert.ToDouble(Console.ReadLine()));
                    Console.WriteLine("Inserisci il secondo numero: ");
                    double num2 = Helper.TruncateIfNeeded(Convert.ToDouble(Console.ReadLine()));
                    Console.WriteLine($"La somma è {Helper.Somma(num1, num2)}");
                    break;

                case "2": // Differenza
                    Console.WriteLine("Inserisci i due numeri che vuoi sottrarre");
                    Console.WriteLine("Inserisci il primo numero: ");
                    double num3 = Helper.TruncateIfNeeded(Convert.ToDouble(Console.ReadLine()));
                    Console.WriteLine("Inserisci il secondo numero: ");
                    double num4 = Helper.TruncateIfNeeded(Convert.ToDouble(Console.ReadLine()));
                    Console.WriteLine($"La differenza è {Helper.Differenza(num3, num4)}");
                    break;

                case "3": // Moltiplicazione
                    Console.WriteLine("Inserisci i due numeri che vuoi moltiplicare");
                    Console.WriteLine("Inserisci il primo numero: ");
                    double num5 = Helper.TruncateIfNeeded(Convert.ToDouble(Console.ReadLine()));
                    Console.WriteLine("Inserisci il secondo numero: ");
                    double num6 = Helper.TruncateIfNeeded(Convert.ToDouble(Console.ReadLine()));
                    Console.WriteLine($"Il prodotto è {Helper.Moltiplicazione(num5, num6)}");
                    break;

                case "4": // Valore assoluto
                    Console.WriteLine("Inserisci il numero di cui vuoi sapere il valore assoluto");
                    double num = Helper.TruncateIfNeeded(Convert.ToDouble(Console.ReadLine()));
                    Console.WriteLine($"Il valore assoluto del numero inserito è {Helper.ValoreAssoluto(num)}");
                    break;

                case "5": // Minimo
                    Console.WriteLine("Inserisci i due numeri di cui vuoi sapere il minimo");
                    Console.WriteLine("Inserisci il primo numero: ");
                    double num7 = Helper.TruncateIfNeeded(Convert.ToDouble(Console.ReadLine()));
                    Console.WriteLine("Inserisci il secondo numero: ");
                    double num8 = Helper.TruncateIfNeeded(Convert.ToDouble(Console.ReadLine()));
                    Console.WriteLine($"Il minimo tra {num7} e {num8} è {Helper.Minimo(num7, num8)}");
                    break;

                case "6": // Massimo
                    Console.WriteLine("Inserisci i due numeri di cui vuoi sapere il Massimo");
                    Console.WriteLine("Inserisci il primo numero: ");
                    double num9 = Helper.TruncateIfNeeded(Convert.ToDouble(Console.ReadLine()));
                    Console.WriteLine("Inserisci il secondo numero: ");
                    double num10 = Helper.TruncateIfNeeded(Convert.ToDouble(Console.ReadLine()));
                    Console.WriteLine($"Il Massimo tra {num9} e {num10} è {Helper.Massimo(num9, num10)}");
                    break;

                case "7": // Elevazione a potenza
                    Console.WriteLine("Inserisci la base del numero che vuoi elevare a potenza: ");
                    double nBase = Helper.TruncateIfNeeded(Convert.ToDouble(Console.ReadLine()));
                    Console.WriteLine("Inserisci la base della potenza: ");
                    double nEsponente = Helper.TruncateIfNeeded(Convert.ToDouble(Console.ReadLine()));
                    Console.WriteLine($"Il risultato della potenza è {Helper.Potenza(nBase, nEsponente)}");
                    break;
            }
            Console.WriteLine("\nChe operazione vuoi effettuare?");
            Console.WriteLine("1. Somma");
            Console.WriteLine("2. Differenza");
            Console.WriteLine("3. Moltiplicazione");
            Console.WriteLine("4. Valore assoluto");
            Console.WriteLine("5. Minimo");
            Console.WriteLine("6. Massimo");
            Console.WriteLine("7. Elevazione a potenza");
            Console.WriteLine("0. Termina il programma");
            switchCase = Console.ReadLine();
        }
    }
}

