namespace CotaçãoMoeda
{
    partial class ComissaoVenda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.IdVendedor = new System.Windows.Forms.Label();
            this.CodProduto = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.calcularComissao = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.Label();
            this.NumIdVend = new System.Windows.Forms.NumericUpDown();
            this.NumCodProd = new System.Windows.Forms.NumericUpDown();
            this.NumQntVendida = new System.Windows.Forms.NumericUpDown();
            this.textBoxPrecoUnit = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumIdVend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumCodProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumQntVendida)).BeginInit();
            this.SuspendLayout();
            // 
            // IdVendedor
            // 
            this.IdVendedor.AutoSize = true;
            this.IdVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdVendedor.Location = new System.Drawing.Point(22, 21);
            this.IdVendedor.Name = "IdVendedor";
            this.IdVendedor.Size = new System.Drawing.Size(89, 18);
            this.IdVendedor.TabIndex = 0;
            this.IdVendedor.Text = "ID Vendedor";
            // 
            // CodProduto
            // 
            this.CodProduto.AutoSize = true;
            this.CodProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodProduto.Location = new System.Drawing.Point(22, 55);
            this.CodProduto.Name = "CodProduto";
            this.CodProduto.Size = new System.Drawing.Size(80, 18);
            this.CodProduto.TabIndex = 1;
            this.CodProduto.Text = "Cod. Prod.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Preço Unit.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Qnt. Vendida";
            // 
            // calcularComissao
            // 
            this.calcularComissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcularComissao.Location = new System.Drawing.Point(104, 186);
            this.calcularComissao.Name = "calcularComissao";
            this.calcularComissao.Size = new System.Drawing.Size(119, 37);
            this.calcularComissao.TabIndex = 4;
            this.calcularComissao.Text = "Calcular";
            this.calcularComissao.UseVisualStyleBackColor = true;
            this.calcularComissao.Click += new System.EventHandler(this.calcularComissao_Click);
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result.ForeColor = System.Drawing.Color.Red;
            this.Result.Location = new System.Drawing.Point(3, 265);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(51, 16);
            this.Result.TabIndex = 9;
            this.Result.Text = "Result";
            this.Result.Visible = false;
            // 
            // NumIdVend
            // 
            this.NumIdVend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumIdVend.Location = new System.Drawing.Point(138, 21);
            this.NumIdVend.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NumIdVend.Name = "NumIdVend";
            this.NumIdVend.Size = new System.Drawing.Size(40, 22);
            this.NumIdVend.TabIndex = 20;
            // 
            // NumCodProd
            // 
            this.NumCodProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumCodProd.Location = new System.Drawing.Point(138, 55);
            this.NumCodProd.Name = "NumCodProd";
            this.NumCodProd.Size = new System.Drawing.Size(40, 22);
            this.NumCodProd.TabIndex = 21;
            // 
            // NumQntVendida
            // 
            this.NumQntVendida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumQntVendida.Location = new System.Drawing.Point(138, 127);
            this.NumQntVendida.Name = "NumQntVendida";
            this.NumQntVendida.Size = new System.Drawing.Size(40, 22);
            this.NumQntVendida.TabIndex = 23;
            // 
            // textBoxPrecoUnit
            // 
            this.textBoxPrecoUnit.Location = new System.Drawing.Point(138, 92);
            this.textBoxPrecoUnit.Name = "textBoxPrecoUnit";
            this.textBoxPrecoUnit.Size = new System.Drawing.Size(40, 20);
            this.textBoxPrecoUnit.TabIndex = 22;
            this.textBoxPrecoUnit.TextChanged += new System.EventHandler(this.textBoxPrecoUnit_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(255, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 27);
            this.button1.TabIndex = 24;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // ComissaoVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 303);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxPrecoUnit);
            this.Controls.Add(this.NumQntVendida);
            this.Controls.Add(this.NumCodProd);
            this.Controls.Add(this.NumIdVend);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.calcularComissao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CodProduto);
            this.Controls.Add(this.IdVendedor);
            this.Name = "ComissaoVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "                                                                      ";
            ((System.ComponentModel.ISupportInitialize)(this.NumIdVend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumCodProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumQntVendida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IdVendedor;
        private System.Windows.Forms.Label CodProduto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button calcularComissao;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.NumericUpDown NumIdVend;
        private System.Windows.Forms.NumericUpDown NumCodProd;
        private System.Windows.Forms.NumericUpDown NumQntVendida;
        private System.Windows.Forms.TextBox textBoxPrecoUnit;
        private System.Windows.Forms.Button button1;
    }
}