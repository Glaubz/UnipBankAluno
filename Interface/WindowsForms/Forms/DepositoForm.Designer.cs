namespace WindowsForms.Forms
{
    partial class DepositoForm
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
            this.txtValorDeposito = new System.Windows.Forms.TextBox();
            this.lblDeposito = new System.Windows.Forms.Label();
            this.btnMain = new System.Windows.Forms.Button();
            this.btnDepositar = new System.Windows.Forms.Button();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtValorDeposito
            // 
            this.txtValorDeposito.Location = new System.Drawing.Point(36, 270);
            this.txtValorDeposito.Name = "txtValorDeposito";
            this.txtValorDeposito.Size = new System.Drawing.Size(207, 23);
            this.txtValorDeposito.TabIndex = 0;
            this.txtValorDeposito.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDeposito
            // 
            this.lblDeposito.AutoSize = true;
            this.lblDeposito.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDeposito.Location = new System.Drawing.Point(100, 231);
            this.lblDeposito.Name = "lblDeposito";
            this.lblDeposito.Size = new System.Drawing.Size(81, 21);
            this.lblDeposito.TabIndex = 1;
            this.lblDeposito.Text = "Deposito";
            // 
            // btnMain
            // 
            this.btnMain.Location = new System.Drawing.Point(192, 415);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(75, 23);
            this.btnMain.TabIndex = 2;
            this.btnMain.Text = "Menu";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // btnDepositar
            // 
            this.btnDepositar.Location = new System.Drawing.Point(100, 323);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(81, 23);
            this.btnDepositar.TabIndex = 3;
            this.btnDepositar.Text = "Depositar";
            this.btnDepositar.UseVisualStyleBackColor = true;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSaldo.Location = new System.Drawing.Point(75, 99);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(140, 21);
            this.lblSaldo.TabIndex = 4;
            this.lblSaldo.Text = "Saldo em Conta";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblValor.Location = new System.Drawing.Point(110, 129);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(61, 23);
            this.lblValor.TabIndex = 5;
            this.lblValor.Text = "<valor>";
            // 
            // DepositoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkViolet;
            this.ClientSize = new System.Drawing.Size(279, 450);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.btnDepositar);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.lblDeposito);
            this.Controls.Add(this.txtValorDeposito);
            this.Name = "DepositoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DepositoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValorDeposito;
        private System.Windows.Forms.Label lblDeposito;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Button btnDepositar;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblValor;
    }
}