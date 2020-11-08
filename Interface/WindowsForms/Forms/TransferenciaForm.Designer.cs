namespace WindowsForms.Forms
{
    partial class TransferenciaForm
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
            this.lblTransferencia = new System.Windows.Forms.Label();
            this.txtValorTransferencia = new System.Windows.Forms.TextBox();
            this.lblCpfDestinatario = new System.Windows.Forms.Label();
            this.lblNumConta = new System.Windows.Forms.Label();
            this.txtCpfDestinatario = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblDestinatario = new System.Windows.Forms.Label();
            this.btnMain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTransferencia
            // 
            this.lblTransferencia.AutoSize = true;
            this.lblTransferencia.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTransferencia.Location = new System.Drawing.Point(92, 99);
            this.lblTransferencia.Name = "lblTransferencia";
            this.lblTransferencia.Size = new System.Drawing.Size(94, 21);
            this.lblTransferencia.TabIndex = 0;
            this.lblTransferencia.Text = "Transferir";
            // 
            // txtValorTransferencia
            // 
            this.txtValorTransferencia.Location = new System.Drawing.Point(40, 132);
            this.txtValorTransferencia.Name = "txtValorTransferencia";
            this.txtValorTransferencia.Size = new System.Drawing.Size(201, 23);
            this.txtValorTransferencia.TabIndex = 1;
            this.txtValorTransferencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCpfDestinatario
            // 
            this.lblCpfDestinatario.AutoSize = true;
            this.lblCpfDestinatario.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCpfDestinatario.Location = new System.Drawing.Point(12, 232);
            this.lblCpfDestinatario.Name = "lblCpfDestinatario";
            this.lblCpfDestinatario.Size = new System.Drawing.Size(41, 23);
            this.lblCpfDestinatario.TabIndex = 2;
            this.lblCpfDestinatario.Text = "CPF";
            // 
            // lblNumConta
            // 
            this.lblNumConta.AutoSize = true;
            this.lblNumConta.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumConta.Location = new System.Drawing.Point(12, 287);
            this.lblNumConta.Name = "lblNumConta";
            this.lblNumConta.Size = new System.Drawing.Size(92, 23);
            this.lblNumConta.TabIndex = 3;
            this.lblNumConta.Text = "Num. Conta";
            // 
            // txtCpfDestinatario
            // 
            this.txtCpfDestinatario.Location = new System.Drawing.Point(59, 232);
            this.txtCpfDestinatario.Name = "txtCpfDestinatario";
            this.txtCpfDestinatario.Size = new System.Drawing.Size(195, 23);
            this.txtCpfDestinatario.TabIndex = 4;
            this.txtCpfDestinatario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(110, 287);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(144, 23);
            this.textBox2.TabIndex = 5;
            // 
            // lblDestinatario
            // 
            this.lblDestinatario.AutoSize = true;
            this.lblDestinatario.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDestinatario.Location = new System.Drawing.Point(85, 198);
            this.lblDestinatario.Name = "lblDestinatario";
            this.lblDestinatario.Size = new System.Drawing.Size(111, 21);
            this.lblDestinatario.TabIndex = 6;
            this.lblDestinatario.Text = "Destinatario";
            // 
            // btnMain
            // 
            this.btnMain.Location = new System.Drawing.Point(187, 415);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(75, 23);
            this.btnMain.TabIndex = 7;
            this.btnMain.Text = "Menu";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // TransferenciaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkViolet;
            this.ClientSize = new System.Drawing.Size(274, 450);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.lblDestinatario);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtCpfDestinatario);
            this.Controls.Add(this.lblNumConta);
            this.Controls.Add(this.lblCpfDestinatario);
            this.Controls.Add(this.txtValorTransferencia);
            this.Controls.Add(this.lblTransferencia);
            this.Name = "TransferenciaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TransferenciaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTransferencia;
        private System.Windows.Forms.TextBox txtValorTransferencia;
        private System.Windows.Forms.Label lblCpfDestinatario;
        private System.Windows.Forms.Label lblNumConta;
        private System.Windows.Forms.TextBox txtCpfDestinatario;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblDestinatario;
        private System.Windows.Forms.Button btnMain;
    }
}