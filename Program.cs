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

    }
}

