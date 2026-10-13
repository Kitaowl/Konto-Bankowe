namespace Konto_Bankowe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tworzenie konta
            KontoBankowe konto = new KontoBankowe();

            // Tworzenie automatu do wpłat
            Automat automat = new Automat();

            // Wrzucamy monety
            automat.WrzucMonete(konto, 0.5m);

            // Wyświetlamy stan konta
            Console.WriteLine(konto.StanKonta());
        }
    }
}