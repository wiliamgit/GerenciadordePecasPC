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
    public partial class TelaPesquisarPecas : Form
    {
        public TelaPesquisarPecas()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Pecas.Codigo = Convert.ToInt32(txtBoxCodigo.Text);
            ManipulaPecas manipulaPecas= new ManipulaPecas();
            manipulaPecas.buscarpecaCod();

            txtBoxCodigo.Text = Convert.ToString(Pecas.Codigo);
            txtBoxPecas.Text = Pecas.Peca;
            txtMerca.Text = Pecas.Marca;
            txtBoxCapacidade.Text= Pecas.Capacidade;
        }
    }
}
