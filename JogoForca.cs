using DevExpress.XtraEditors.Filtering.Templates.Choice;
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
    public partial class JogoForca : Form
    {
        public JogoForca()
        {
            InitializeComponent();
        }

        private int temaEscolhido;
        private string palavraEscolhida;
        private int qntTentativas;
        private char[] letrasCorretas;
        private string[] temaAdjetivos = new string[]
        {
            "Alegre",
            "Triste",
            "Rapido",
            "Devagar",
            "Inteligente",
            "Forte",
            "Fraco",
            "Corajoso",
            "Medroso",
            "Amigavel"
        };
        private string[] temaFilmes = new string[]
        {
            "O Poderoso Chefao",
            "Matrix",
            "Vingadores",
            "Titanic",
            "Interestelar",
            "Gladiador",
            "O Senhor dos Aneis",
            "Harry Potter",
            "Jurassic Park",
            "Star Wars",
            "Guardioes da galaxia"
        };
        private string[] temaEsportes = new string[]
        {
            "Futebol",
            "Basquete",
            "Volei",
            "Tenis",
            "Natacao",
            "Corrida",
            "Ciclismo",
            "Boxe",
            "Rugby",
            "Esqui"
        };


        private void radioButtonTema1_CheckedChanged(object sender, EventArgs e)
        {
            temaEscolhido = 1;

        }
        private void radioButtonTema2_CheckedChanged(object sender, EventArgs e)
        {
            temaEscolhido = 2;
        }
        private void radioButtonTema3_CheckedChanged(object sender, EventArgs e)
        {
            temaEscolhido = 3;
        }

        Random random = new Random();

        
        private void atualizarTela()
        {

        }

        private void iniciarJogo()
        {
            radioButtonTema1.Visible = false;
            radioButtonTema2.Visible = false;
            radioButtonTema3.Visible = false;
            listBoxRadio.Visible = false;


        }
        
        private void start()
        {
            switch (temaEscolhido)
            {
                case 1:
                    palavraEscolhida = temaAdjetivos[random.Next(temaAdjetivos.Length)].ToUpper();
                    letrasCorretas = new string('_', palavraEscolhida.Length).ToCharArray();

                    for (int i = 0; i < palavraEscolhida.Length; i++)
                    {
                        if (palavraEscolhida[i] == ' ')
                        {
                            letrasCorretas[i] = ' ';
                        }
                    }
                    atualizarTela();
                    break;
                case 2:
                    palavraEscolhida = temaFilmes[random.Next(temaFilmes.Length)].ToUpper();
                    letrasCorretas = new string('_', palavraEscolhida.Length).ToCharArray();

                    for (int i = 0; i < palavraEscolhida.Length; i++)
                    {
                        if (palavraEscolhida[i] == ' ')
                        {
                            letrasCorretas[i] = ' ';
                        }
                    }
                    atualizarTela();
                    break;
                case 3:
                    palavraEscolhida = temaEsportes[random.Next(temaEsportes.Length)].ToUpper();
                    letrasCorretas = new string('_', palavraEscolhida.Length).ToCharArray();

                    for (int i = 0; i < palavraEscolhida.Length; i++)
                    {
                        if (palavraEscolhida[i] == ' ')
                        {
                            letrasCorretas[i] = ' ';
                        }
                    }
                    atualizarTela();
                    break;
                default:

                    MessageBox.Show("Selecione um tema");
                    break;

                    
            }

        }

        private void bnt_Start_Click(object sender, EventArgs e)
        {
            start();

            
        }


        private void bnt_Testar_Click(object sender, EventArgs e)
        {

        }
    }
}
