using System;
using System.Collections.Generic;
using System.Text;

namespace Konto_Bankowe
{
    internal class Automat
    {
        private int iloscMonet;

        // Stwórz metodę WrzucMonete
        public void WrzucMonete(KontoBankowe konto, decimal wartoscMonety)
        {
            // sprawdź wartość monety czy jest zgodna z wartością monety w systemie
            Console.Write("Wrzuć monetę: ");
            iloscMonet++;

            //dodaj kwotę do konta
            konto.Saldo += wartoscMonety;
        }
    }
}