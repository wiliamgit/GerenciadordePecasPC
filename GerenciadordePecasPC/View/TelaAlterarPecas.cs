using GerenciadordePecasPC.Controller;
using GerenciadordePecasPC.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadordePecasPC.View
{
    public partial class TelaAlterarPecas : Form
    {
        public TelaAlterarPecas()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pecas.Codigo = Convert.ToInt32(txtBoxPesquisa.Text);
            txtBoxPesquisa.Text = Pecas.Codigo.ToString();
            txtBoxPeca.Text = Pecas.Peca;
            txtBoxMarca.Text = Pecas.Marca;
            txtBoxCapacidade.Text = Pecas.Capacidade;

            
            ManipulaPecas alterarPesquisa = new ManipulaPecas();
            alterarPesquisa.buscarpecaCod();

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Pecas.Codigo = Convert.ToInt32(txtBoxPesquisa.Text);
            Pecas.Peca = txtBoxPeca.Text;
            Pecas.Marca = txtBoxMarca.Text;
            Pecas.Capacidade = txtBoxCapacidade.Text;

            ManipulaPecas alterarPe = new ManipulaPecas();
            alterarPe.AleterarPecas();
        }
    }
}
