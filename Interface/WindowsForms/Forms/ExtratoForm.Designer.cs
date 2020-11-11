namespace WindowsForms.Forms
{
    partial class ExtratoForm
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
            this.lblSaldoEmConta = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.btnMain = new System.Windows.Forms.Button();
            this.lblLog1 = new System.Windows.Forms.Label();
            this.lblLog2 = new System.Windows.Forms.Label();
            this.lblLog3 = new System.Windows.Forms.Label();
            this.lblLog4 = new System.Windows.Forms.Label();
            this.lblLog5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSaldoEmConta
            // 
            this.lblSaldoEmConta.AutoSize = true;
            this.lblSaldoEmConta.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSaldoEmConta.Location = new System.Drawing.Point(71, 27);
            this.lblSaldoEmConta.Name = "lblSaldoEmConta";
            this.lblSaldoEmConta.Size = new System.Drawing.Size(140, 21);
            this.lblSaldoEmConta.TabIndex = 0;
            this.lblSaldoEmConta.Text = "Saldo em Conta";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblValor.Location = new System.Drawing.Point(99, 60);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(80, 25);
            this.lblValor.TabIndex = 1;
            this.lblValor.Text = "<valor>";
            // 
            // btnMain
            // 
            this.btnMain.Location = new System.Drawing.Point(192, 415);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(75, 23);
            this.btnMain.TabIndex = 3;
            this.btnMain.Text = "Menu";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // lblLog1
            // 
            this.lblLog1.AutoSize = true;
            this.lblLog1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLog1.Location = new System.Drawing.Point(12, 141);
            this.lblLog1.Name = "lblLog1";
            this.lblLog1.Size = new System.Drawing.Size(57, 23);
            this.lblLog1.TabIndex = 5;
            this.lblLog1.Text = "<logs>";
            // 
            // lblLog2
            // 
            this.lblLog2.AutoSize = true;
            this.lblLog2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLog2.Location = new System.Drawing.Point(12, 182);
            this.lblLog2.Name = "lblLog2";
            this.lblLog2.Size = new System.Drawing.Size(57, 23);
            this.lblLog2.TabIndex = 5;
            this.lblLog2.Text = "<logs>";
            // 
            // lblLog3
            // 
            this.lblLog3.AutoSize = true;
            this.lblLog3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLog3.Location = new System.Drawing.Point(12, 219);
            this.lblLog3.Name = "lblLog3";
            this.lblLog3.Size = new System.Drawing.Size(57, 23);
            this.lblLog3.TabIndex = 5;
            this.lblLog3.Text = "<logs>";
            // 
            // lblLog4
            // 
            this.lblLog4.AutoSize = true;
            this.lblLog4.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLog4.Location = new System.Drawing.Point(12, 256);
            this.lblLog4.Name = "lblLog4";
            this.lblLog4.Size = new System.Drawing.Size(57, 23);
            this.lblLog4.TabIndex = 5;
            this.lblLog4.Text = "<logs>";
            // 
            // lblLog5
            // 
            this.lblLog5.AutoSize = true;
            this.lblLog5.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLog5.Location = new System.Drawing.Point(12, 297);
            this.lblLog5.Name = "lblLog5";
            this.lblLog5.Size = new System.Drawing.Size(57, 23);
            this.lblLog5.TabIndex = 5;
            this.lblLog5.Text = "<logs>";
            // 
            // ExtratoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkViolet;
            this.ClientSize = new System.Drawing.Size(279, 450);
            this.Controls.Add(this.lblLog5);
            this.Controls.Add(this.lblLog4);
            this.Controls.Add(this.lblLog3);
            this.Controls.Add(this.lblLog2);
            this.Controls.Add(this.lblLog1);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblSaldoEmConta);
            this.Name = "ExtratoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExtratoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSaldoEmConta;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Label lblLog1;
        private System.Windows.Forms.Label lblLog2;
        private System.Windows.Forms.Label lblLog3;
        private System.Windows.Forms.Label lblLog4;
        private System.Windows.Forms.Label lblLog5;
    }
}