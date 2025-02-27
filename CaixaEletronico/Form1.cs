using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
double Saldo = 0;
double Limite = 0;


namespace CaixaEletronico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       


        private void btDpt_Click(object sender, EventArgs e)
        {
            Saldo += numOperValor.Value;
            vlrSaldo.Text = Saldo.ToString("c");
        }
    }
}
