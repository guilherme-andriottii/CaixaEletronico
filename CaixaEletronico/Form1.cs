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

        double taxa = 0.001;
        private void tmrJuros_Tick(object sender, EventArgs e)
        {
            Saldo += Saldo * taxa;
            vlrSaldo.Text = Saldo.ToString("c");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblTaxa.Text = $"* Taxa: {taxa * 100}% a cada {tmrJuros.Interval / 1000}s";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Deseja mesmo sair da aplicação?", "Banco Jesus", MessageBoxButtons.YesNo);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
           
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Tchau, pobre!");
        }
    }
}
