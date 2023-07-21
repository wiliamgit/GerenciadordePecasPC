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
    public partial class TelaCadastrarPecas : Form
    {
        public TelaCadastrarPecas()
        {
            InitializeComponent();
        }

        private void btnCadastrarPecas_Click(object sender, EventArgs e)
        {
            Pecas.Peca = txtBoxPecas.Text;
            Pecas.Marca = txtboxMarca.Text;
            Pecas.Capacidade = txtboxMarca.Text;
            ManipulaPecas mPeca = new ManipulaPecas();
            mPeca.CadPecas();

        }
        public void abrirCadastro()
        {
            this.ShowDialog();
        }
  
    }
}
