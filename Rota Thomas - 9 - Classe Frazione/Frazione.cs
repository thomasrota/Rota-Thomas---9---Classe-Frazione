using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace Rota_Thomas___9___Classe_Frazione
{
    public class Frazione : ICloneable
	{
        protected int _numeratore, _denominatore;

        public Frazione()
        {
            numeratore = 0;
            denominatore = 1;
        }

        // costruttore di copia
        public Frazione(Frazione f)
        {
            numeratore = f.numeratore;
            denominatore = f.denominatore;
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
            Semplifica();
        }
        public void Sottrai(int n, int d)
        {
            int den = denominatore * d;
            int num = numeratore * (d) - n * (denominatore);
            numeratore = num;
            denominatore = den;
            Semplifica();
        }
        public void Moltiplicazione(int n, int d)
        {
            numeratore *= n;
            denominatore *= d;
            Semplifica();
        }
        public void Divisione(int n, int d)
        {
            numeratore /= n;
            denominatore /= d;
            Semplifica();
        }
        public void Semplifica()
        {
            int mcd = MCD(numeratore, denominatore);
			numeratore /= mcd;
			denominatore /= mcd;
        }
	    private int MCD(int n1, int n2)
	    {
	        int temp;
	        while (n2 != 0)
	        {
		        temp = n1 % n2;
		        n1 = n2;
		        n2 = temp;
	        }
	        return n1;
        }
	    public object Clone()
	    {
		    return this.MemberwiseClone();
	    }
	}
    public class FrazioneEstesa : Frazione
    {
		private double numeroDecimale;

        public FrazioneEstesa()	: base()
        {

		}
        public double fTD { get { return numeroDecimale; } set { numeroDecimale = value; } }
		public void FrazioneInDecimale()
		{
			numeroDecimale = (double)numeratore / denominatore;
		}
        
		/*public void DecimaleInFrazione()
		{
			double numeroDecimale = 0.333333333;
			int num = (int)numeroDecimale;
			int den = 1;
			while (num != numeroDecimale)
			{
				numeroDecimale *= 10;
				num = (int)numeroDecimale;
				den *= 10;
			}
			numeratore = num;
			denominatore = den;
		}*/

		public void ElevaPotenza(int potenza)
		{
			numeratore = (int)Math.Pow(numeratore, potenza);
			denominatore = (int)Math.Pow(denominatore, potenza);
		}
	}
}