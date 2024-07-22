namespace CotaçãoMoeda
{
    partial class CalculaDias
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
            this.bnt_Executar = new System.Windows.Forms.Button();
            this.textBoxIdade = new System.Windows.Forms.TextBox();
            this.InputIdade = new System.Windows.Forms.Label();
            this.IdadeMes = new System.Windows.Forms.Label();
            this.idadeDias = new System.Windows.Forms.Label();
            this.idadeHora = new System.Windows.Forms.Label();
            this.idadeMin = new System.Windows.Forms.Label();
            this.idadeSeg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bnt_Executar
            // 
            this.bnt_Executar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_Executar.Location = new System.Drawing.Point(141, 73);
            this.bnt_Executar.Name = "bnt_Executar";
            this.bnt_Executar.Size = new System.Drawing.Size(96, 31);
            this.bnt_Executar.TabIndex = 0;
            this.bnt_Executar.Text = "Executar";
            this.bnt_Executar.UseVisualStyleBackColor = true;
            this.bnt_Executar.Click += new System.EventHandler(this.bnt_Executar_Click);
            // 
            // textBoxIdade
            // 
            this.textBoxIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIdade.Location = new System.Drawing.Point(282, 12);
            this.textBoxIdade.Name = "textBoxIdade";
            this.textBoxIdade.Size = new System.Drawing.Size(34, 26);
            this.textBoxIdade.TabIndex = 1;
            // 
            // InputIdade
            // 
            this.InputIdade.AutoSize = true;
            this.InputIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputIdade.Location = new System.Drawing.Point(75, 12);
            this.InputIdade.Name = "InputIdade";
            this.InputIdade.Size = new System.Drawing.Size(143, 20);
            this.InputIdade.TabIndex = 2;
            this.InputIdade.Text = "Coloque sua Idade";
            // 
            // IdadeMes
            // 
            this.IdadeMes.AutoSize = true;
            this.IdadeMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdadeMes.ForeColor = System.Drawing.Color.Black;
            this.IdadeMes.Location = new System.Drawing.Point(12, 114);
            this.IdadeMes.Name = "IdadeMes";
            this.IdadeMes.Size = new System.Drawing.Size(42, 20);
            this.IdadeMes.TabIndex = 3;
            this.IdadeMes.Text = "mes";
            this.IdadeMes.Visible = false;
            // 
            // idadeDias
            // 
            this.idadeDias.AutoSize = true;
            this.idadeDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idadeDias.ForeColor = System.Drawing.Color.IndianRed;
            this.idadeDias.Location = new System.Drawing.Point(12, 155);
            this.idadeDias.Name = "idadeDias";
            this.idadeDias.Size = new System.Drawing.Size(42, 20);
            this.idadeDias.TabIndex = 4;
            this.idadeDias.Text = "dias";
            this.idadeDias.Visible = false;
            // 
            // idadeHora
            // 
            this.idadeHora.AutoSize = true;
            this.idadeHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idadeHora.ForeColor = System.Drawing.Color.Firebrick;
            this.idadeHora.Location = new System.Drawing.Point(12, 199);
            this.idadeHora.Name = "idadeHora";
            this.idadeHora.Size = new System.Drawing.Size(54, 20);
            this.idadeHora.TabIndex = 5;
            this.idadeHora.Text = "horas";
            this.idadeHora.Visible = false;
            // 
            // idadeMin
            // 
            this.idadeMin.AutoSize = true;
            this.idadeMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idadeMin.ForeColor = System.Drawing.Color.Red;
            this.idadeMin.Location = new System.Drawing.Point(12, 242);
            this.idadeMin.Name = "idadeMin";
            this.idadeMin.Size = new System.Drawing.Size(37, 20);
            this.idadeMin.TabIndex = 6;
            this.idadeMin.Text = "min";
            this.idadeMin.Visible = false;
            // 
            // idadeSeg
            // 
            this.idadeSeg.AutoSize = true;
            this.idadeSeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idadeSeg.ForeColor = System.Drawing.Color.Red;
            this.idadeSeg.Location = new System.Drawing.Point(12, 289);
            this.idadeSeg.Name = "idadeSeg";
            this.idadeSeg.Size = new System.Drawing.Size(38, 20);
            this.idadeSeg.TabIndex = 7;
            this.idadeSeg.Text = "seg";
            this.idadeSeg.Visible = false;
            // 
            // CalculaDias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 336);
            this.Controls.Add(this.idadeSeg);
            this.Controls.Add(this.idadeMin);
            this.Controls.Add(this.idadeHora);
            this.Controls.Add(this.idadeDias);
            this.Controls.Add(this.IdadeMes);
            this.Controls.Add(this.InputIdade);
            this.Controls.Add(this.textBoxIdade);
            this.Controls.Add(this.bnt_Executar);
            this.Name = "CalculaDias";
            this.Text = "Calcula Qnt Dias";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bnt_Executar;
        private System.Windows.Forms.TextBox textBoxIdade;
        private System.Windows.Forms.Label InputIdade;
        private System.Windows.Forms.Label IdadeMes;
        private System.Windows.Forms.Label idadeDias;
        private System.Windows.Forms.Label idadeHora;
        private System.Windows.Forms.Label idadeMin;
        private System.Windows.Forms.Label idadeSeg;
    }
}