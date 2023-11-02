using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rota_Thomas___9___Classe_Frazione
{
    public partial class Form1 : Form
    {
        public Frazione f;
        public Frazione f1;
        public FrazioneEstesa fe;
        public Form1()
        {
            InitializeComponent();
            f = new Frazione();
            f1 = new Frazione(f);
            fe = new FrazioneEstesa();
        }

        private void buttonSomma_Click(object sender, EventArgs e)
        {
            f.numeratore = int.Parse(textBoxNum.Text);
            f.denominatore = int.Parse(textBoxDen.Text);
            f.Somma(int.Parse(textBoxNum2.Text), (int.Parse(textBoxDen2.Text) == 0) ? throw new ArgumentNullException(paramName: nameof(textBoxDen2), message: "Denominator cannot be null") : int.Parse(textBoxDen2.Text));
            MessageBox.Show($"{f.numeratore}/{f.denominatore}");
        }

        private void buttonSottr_Click(object sender, EventArgs e)
        {
            f.numeratore = int.Parse(textBoxNum.Text);
            f.denominatore = int.Parse(textBoxDen.Text);
            f.Sottrai(int.Parse(textBoxNum2.Text), (int.Parse(textBoxDen2.Text) == 0) ? throw new ArgumentNullException(paramName: nameof(textBoxDen2), message: "Denominator cannot be null") : int.Parse(textBoxDen2.Text));
            MessageBox.Show($"{f.numeratore}/{f.denominatore}");
        }

        private void buttonMul_Click(object sender, EventArgs e)
        {
            f.numeratore = int.Parse(textBoxNum.Text);
            f.denominatore = int.Parse(textBoxDen.Text);
            f.Moltiplicazione(int.Parse(textBoxNum2.Text), (int.Parse(textBoxDen2.Text) == 0) ? throw new ArgumentNullException(paramName: nameof(textBoxDen2), message: "Denominator cannot be null") : int.Parse(textBoxDen2.Text));
            MessageBox.Show($"{f.numeratore}/{f.denominatore}");
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            f.numeratore = int.Parse(textBoxNum.Text);
            f.denominatore = int.Parse(textBoxDen.Text);
            f.Divisione(int.Parse(textBoxNum2.Text), (int.Parse(textBoxDen2.Text) == 0) ? throw new ArgumentNullException(paramName: nameof(textBoxDen2), message: "Denominator cannot be null") : int.Parse(textBoxDen2.Text));
            MessageBox.Show($"{f.numeratore}/{f.denominatore}");
        }

		private void buttonSemplifica_Click(object sender, EventArgs e)
		{
			f.numeratore = int.Parse(textBoxNum.Text);
			f.denominatore = int.Parse(textBoxDen.Text);
			f.Semplifica();
			MessageBox.Show($"{f.numeratore}/{f.denominatore}");
		}

        private void buttonFTD_Click(object sender, EventArgs e)
        {
            fe.numeratore = int.Parse(textBoxNum.Text);
            fe.denominatore = int.Parse(textBoxDen.Text);
            fe.FrazioneInDecimale();
            MessageBox.Show($"{fe.fTD}");
        }
    }
}
