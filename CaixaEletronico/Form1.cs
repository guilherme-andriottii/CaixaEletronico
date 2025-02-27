using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace CaixaEletronico
{
    public partial class Form1 : Form
    {
        double Saldo = 0;
        double Limite = 0;

        public Form1()
        {
            InitializeComponent();
        }
      
        private void btDpt_Click(object sender, EventArgs e)
        {
            
            Saldo += (double)numOperValor.Value;
            vlrSaldo.Text = Saldo.ToString("c");
        }

        private void btScr_Click(object sender, EventArgs e)
        {
            if (Saldo < (double)numOperValor.Value)
                MessageBox.Show("Saldo Insuficiente! ");
            else
            {
                Saldo -= (double)numOperValor.Value;
                vlrSaldo.Text = Saldo.ToString("c");
            }
                

        }
    }
}
