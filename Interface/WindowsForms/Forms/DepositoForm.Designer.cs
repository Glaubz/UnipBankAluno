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
            this.SuspendLayout();
            // 
            // txtValorDeposito
            // 
            this.txtValorDeposito.Location = new System.Drawing.Point(35, 168);
            this.txtValorDeposito.Name = "txtValorDeposito";
            this.txtValorDeposito.Size = new System.Drawing.Size(207, 23);
            this.txtValorDeposito.TabIndex = 0;
            this.txtValorDeposito.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDeposito
            // 
            this.lblDeposito.AutoSize = true;
            this.lblDeposito.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDeposito.Location = new System.Drawing.Point(99, 129);
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
            // DepositoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkViolet;
            this.ClientSize = new System.Drawing.Size(279, 450);
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
    }
}