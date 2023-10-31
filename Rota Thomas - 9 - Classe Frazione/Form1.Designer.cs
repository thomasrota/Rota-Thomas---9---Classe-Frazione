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
            this.SuspendLayout();
            // 
            // textBoxNum
            // 
            this.textBoxNum.Location = new System.Drawing.Point(12, 25);
            this.textBoxNum.Name = "textBoxNum";
            this.textBoxNum.Size = new System.Drawing.Size(100, 20);
            this.textBoxNum.TabIndex = 0;
            // 
            // labelNum
            // 
            this.labelNum.AutoSize = true;
            this.labelNum.Location = new System.Drawing.Point(12, 9);
            this.labelNum.Name = "labelNum";
            this.labelNum.Size = new System.Drawing.Size(62, 13);
            this.labelNum.TabIndex = 1;
            this.labelNum.Text = "Numeratore";
            // 
            // labelDen
            // 
            this.labelDen.AutoSize = true;
            this.labelDen.Location = new System.Drawing.Point(126, 9);
            this.labelDen.Name = "labelDen";
            this.labelDen.Size = new System.Drawing.Size(73, 13);
            this.labelDen.TabIndex = 3;
            this.labelDen.Text = "Denominatore";
            // 
            // textBoxDen
            // 
            this.textBoxDen.Location = new System.Drawing.Point(126, 25);
            this.textBoxDen.Name = "textBoxDen";
            this.textBoxDen.Size = new System.Drawing.Size(100, 20);
            this.textBoxDen.TabIndex = 2;
            // 
            // buttonSomma
            // 
            this.buttonSomma.Location = new System.Drawing.Point(330, 25);
            this.buttonSomma.Name = "buttonSomma";
            this.buttonSomma.Size = new System.Drawing.Size(95, 52);
            this.buttonSomma.TabIndex = 4;
            this.buttonSomma.Text = "Somma";
            this.buttonSomma.UseVisualStyleBackColor = true;
            this.buttonSomma.Click += new System.EventHandler(this.buttonSomma_Click);
            // 
            // buttonSottr
            // 
            this.buttonSottr.Location = new System.Drawing.Point(439, 25);
            this.buttonSottr.Name = "buttonSottr";
            this.buttonSottr.Size = new System.Drawing.Size(95, 52);
            this.buttonSottr.TabIndex = 5;
            this.buttonSottr.Text = "Sottrai";
            this.buttonSottr.UseVisualStyleBackColor = true;
            // 
            // buttonMul
            // 
            this.buttonMul.Location = new System.Drawing.Point(330, 83);
            this.buttonMul.Name = "buttonMul";
            this.buttonMul.Size = new System.Drawing.Size(95, 52);
            this.buttonMul.TabIndex = 6;
            this.buttonMul.Text = "Moltiplica";
            this.buttonMul.UseVisualStyleBackColor = true;
            // 
            // buttonDiv
            // 
            this.buttonDiv.Location = new System.Drawing.Point(439, 83);
            this.buttonDiv.Name = "buttonDiv";
            this.buttonDiv.Size = new System.Drawing.Size(95, 52);
            this.buttonDiv.TabIndex = 7;
            this.buttonDiv.Text = "Dividi";
            this.buttonDiv.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Denominatore";
            // 
            // textBoxDen2
            // 
            this.textBoxDen2.Location = new System.Drawing.Point(129, 115);
            this.textBoxDen2.Name = "textBoxDen2";
            this.textBoxDen2.Size = new System.Drawing.Size(100, 20);
            this.textBoxDen2.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Numeratore";
            // 
            // textBoxNum2
            // 
            this.textBoxNum2.Location = new System.Drawing.Point(15, 115);
            this.textBoxNum2.Name = "textBoxNum2";
            this.textBoxNum2.Size = new System.Drawing.Size(100, 20);
            this.textBoxNum2.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

