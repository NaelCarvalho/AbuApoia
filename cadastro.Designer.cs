namespace ABU_Apoia
{
    partial class cadastro
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
            this.textoTeste = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textoTeste
            // 
            this.textoTeste.AutoSize = true;
            this.textoTeste.Location = new System.Drawing.Point(71, 64);
            this.textoTeste.Name = "textoTeste";
            this.textoTeste.Size = new System.Drawing.Size(30, 13);
            this.textoTeste.TabIndex = 0;
            this.textoTeste.Text = "teste";
            // 
            // cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 168);
            this.Controls.Add(this.textoTeste);
            this.Name = "cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textoTeste;
    }
}