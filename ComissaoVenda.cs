using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CotaçãoMoeda
{
    public partial class ComissaoVenda : Form
    {
        public ComissaoVenda()
        {
            InitializeComponent();

            textBoxPrecoUnit.Text = "0,00";
            textBoxPrecoUnit.TextAlign = HorizontalAlignment.Right;
            textBoxPrecoUnit.TextChanged += textBoxPrecoUnit_TextChanged;

        }

        private void textBoxPrecoUnit_TextChanged(object sender, EventArgs e)
        {
            textBoxPrecoUnit.TextChanged -= textBoxPrecoUnit_TextChanged;
            string PrecoUnit = textBoxPrecoUnit.Text.Replace(",", "").Replace(".", "");
            if( decimal.TryParse(PrecoUnit, out decimal value)){
                value /= 100;
                textBoxPrecoUnit.Text = value.ToString("N2");
                textBoxPrecoUnit.SelectionStart = textBoxPrecoUnit.Text.Length;
            }
            else 
            {
                textBoxPrecoUnit.Text = "0,00";
                textBoxPrecoUnit.SelectionStart = textBoxPrecoUnit.Text.Length;            
            }

            textBoxPrecoUnit.TextChanged += textBoxPrecoUnit_TextChanged;



        }

        private void calcularComissao_Click(object sender, EventArgs e)
        {
            int IdVen = (int)NumIdVend.Value;
            int CodProd = (int)NumCodProd.Value;
            int QntVendido = (int)NumQntVendida.Value;
            int PerComissao = 5;
            decimal Valor = GetValor();
            decimal ValorTotal = Valor * QntVendido;
            decimal ValorComissao = PerComissao * ValorTotal/100;
            Result.Visible = true;
            Result.Text = $"Valor da comissão é {ValorComissao}";

        }
        private decimal GetValor()
        {
            string PrecoUnit = textBoxPrecoUnit.Text.Replace(",", "").Replace(".", "");
            if( decimal.TryParse(PrecoUnit,out decimal value))
            {
                value /= 100;
                return value;
            }
            else
            {
                return 0;
            }
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            NumIdVend.Value = 0; 
            NumCodProd.Value = 0;
            NumQntVendida.Value = 0;
            textBoxPrecoUnit.Text = "0,00";
            
        }

      
    }
}