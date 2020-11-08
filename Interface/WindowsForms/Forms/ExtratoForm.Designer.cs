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
            this.dgvLogs = new System.Windows.Forms.DataGridView();
            this.btnMain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSaldoEmConta
            // 
            this.lblSaldoEmConta.AutoSize = true;
            this.lblSaldoEmConta.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSaldoEmConta.Location = new System.Drawing.Point(72, 69);
            this.lblSaldoEmConta.Name = "lblSaldoEmConta";
            this.lblSaldoEmConta.Size = new System.Drawing.Size(140, 21);
            this.lblSaldoEmConta.TabIndex = 0;
            this.lblSaldoEmConta.Text = "Saldo em Conta";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblValor.Location = new System.Drawing.Point(99, 108);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(80, 25);
            this.lblValor.TabIndex = 1;
            this.lblValor.Text = "<valor>";
            // 
            // dgvLogs
            // 
            this.dgvLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLogs.Location = new System.Drawing.Point(12, 162);
            this.dgvLogs.Name = "dgvLogs";
            this.dgvLogs.Size = new System.Drawing.Size(255, 223);
            this.dgvLogs.TabIndex = 2;
            this.dgvLogs.Text = "dataGridView1";
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
            // ExtratoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkViolet;
            this.ClientSize = new System.Drawing.Size(279, 450);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.dgvLogs);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblSaldoEmConta);
            this.Name = "ExtratoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExtratoForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSaldoEmConta;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.DataGridView dgvLogs;
        private System.Windows.Forms.Button btnMain;
    }
}