namespace CotaçãoMoeda
{
    partial class JogoForca
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
            this.telaJogo = new System.Windows.Forms.PictureBox();
            this.labelPalavraSecreta = new System.Windows.Forms.Label();
            this.labelInput = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.bnt_Testar = new System.Windows.Forms.Button();
            this.listBoxRadio = new System.Windows.Forms.ListBox();
            this.radioButtonTema1 = new System.Windows.Forms.RadioButton();
            this.radioButtonTema2 = new System.Windows.Forms.RadioButton();
            this.radioButtonTema3 = new System.Windows.Forms.RadioButton();
            this.bnt_Start = new System.Windows.Forms.Button();
            this.labelTentativas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.telaJogo)).BeginInit();
            this.SuspendLayout();
            // 
            // telaJogo
            // 
            this.telaJogo.InitialImage = null;
            this.telaJogo.Location = new System.Drawing.Point(186, 22);
            this.telaJogo.Name = "telaJogo";
            this.telaJogo.Size = new System.Drawing.Size(265, 273);
            this.telaJogo.TabIndex = 0;
            this.telaJogo.TabStop = false;
            // 
            // labelPalavraSecreta
            // 
            this.labelPalavraSecreta.AutoSize = true;
            this.labelPalavraSecreta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPalavraSecreta.Location = new System.Drawing.Point(257, 307);
            this.labelPalavraSecreta.Name = "labelPalavraSecreta";
            this.labelPalavraSecreta.Size = new System.Drawing.Size(112, 18);
            this.labelPalavraSecreta.TabIndex = 1;
            this.labelPalavraSecreta.Text = "Palavra Secreta";
            this.labelPalavraSecreta.Visible = false;
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInput.Location = new System.Drawing.Point(230, 340);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(129, 18);
            this.labelInput.TabIndex = 2;
            this.labelInput.Text = "Coloque uma letra";
            this.labelInput.Visible = false;
            // 
            // textBoxInput
            // 
            this.textBoxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInput.Location = new System.Drawing.Point(365, 337);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(32, 24);
            this.textBoxInput.TabIndex = 3;
            this.textBoxInput.Visible = false;
            // 
            // bnt_Testar
            // 
            this.bnt_Testar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_Testar.Location = new System.Drawing.Point(261, 376);
            this.bnt_Testar.Name = "bnt_Testar";
            this.bnt_Testar.Size = new System.Drawing.Size(108, 33);
            this.bnt_Testar.TabIndex = 4;
            this.bnt_Testar.Text = "Testar";
            this.bnt_Testar.UseVisualStyleBackColor = true;
            this.bnt_Testar.Visible = false;
            this.bnt_Testar.Click += new System.EventHandler(this.bnt_Testar_Click);
            // 
            // listBoxRadio
            // 
            this.listBoxRadio.BackColor = System.Drawing.SystemColors.Menu;
            this.listBoxRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxRadio.FormattingEnabled = true;
            this.listBoxRadio.ItemHeight = 18;
            this.listBoxRadio.Location = new System.Drawing.Point(12, 13);
            this.listBoxRadio.Name = "listBoxRadio";
            this.listBoxRadio.Size = new System.Drawing.Size(122, 112);
            this.listBoxRadio.TabIndex = 5;
            // 
            // radioButtonTema1
            // 
            this.radioButtonTema1.AutoSize = true;
            this.radioButtonTema1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonTema1.Location = new System.Drawing.Point(27, 31);
            this.radioButtonTema1.Name = "radioButtonTema1";
            this.radioButtonTema1.Size = new System.Drawing.Size(85, 22);
            this.radioButtonTema1.TabIndex = 6;
            this.radioButtonTema1.TabStop = true;
            this.radioButtonTema1.Text = "Adjetivos";
            this.radioButtonTema1.UseVisualStyleBackColor = true;
            this.radioButtonTema1.CheckedChanged += new System.EventHandler(this.radioButtonTema1_CheckedChanged);
            // 
            // radioButtonTema2
            // 
            this.radioButtonTema2.AutoSize = true;
            this.radioButtonTema2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonTema2.Location = new System.Drawing.Point(27, 59);
            this.radioButtonTema2.Name = "radioButtonTema2";
            this.radioButtonTema2.Size = new System.Drawing.Size(70, 22);
            this.radioButtonTema2.TabIndex = 7;
            this.radioButtonTema2.TabStop = true;
            this.radioButtonTema2.Text = "Filmes";
            this.radioButtonTema2.UseVisualStyleBackColor = true;
            this.radioButtonTema2.CheckedChanged += new System.EventHandler(this.radioButtonTema2_CheckedChanged);
            // 
            // radioButtonTema3
            // 
            this.radioButtonTema3.AutoSize = true;
            this.radioButtonTema3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonTema3.Location = new System.Drawing.Point(26, 87);
            this.radioButtonTema3.Name = "radioButtonTema3";
            this.radioButtonTema3.Size = new System.Drawing.Size(86, 22);
            this.radioButtonTema3.TabIndex = 8;
            this.radioButtonTema3.TabStop = true;
            this.radioButtonTema3.Text = "Esportes";
            this.radioButtonTema3.UseVisualStyleBackColor = true;
            this.radioButtonTema3.CheckedChanged += new System.EventHandler(this.radioButtonTema3_CheckedChanged);
            // 
            // bnt_Start
            // 
            this.bnt_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_Start.Location = new System.Drawing.Point(37, 131);
            this.bnt_Start.Name = "bnt_Start";
            this.bnt_Start.Size = new System.Drawing.Size(75, 33);
            this.bnt_Start.TabIndex = 9;
            this.bnt_Start.Text = "Start";
            this.bnt_Start.UseVisualStyleBackColor = true;
            this.bnt_Start.Click += new System.EventHandler(this.bnt_Start_Click);
            // 
            // labelTentativas
            // 
            this.labelTentativas.AutoSize = true;
            this.labelTentativas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTentativas.Location = new System.Drawing.Point(24, 217);
            this.labelTentativas.Name = "labelTentativas";
            this.labelTentativas.Size = new System.Drawing.Size(152, 18);
            this.labelTentativas.TabIndex = 10;
            this.labelTentativas.Text = "Tentantivas restantes ";
            this.labelTentativas.Visible = false;
            // 
            // JogoForca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 432);
            this.Controls.Add(this.labelTentativas);
            this.Controls.Add(this.bnt_Start);
            this.Controls.Add(this.radioButtonTema3);
            this.Controls.Add(this.radioButtonTema2);
            this.Controls.Add(this.radioButtonTema1);
            this.Controls.Add(this.listBoxRadio);
            this.Controls.Add(this.bnt_Testar);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.labelInput);
            this.Controls.Add(this.labelPalavraSecreta);
            this.Controls.Add(this.telaJogo);
            this.Name = "JogoForca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "jogoForca";
            ((System.ComponentModel.ISupportInitialize)(this.telaJogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelPalavraSecreta;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button bnt_Testar;
        private System.Windows.Forms.ListBox listBoxRadio;
        private System.Windows.Forms.RadioButton radioButtonTema1;
        private System.Windows.Forms.RadioButton radioButtonTema2;
        private System.Windows.Forms.RadioButton radioButtonTema3;
        private System.Windows.Forms.Button bnt_Start;
        private System.Windows.Forms.Label labelTentativas;
        public System.Windows.Forms.PictureBox telaJogo;
    }
}