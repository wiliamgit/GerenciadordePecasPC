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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaCadastrarPecas tcp = new TelaCadastrarPecas();
            tcp.Show();
                 
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaPesquisarPecas tpp = new TelaPesquisarPecas();
            tpp.Show();
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaAlterarPecas tap = new TelaAlterarPecas();
            tap.Show();
        }

        private void deletarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaDeletarPecas tdp = new TelaDeletarPecas();
            tdp.Show();
        }
    }
}
