namespace WindowsForms.Forms
{
    partial class SaqueForm
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
            this.lblValorEmConta = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtValorSaque = new System.Windows.Forms.TextBox();
            this.lblValorDeSaque = new System.Windows.Forms.Label();
            this.btnMain = new System.Windows.Forms.Button();
            this.btnSacar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblValorEmConta
            // 
            this.lblValorEmConta.AutoSize = true;
            this.lblValorEmConta.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblValorEmConta.Location = new System.Drawing.Point(74, 106);
            this.lblValorEmConta.Name = "lblValorEmConta";
            this.lblValorEmConta.Size = new System.Drawing.Size(138, 21);
            this.lblValorEmConta.TabIndex = 0;
            this.lblValorEmConta.Text = "Valor em Conta";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblValor.Location = new System.Drawing.Point(106, 127);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(61, 23);
            this.lblValor.TabIndex = 1;
            this.lblValor.Text = "<valor>";
            // 
            // txtValorSaque
            // 
            this.txtValorSaque.Location = new System.Drawing.Point(45, 269);
            this.txtValorSaque.Name = "txtValorSaque";
            this.txtValorSaque.Size = new System.Drawing.Size(191, 23);
            this.txtValorSaque.TabIndex = 2;
            this.txtValorSaque.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblValorDeSaque
            // 
            this.lblValorDeSaque.AutoSize = true;
            this.lblValorDeSaque.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblValorDeSaque.Location = new System.Drawing.Point(84, 231);
            this.lblValorDeSaque.Name = "lblValorDeSaque";
            this.lblValorDeSaque.Size = new System.Drawing.Size(117, 23);
            this.lblValorDeSaque.TabIndex = 3;
            this.lblValorDeSaque.Text = "Valor de saque";
            // 
            // btnMain
            // 
            this.btnMain.Location = new System.Drawing.Point(192, 417);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(75, 23);
            this.btnMain.TabIndex = 4;
            this.btnMain.Text = "Menu";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // btnSacar
            // 
            this.btnSacar.Location = new System.Drawing.Point(106, 307);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(75, 23);
            this.btnSacar.TabIndex = 5;
            this.btnSacar.Text = "Sacar";
            this.btnSacar.UseVisualStyleBackColor = true;
            this.btnSacar.Click += new System.EventHandler(this.btnSacar_Click);
            // 
            // SaqueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkViolet;
            this.ClientSize = new System.Drawing.Size(277, 450);
            this.Controls.Add(this.btnSacar);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.lblValorDeSaque);
            this.Controls.Add(this.txtValorSaque);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblValorEmConta);
            this.Name = "SaqueForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SaqueForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValorEmConta;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtValorSaque;
        private System.Windows.Forms.Label lblValorDeSaque;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Button btnSacar;
    }
}