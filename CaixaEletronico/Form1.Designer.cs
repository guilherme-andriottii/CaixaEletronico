namespace CaixaEletronico
{
    partial class Form1
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
            this.lblValor = new System.Windows.Forms.Label();
            this.btDpt = new System.Windows.Forms.Button();
            this.btScr = new System.Windows.Forms.Button();
            this.numOperValor = new System.Windows.Forms.NumericUpDown();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.numOperLimite = new System.Windows.Forms.NumericUpDown();
            this.lblLimite = new System.Windows.Forms.Label();
            this.vlrSaldo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numOperValor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOperLimite)).BeginInit();
            this.SuspendLayout();
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(169, 111);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(91, 38);
            this.lblValor.TabIndex = 0;
            this.lblValor.Text = "Valor:";
            // 
            // btDpt
            // 
            this.btDpt.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDpt.Location = new System.Drawing.Point(167, 168);
            this.btDpt.Name = "btDpt";
            this.btDpt.Size = new System.Drawing.Size(151, 52);
            this.btDpt.TabIndex = 1;
            this.btDpt.Text = "Depositar";
            this.btDpt.UseVisualStyleBackColor = true;
            this.btDpt.Click += new System.EventHandler(this.btDpt_Click);
            // 
            // btScr
            // 
            this.btScr.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btScr.Location = new System.Drawing.Point(333, 168);
            this.btScr.Name = "btScr";
            this.btScr.Size = new System.Drawing.Size(151, 52);
            this.btScr.TabIndex = 3;
            this.btScr.Text = "Sacar";
            this.btScr.UseVisualStyleBackColor = true;
            // 
            // numOperValor
            // 
            this.numOperValor.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOperValor.Location = new System.Drawing.Point(276, 109);
            this.numOperValor.Maximum = new decimal(new int[] {
            -1981284352,
            -1966660860,
            0,
            0});
            this.numOperValor.Name = "numOperValor";
            this.numOperValor.Size = new System.Drawing.Size(207, 45);
            this.numOperValor.TabIndex = 4;
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(169, 227);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(95, 38);
            this.lblSaldo.TabIndex = 5;
            this.lblSaldo.Text = "Saldo:";
            // 
            // numOperLimite
            // 
            this.numOperLimite.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOperLimite.Location = new System.Drawing.Point(276, 278);
            this.numOperLimite.Name = "numOperLimite";
            this.numOperLimite.Size = new System.Drawing.Size(197, 45);
            this.numOperLimite.TabIndex = 8;
            // 
            // lblLimite
            // 
            this.lblLimite.AutoSize = true;
            this.lblLimite.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLimite.Location = new System.Drawing.Point(169, 280);
            this.lblLimite.Name = "lblLimite";
            this.lblLimite.Size = new System.Drawing.Size(103, 38);
            this.lblLimite.TabIndex = 7;
            this.lblLimite.Text = "Limite:";
            // 
            // vlrSaldo
            // 
            this.vlrSaldo.AutoSize = true;
            this.vlrSaldo.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vlrSaldo.Location = new System.Drawing.Point(272, 227);
            this.vlrSaldo.Name = "vlrSaldo";
            this.vlrSaldo.Size = new System.Drawing.Size(117, 38);
            this.vlrSaldo.TabIndex = 9;
            this.vlrSaldo.Text = "R$ 0,00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.vlrSaldo);
            this.Controls.Add(this.numOperLimite);
            this.Controls.Add(this.lblLimite);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.numOperValor);
            this.Controls.Add(this.btScr);
            this.Controls.Add(this.btDpt);
            this.Controls.Add(this.lblValor);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numOperValor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOperLimite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Button btDpt;
        private System.Windows.Forms.Button btScr;
        private System.Windows.Forms.NumericUpDown numOperValor;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.NumericUpDown numOperLimite;
        private System.Windows.Forms.Label lblLimite;
        private System.Windows.Forms.Label vlrSaldo;
    }
}

