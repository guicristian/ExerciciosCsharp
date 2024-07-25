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

        private Image imgPadrao = Image.FromFile("C:\\Users\\guilherme\\source\\repos\\guicristian\\ExerciciosCsharp\\image\\Forca.png");
        private Image imgErro1 = Image.FromFile("C:\\Users\\guilherme\\source\\repos\\guicristian\\ExerciciosCsharp\\image\\erro 1.png");
        private Image imgErro2 = Image.FromFile("C:\\Users\\guilherme\\source\\repos\\guicristian\\ExerciciosCsharp\\image\\erro 2.png");
        private Image imgErro3 = Image.FromFile("C:\\Users\\guilherme\\source\\repos\\guicristian\\ExerciciosCsharp\\image\\erro 3.png");
        private Image imgErro4 = Image.FromFile("C:\\Users\\guilherme\\source\\repos\\guicristian\\ExerciciosCsharp\\image\\erro 4.png");
        private Image imgErro5 = Image.FromFile("C:\\Users\\guilherme\\source\\repos\\guicristian\\ExerciciosCsharp\\image\\erro 5.png");
        private Image imgErro6 = Image.FromFile("C:\\Users\\guilherme\\source\\repos\\guicristian\\ExerciciosCsharp\\image\\erro 5.png");
        
        private int temaEscolhido;
        private string palavraEscolhida;
        private int qntTentativas = 6;
        private string tentativa;
        private bool letraEncontrada;
        
        private char[] letrasCorretas;
        private char[] letrasSecretas;
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
            bnt_Start.Visible = false;   
            radioButtonTema1.Visible = false;
            radioButtonTema2.Visible = false;
            radioButtonTema3.Visible = false;
            listBoxRadio.Visible = false;
            labelInput.Visible = true;
            labelPalavraSecreta.Visible = true;
            labelTentativas.Visible = true;
            textBoxInput.Visible = true;
            bnt_Testar.Visible = true;
            telaJogo.Visible = true;
            telaJogo.Image = imgPadrao;
         
            
        }
        private void terminarJogo()
        {
            bnt_Start.Visible = true;
            radioButtonTema1.Visible = true;
            radioButtonTema2.Visible = true;
            radioButtonTema3.Visible = true;
            listBoxRadio.Visible = true;
            labelInput.Visible = false;
            labelPalavraSecreta.Visible = false;
            labelTentativas.Visible = false;
            textBoxInput.Visible = false;
            bnt_Testar.Visible = false;
            qntTentativas = 6;
            telaJogo.Visible = false;
        }
       
        
        private void start()
        {
            switch (temaEscolhido)
            {
                case 1:
                    palavraEscolhida = temaAdjetivos[random.Next(temaAdjetivos.Length)].ToUpper();
                    letrasSecretas = palavraEscolhida.ToCharArray();
                    letrasCorretas = new string('_', palavraEscolhida.Length).ToCharArray();

                    for (int i = 0; i < palavraEscolhida.Length; i++)
                    {
                        if (palavraEscolhida[i] == ' ')
                        {
                            letrasCorretas[i] = ' ';
                        }
                    }
                    labelPalavraSecreta.Text = string.Join(" ", letrasCorretas);
                    atualizarTela();
                    break;
                case 2:
                    palavraEscolhida = temaFilmes[random.Next(temaFilmes.Length)].ToUpper();
                    letrasSecretas = palavraEscolhida.ToCharArray();
                    letrasCorretas = new string('_', palavraEscolhida.Length).ToCharArray();

                    for (int i = 0; i < palavraEscolhida.Length; i++)
                    {
                        if (palavraEscolhida[i] == ' ')
                        {
                            letrasCorretas[i] = ' ';
                        }
                    }
                    labelPalavraSecreta.Text = string.Join(" ", letrasCorretas);
                    atualizarTela();
                    break;
                case 3:
                    palavraEscolhida = temaEsportes[random.Next(temaEsportes.Length)].ToUpper();
                    letrasSecretas = palavraEscolhida.ToCharArray();
                    letrasCorretas = new string('_', palavraEscolhida.Length).ToCharArray();

                    for (int i = 0; i < palavraEscolhida.Length; i++)
                    {
                        if (palavraEscolhida[i] == ' ')
                        {
                            letrasCorretas[i] = ' ';
                        }
                    }
                    labelPalavraSecreta.Text = string.Join(" ", letrasCorretas);
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
            letraEncontrada = false;
            if (qntTentativas > 0)
            {

                for (int i = 0; i < letrasSecretas.Length; i++)
                {
                    if (letrasSecretas[i].ToString() == tentativa)
                    {
                        letraEncontrada = true;  
                        
                    }
                }
                    if (!letraEncontrada)
                    {
                        qntTentativas--;
                        
                    }
                labelTentativas.Text = $"{qntTentativas} Tentativas restantes";
            }
            else
            {
                terminarJogo();
            }
        }
    }
}
