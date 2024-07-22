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
    public partial class CalculaDias : Form
    {
        public CalculaDias()
        {
            InitializeComponent();
        }

        public int idade;
        int resultadoMes;
        int resultadoDias;
        int resultadoHoras;
        int resultadoMin;
        int resultadoSeg;


        private void bnt_Executar_Click(object sender, EventArgs e)
        {
            string input = textBoxIdade.Text;
            if(int.TryParse(input, out int idade))
            {
                resultadoMes = idade * 12;
                resultadoDias = idade * 365;
                resultadoHoras = (idade * 365) * 24;
                resultadoMin = ((idade * 365) * 24) * 60;
                resultadoSeg = (((idade * 365) * 24) * 60) * 60;

                IdadeMes.Text = $"Você viveu {resultadoMes} meses";
                idadeDias.Text = $"Você viveu {resultadoDias} dias ";
                idadeHora.Text = $"Você viveu {resultadoHoras} horas";
                idadeMin.Text = $"Você viveu {resultadoMin} minutos";
                idadeSeg.Text = $"Você viveu {resultadoSeg} segundos";

                IdadeMes.Visible = true;
                idadeDias.Visible = true;
                idadeHora.Visible = true;
                idadeMin.Visible = true;
                idadeSeg.Visible = true;   






            }   
        }
    }
}
