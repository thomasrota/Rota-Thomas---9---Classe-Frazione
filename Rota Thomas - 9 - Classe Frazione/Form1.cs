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
        public Form1()
        {
            InitializeComponent();
            f = new Frazione();
        }

        private void buttonSomma_Click(object sender, EventArgs e)
        {
            f.numeratore = int.Parse(textBoxNum.Text);
            f.denominatore = int.Parse(textBoxDen.Text);
            f.Somma(int.Parse(textBoxNum2.Text), int.Parse(textBoxDen2.Text));
            MessageBox.Show($"{f.numeratore}/{f.denominatore}");
        }
    }
}
