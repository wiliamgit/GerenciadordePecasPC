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
            Pecas.Codigo = Convert.ToInt32(txtBoxPesquisa);
            ManipulaPecas alterarPe = new ManipulaPecas();
            alterarPe.AleterarPecas();

            txtBoxPeca.Text = Convert.ToString(txtBoxPeca);
            txtBoxMarca.Text = Pecas.Peca;
            txtBoxCapacidade.Text = Pecas.Capacidade;

        }
    }
}
