namespace Rota_Thomas___9___Classe_Frazione
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.textBoxNum = new System.Windows.Forms.TextBox();
			this.labelNum = new System.Windows.Forms.Label();
			this.labelDen = new System.Windows.Forms.Label();
			this.textBoxDen = new System.Windows.Forms.TextBox();
			this.buttonSomma = new System.Windows.Forms.Button();
			this.buttonSottr = new System.Windows.Forms.Button();
			this.buttonMul = new System.Windows.Forms.Button();
			this.buttonDiv = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxDen2 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxNum2 = new System.Windows.Forms.TextBox();
			this.buttonSemplifica = new System.Windows.Forms.Button();
			this.buttonFTD = new System.Windows.Forms.Button();
			this.buttonDTF = new System.Windows.Forms.Button();
			this.labelDecimal = new System.Windows.Forms.Label();
			this.textBoxDec = new System.Windows.Forms.TextBox();
			this.buttonPotenza = new System.Windows.Forms.Button();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.labelPotenza = new System.Windows.Forms.Label();
			this.textBoxPot = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// textBoxNum
			// 
			this.textBoxNum.Location = new System.Drawing.Point(16, 31);
			this.textBoxNum.Margin = new System.Windows.Forms.Padding(4);
			this.textBoxNum.Name = "textBoxNum";
			this.textBoxNum.Size = new System.Drawing.Size(132, 22);
			this.textBoxNum.TabIndex = 0;
			// 
			// labelNum
			// 
			this.labelNum.AutoSize = true;
			this.labelNum.Location = new System.Drawing.Point(16, 11);
			this.labelNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelNum.Name = "labelNum";
			this.labelNum.Size = new System.Drawing.Size(78, 16);
			this.labelNum.TabIndex = 1;
			this.labelNum.Text = "Numeratore";
			// 
			// labelDen
			// 
			this.labelDen.AutoSize = true;
			this.labelDen.Location = new System.Drawing.Point(168, 11);
			this.labelDen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelDen.Name = "labelDen";
			this.labelDen.Size = new System.Drawing.Size(92, 16);
			this.labelDen.TabIndex = 3;
			this.labelDen.Text = "Denominatore";
			// 
			// textBoxDen
			// 
			this.textBoxDen.Location = new System.Drawing.Point(168, 31);
			this.textBoxDen.Margin = new System.Windows.Forms.Padding(4);
			this.textBoxDen.Name = "textBoxDen";
			this.textBoxDen.Size = new System.Drawing.Size(132, 22);
			this.textBoxDen.TabIndex = 2;
			// 
			// buttonSomma
			// 
			this.buttonSomma.Location = new System.Drawing.Point(376, 31);
			this.buttonSomma.Margin = new System.Windows.Forms.Padding(4);
			this.buttonSomma.Name = "buttonSomma";
			this.buttonSomma.Size = new System.Drawing.Size(127, 64);
			this.buttonSomma.TabIndex = 4;
			this.buttonSomma.Text = "Somma";
			this.buttonSomma.UseVisualStyleBackColor = true;
			this.buttonSomma.Click += new System.EventHandler(this.buttonSomma_Click);
			// 
			// buttonSottr
			// 
			this.buttonSottr.Location = new System.Drawing.Point(521, 31);
			this.buttonSottr.Margin = new System.Windows.Forms.Padding(4);
			this.buttonSottr.Name = "buttonSottr";
			this.buttonSottr.Size = new System.Drawing.Size(127, 64);
			this.buttonSottr.TabIndex = 5;
			this.buttonSottr.Text = "Sottrai";
			this.buttonSottr.UseVisualStyleBackColor = true;
			this.buttonSottr.Click += new System.EventHandler(this.buttonSottr_Click);
			// 
			// buttonMul
			// 
			this.buttonMul.Location = new System.Drawing.Point(376, 102);
			this.buttonMul.Margin = new System.Windows.Forms.Padding(4);
			this.buttonMul.Name = "buttonMul";
			this.buttonMul.Size = new System.Drawing.Size(127, 64);
			this.buttonMul.TabIndex = 6;
			this.buttonMul.Text = "Moltiplica";
			this.buttonMul.UseVisualStyleBackColor = true;
			this.buttonMul.Click += new System.EventHandler(this.buttonMul_Click);
			// 
			// buttonDiv
			// 
			this.buttonDiv.Location = new System.Drawing.Point(521, 102);
			this.buttonDiv.Margin = new System.Windows.Forms.Padding(4);
			this.buttonDiv.Name = "buttonDiv";
			this.buttonDiv.Size = new System.Drawing.Size(127, 64);
			this.buttonDiv.TabIndex = 7;
			this.buttonDiv.Text = "Dividi";
			this.buttonDiv.UseVisualStyleBackColor = true;
			this.buttonDiv.Click += new System.EventHandler(this.buttonDiv_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(172, 122);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(92, 16);
			this.label1.TabIndex = 11;
			this.label1.Text = "Denominatore";
			// 
			// textBoxDen2
			// 
			this.textBoxDen2.Location = new System.Drawing.Point(172, 142);
			this.textBoxDen2.Margin = new System.Windows.Forms.Padding(4);
			this.textBoxDen2.Name = "textBoxDen2";
			this.textBoxDen2.Size = new System.Drawing.Size(132, 22);
			this.textBoxDen2.TabIndex = 10;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(20, 122);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(78, 16);
			this.label2.TabIndex = 9;
			this.label2.Text = "Numeratore";
			// 
			// textBoxNum2
			// 
			this.textBoxNum2.Location = new System.Drawing.Point(20, 142);
			this.textBoxNum2.Margin = new System.Windows.Forms.Padding(4);
			this.textBoxNum2.Name = "textBoxNum2";
			this.textBoxNum2.Size = new System.Drawing.Size(132, 22);
			this.textBoxNum2.TabIndex = 8;
			// 
			// buttonSemplifica
			// 
			this.buttonSemplifica.Location = new System.Drawing.Point(814, 102);
			this.buttonSemplifica.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.buttonSemplifica.Name = "buttonSemplifica";
			this.buttonSemplifica.Size = new System.Drawing.Size(127, 62);
			this.buttonSemplifica.TabIndex = 12;
			this.buttonSemplifica.Text = "Semplifica";
			this.buttonSemplifica.UseVisualStyleBackColor = true;
			this.buttonSemplifica.Click += new System.EventHandler(this.buttonSemplifica_Click);
			// 
			// buttonFTD
			// 
			this.buttonFTD.Location = new System.Drawing.Point(679, 31);
			this.buttonFTD.Margin = new System.Windows.Forms.Padding(4);
			this.buttonFTD.Name = "buttonFTD";
			this.buttonFTD.Size = new System.Drawing.Size(127, 64);
			this.buttonFTD.TabIndex = 13;
			this.buttonFTD.Text = "Converti in decimale";
			this.buttonFTD.UseVisualStyleBackColor = true;
			this.buttonFTD.Click += new System.EventHandler(this.buttonFTD_Click);
			// 
			// buttonDTF
			// 
			this.buttonDTF.Location = new System.Drawing.Point(679, 102);
			this.buttonDTF.Margin = new System.Windows.Forms.Padding(4);
			this.buttonDTF.Name = "buttonDTF";
			this.buttonDTF.Size = new System.Drawing.Size(127, 64);
			this.buttonDTF.TabIndex = 14;
			this.buttonDTF.Text = "Converti in frazione";
			this.buttonDTF.UseVisualStyleBackColor = true;
			this.buttonDTF.Click += new System.EventHandler(this.buttonDTF_Click_1);
			// 
			// labelDecimal
			// 
			this.labelDecimal.AutoSize = true;
			this.labelDecimal.Location = new System.Drawing.Point(16, 196);
			this.labelDecimal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelDecimal.Name = "labelDecimal";
			this.labelDecimal.Size = new System.Drawing.Size(65, 16);
			this.labelDecimal.TabIndex = 16;
			this.labelDecimal.Text = "Decimale";
			// 
			// textBoxDec
			// 
			this.textBoxDec.Location = new System.Drawing.Point(16, 215);
			this.textBoxDec.Margin = new System.Windows.Forms.Padding(4);
			this.textBoxDec.Name = "textBoxDec";
			this.textBoxDec.Size = new System.Drawing.Size(132, 22);
			this.textBoxDec.TabIndex = 15;
			// 
			// buttonPotenza
			// 
			this.buttonPotenza.Location = new System.Drawing.Point(814, 31);
			this.buttonPotenza.Margin = new System.Windows.Forms.Padding(4);
			this.buttonPotenza.Name = "buttonPotenza";
			this.buttonPotenza.Size = new System.Drawing.Size(127, 64);
			this.buttonPotenza.TabIndex = 17;
			this.buttonPotenza.Text = "Potenza";
			this.buttonPotenza.UseVisualStyleBackColor = true;
			this.buttonPotenza.Click += new System.EventHandler(this.buttonPotenza_Click);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// labelPotenza
			// 
			this.labelPotenza.AutoSize = true;
			this.labelPotenza.Location = new System.Drawing.Point(168, 196);
			this.labelPotenza.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelPotenza.Name = "labelPotenza";
			this.labelPotenza.Size = new System.Drawing.Size(56, 16);
			this.labelPotenza.TabIndex = 20;
			this.labelPotenza.Text = "Potenza";
			// 
			// textBoxPot
			// 
			this.textBoxPot.Location = new System.Drawing.Point(168, 215);
			this.textBoxPot.Margin = new System.Windows.Forms.Padding(4);
			this.textBoxPot.Name = "textBoxPot";
			this.textBoxPot.Size = new System.Drawing.Size(132, 22);
			this.textBoxPot.TabIndex = 19;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1067, 554);
			this.Controls.Add(this.labelPotenza);
			this.Controls.Add(this.textBoxPot);
			this.Controls.Add(this.buttonPotenza);
			this.Controls.Add(this.labelDecimal);
			this.Controls.Add(this.textBoxDec);
			this.Controls.Add(this.buttonDTF);
			this.Controls.Add(this.buttonFTD);
			this.Controls.Add(this.buttonSemplifica);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxDen2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxNum2);
			this.Controls.Add(this.buttonDiv);
			this.Controls.Add(this.buttonMul);
			this.Controls.Add(this.buttonSottr);
			this.Controls.Add(this.buttonSomma);
			this.Controls.Add(this.labelDen);
			this.Controls.Add(this.textBoxDen);
			this.Controls.Add(this.labelNum);
			this.Controls.Add(this.textBoxNum);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNum;
        private System.Windows.Forms.Label labelNum;
        private System.Windows.Forms.Label labelDen;
        private System.Windows.Forms.TextBox textBoxDen;
        private System.Windows.Forms.Button buttonSomma;
        private System.Windows.Forms.Button buttonSottr;
        private System.Windows.Forms.Button buttonMul;
        private System.Windows.Forms.Button buttonDiv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDen2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNum2;
		private System.Windows.Forms.Button buttonSemplifica;
        private System.Windows.Forms.Button buttonFTD;
        private System.Windows.Forms.Button buttonDTF;
        private System.Windows.Forms.Label labelDecimal;
        private System.Windows.Forms.TextBox textBoxDec;
		private System.Windows.Forms.Button buttonPotenza;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.Label labelPotenza;
		private System.Windows.Forms.TextBox textBoxPot;
	}
}

