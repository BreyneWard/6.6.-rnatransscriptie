using static System.Console;
using System.Text.RegularExpressions;

namespace _6._6._rnatransscriptie;
class Program
{
    enum Nucleotide{G, C, T, A};
static void Main(string[] args)
    {
        string input = "";
        string rna = "";
        string convertedInput = "";
        Regex rx;

        do
        {
            rx = new Regex(@"^[gctaGCTA]$");
            input = Input.AskString("Geef een DNA-nucleotide op: (g, c, t, a)");
            if (rx.IsMatch(input))
            {
                Console.WriteLine($"Je gaf volgende DNA-nucleotide op: {input}");
                convertedInput = ConvertDnaToRna(input);
                Console.WriteLine($"RNA string: {rna += convertedInput}");
            }
            else
            {
                Console.WriteLine("Geen geldige DNA-nucleotide.");
            }

        } while (1 == 1); // Infinite loop
        






    }

    // Methods
    static string ConvertDnaToRna(string input)
    {
        input = input.ToLower();
        if(input=="g")
        {
            return "c";
        }
        else if (input == "c")
        {
            return "g";
        }
        else if (input == "t")
        {
            return "a";
        }
        else
        {
            return "u";
        }

    }

    // Classes
    public static class Input
    {
    public static string AskString(string question)
    {
        Console.Write($"{ question}: ");
        return Console.ReadLine() ?? string.Empty;
    }
    }
}


