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
    public partial class TelaDeletarPecas : Form
    {
        public TelaDeletarPecas()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pecas.Codigo = Convert.ToInt32(txtBoxPesquisarCodigo.Text);
            ManipulaPecas manipulaPecas = new ManipulaPecas();
            manipulaPecas.buscarpecaCod();

            txtBoxCodigo.Text = Convert.ToString(Pecas.Codigo);
            txtBoxPecas.Text = Pecas.Peca;
            txtBoxMarca.Text = Pecas.Marca;
            txtBoxCapacidade.Text = Pecas.Capacidade;
        }
        public void abrirDeletar()
        {
            this.ShowDialog();
        }

        private void btndeletarPeça_Click(object sender, EventArgs e)
        {
            Pecas.Codigo = Convert.ToInt32(txtBoxCodigo.Text);
            ManipulaPecas mpecas = new ManipulaPecas();
            mpecas.deletarPeca();
        }
    }
}
