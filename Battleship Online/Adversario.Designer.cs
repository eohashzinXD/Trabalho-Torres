namespace Battleship_Online
{
    partial class Adversario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelOponente = new System.Windows.Forms.Panel();
            this.panelJogador = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panelOponente
            // 
            this.panelOponente.Location = new System.Drawing.Point(12, 52);
            this.panelOponente.Name = "panelOponente";
            this.panelOponente.Size = new System.Drawing.Size(452, 386);
            this.panelOponente.TabIndex = 0;
            // 
            // panelJogador
            // 
            this.panelJogador.Location = new System.Drawing.Point(568, 52);
            this.panelJogador.Name = "panelJogador";
            this.panelJogador.Size = new System.Drawing.Size(452, 386);
            this.panelJogador.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Jogador 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(717, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Jogador 2";
            // 
            // Adversario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 381);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelJogador);
            this.Controls.Add(this.panelOponente);
            this.Name = "Adversario";
            this.Text = "Jogador 2";
            this.Load += new System.EventHandler(this.Adversario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel panelOponente;
        public System.Windows.Forms.Panel panelJogador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}