using System;
using System.Collections.Generic;
using System.Text;

namespace Konto_Bankowe
{
    internal class KontoBankowe
    {
        private decimal _saldo;
        private string _numer;

        public decimal Saldo
        {
            get { return _saldo; }
            set { _saldo = value; }
        }
    }
}