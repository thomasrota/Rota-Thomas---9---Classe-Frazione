using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Rota_Thomas___9___Classe_Frazione
{
    public class Frazione
    {
        private int _numeratore, _denominatore;

        public Frazione()
        {
            numeratore = 0;
            denominatore = 1;
        }

        public int numeratore { get { return _numeratore; } set { _numeratore = value; } }
        public int denominatore 
        { 
            get 
            { 
                return _denominatore; 
            } 
            set 
            {
                if (value == 0)
                    throw new ArgumentNullException(paramName: nameof(_denominatore), message: "Denominator cannot be null");
                else
                _denominatore = value; 
            } 
        }

        public void Somma(int n, int d)
        {
            int den = denominatore * d;
            int num = numeratore * (d) + n * (denominatore);
            numeratore = num;
            denominatore = den;
        }
    }
}