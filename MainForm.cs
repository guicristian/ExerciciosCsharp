using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CotaçãoMoeda
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ConvertorTemp_Click(object sender, EventArgs e)
        {
            ConvertTemp convertTemp = new ConvertTemp();
            convertTemp.MdiParent = this;
           convertTemp.Show();
        }

        private void comissaoVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ComissaoVenda menuComissaoVenda = new ComissaoVenda();
            menuComissaoVenda.MdiParent = this;
            menuComissaoVenda.Show();

        }

        private void calculaDiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalculaDias menuCalculaDias = new CalculaDias();
            menuCalculaDias.MdiParent = this;
            menuCalculaDias.Show();
        }

        private void jogoForcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JogoForca jogoForca = new JogoForca();
            jogoForca.MdiParent = this;
            jogoForca.Show();   
        }
    }
}
