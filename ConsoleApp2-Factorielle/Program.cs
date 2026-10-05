namespace ConsoleApp2_Factorielle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nombre = 5;
            int resultat = 1; // car 0! = 1 on initialise pas a 0 mais a 1

            int i = 1; // car 0! = 1 on initialise pas a 0 mais a 1

            while (i <= nombre)  // tourne tant que i est <= au nombre 
            {
                resultat = resultat * i;
                i++;
            }
            Console.WriteLine($"la factorielle de {nombre} est {resultat}");
        }
    }
}
