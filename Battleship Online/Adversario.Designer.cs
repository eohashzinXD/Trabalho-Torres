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
            this.panelJogador.Location = new System.Drawing.Point(617, 52);
            this.panelJogador.Name = "panelJogador";
            this.panelJogador.Size = new System.Drawing.Size(452, 386);
            this.panelJogador.TabIndex = 1;
            // 
            // Adversario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 381);
            this.Controls.Add(this.panelJogador);
            this.Controls.Add(this.panelOponente);
            this.Name = "Adversario";
            this.Text = "Jogador 2";
            this.Load += new System.EventHandler(this.Adversario_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panelOponente;
        public System.Windows.Forms.Panel panelJogador;
    }
}