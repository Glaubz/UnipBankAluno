namespace WindowsForms.Forms
{
    partial class MainForm
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
            this.btnSaque = new System.Windows.Forms.Button();
            this.btnDeposito = new System.Windows.Forms.Button();
            this.btnTransferencia = new System.Windows.Forms.Button();
            this.btnExtrato = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSaque
            // 
            this.btnSaque.Location = new System.Drawing.Point(87, 42);
            this.btnSaque.Name = "btnSaque";
            this.btnSaque.Size = new System.Drawing.Size(195, 23);
            this.btnSaque.TabIndex = 1;
            this.btnSaque.Text = "Saque";
            this.btnSaque.UseVisualStyleBackColor = true;
            this.btnSaque.Click += new System.EventHandler(this.btnSaque_Click);
            // 
            // btnDeposito
            // 
            this.btnDeposito.Location = new System.Drawing.Point(87, 89);
            this.btnDeposito.Name = "btnDeposito";
            this.btnDeposito.Size = new System.Drawing.Size(195, 23);
            this.btnDeposito.TabIndex = 2;
            this.btnDeposito.Text = "Deposito";
            this.btnDeposito.UseVisualStyleBackColor = true;
            this.btnDeposito.Click += new System.EventHandler(this.btnDeposito_Click);
            // 
            // btnTransferencia
            // 
            this.btnTransferencia.Location = new System.Drawing.Point(87, 137);
            this.btnTransferencia.Name = "btnTransferencia";
            this.btnTransferencia.Size = new System.Drawing.Size(195, 23);
            this.btnTransferencia.TabIndex = 3;
            this.btnTransferencia.Text = "Transferencia";
            this.btnTransferencia.UseVisualStyleBackColor = true;
            this.btnTransferencia.Click += new System.EventHandler(this.btnTransferencia_Click);
            // 
            // btnExtrato
            // 
            this.btnExtrato.Location = new System.Drawing.Point(87, 183);
            this.btnExtrato.Name = "btnExtrato";
            this.btnExtrato.Size = new System.Drawing.Size(195, 23);
            this.btnExtrato.TabIndex = 4;
            this.btnExtrato.Text = "Extrato";
            this.btnExtrato.UseVisualStyleBackColor = true;
            this.btnExtrato.Click += new System.EventHandler(this.btnExtrato_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkViolet;
            this.ClientSize = new System.Drawing.Size(371, 250);
            this.Controls.Add(this.btnExtrato);
            this.Controls.Add(this.btnTransferencia);
            this.Controls.Add(this.btnDeposito);
            this.Controls.Add(this.btnSaque);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSaque;
        private System.Windows.Forms.Button btnDeposito;
        private System.Windows.Forms.Button btnTransferencia;
        private System.Windows.Forms.Button btnExtrato;
    }
}