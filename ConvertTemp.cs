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
    public partial class ConvertTemp : Form
    {
        public ConvertTemp()
        {
            InitializeComponent();
        }


        private void bnt_executar_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            int tipo = 0;
            string formato = "C°";

            if(double.TryParse(input, out double temperatura))
            {
                double ConvertTemperatura;


                if (radioButtonC.Checked)
                {
                    ConvertTemperatura = (temperatura - 32) * 5.0 / 9.0;
                    tipo = 1;
                }
                else if (radioButtonF.Checked) 
                {

                    ConvertTemperatura = (9.0 * temperatura + 160.0) / 5;
                    tipo = 2;
                }
                else
                {
                    MessageBox.Show("Por Favor selecione uma opção.");
                    return;
                }

                switch(tipo) {

                    case 1:
                        formato = "C°";
                        break;
                    case 2:
                        formato = "F°";
                        break;

                }
                ConvertTemperatura = Math.Round(ConvertTemperatura, 1);

                MessageBox.Show($"A temperatura convertida é: {ConvertTemperatura}{formato}");
            }
            else
            {
                MessageBox.Show("Informe uma temperatura valida.");
            }

        }


    }

}     
