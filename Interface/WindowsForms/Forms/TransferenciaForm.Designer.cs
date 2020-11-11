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
            this.lblNomeDestinatario = new System.Windows.Forms.Label();
            this.txtNomeDestinatario = new System.Windows.Forms.TextBox();
            this.lblDestinatario = new System.Windows.Forms.Label();
            this.btnMain = new System.Windows.Forms.Button();
            this.btnTransferir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTransferencia
            // 
            this.lblTransferencia.AutoSize = true;
            this.lblTransferencia.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTransferencia.Location = new System.Drawing.Point(93, 81);
            this.lblTransferencia.Name = "lblTransferencia";
            this.lblTransferencia.Size = new System.Drawing.Size(94, 21);
            this.lblTransferencia.TabIndex = 0;
            this.lblTransferencia.Text = "Transferir";
            // 
            // txtValorTransferencia
            // 
            this.txtValorTransferencia.Location = new System.Drawing.Point(41, 114);
            this.txtValorTransferencia.Name = "txtValorTransferencia";
            this.txtValorTransferencia.Size = new System.Drawing.Size(201, 23);
            this.txtValorTransferencia.TabIndex = 1;
            this.txtValorTransferencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNomeDestinatario
            // 
            this.lblNomeDestinatario.AutoSize = true;
            this.lblNomeDestinatario.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNomeDestinatario.Location = new System.Drawing.Point(13, 214);
            this.lblNomeDestinatario.Name = "lblNomeDestinatario";
            this.lblNomeDestinatario.Size = new System.Drawing.Size(52, 23);
            this.lblNomeDestinatario.TabIndex = 2;
            this.lblNomeDestinatario.Text = "Nome";
            // 
            // txtNomeDestinatario
            // 
            this.txtNomeDestinatario.Location = new System.Drawing.Point(71, 214);
            this.txtNomeDestinatario.Name = "txtNomeDestinatario";
            this.txtNomeDestinatario.Size = new System.Drawing.Size(184, 23);
            this.txtNomeDestinatario.TabIndex = 4;
            this.txtNomeDestinatario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDestinatario
            // 
            this.lblDestinatario.AutoSize = true;
            this.lblDestinatario.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDestinatario.Location = new System.Drawing.Point(86, 180);
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
            // btnTransferir
            // 
            this.btnTransferir.Location = new System.Drawing.Point(93, 292);
            this.btnTransferir.Name = "btnTransferir";
            this.btnTransferir.Size = new System.Drawing.Size(94, 23);
            this.btnTransferir.TabIndex = 8;
            this.btnTransferir.Text = "Transferir";
            this.btnTransferir.UseVisualStyleBackColor = true;
            this.btnTransferir.Click += new System.EventHandler(this.btnTransferir_Click);
            // 
            // TransferenciaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkViolet;
            this.ClientSize = new System.Drawing.Size(274, 450);
            this.Controls.Add(this.btnTransferir);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.lblDestinatario);
            this.Controls.Add(this.txtNomeDestinatario);
            this.Controls.Add(this.lblNomeDestinatario);
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
        private System.Windows.Forms.Label lblNomeDestinatario;
        private System.Windows.Forms.TextBox txtNomeDestinatario;
        private System.Windows.Forms.Label lblDestinatario;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Button btnTransferir;
    }
}