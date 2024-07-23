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
            this.Interface = new System.Windows.Forms.PictureBox();
            this.PalavraSecreta = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bnt_Testar = new System.Windows.Forms.Button();
            this.listBoxRadio = new System.Windows.Forms.ListBox();
            this.radioButtonTema1 = new System.Windows.Forms.RadioButton();
            this.radioButtonTema2 = new System.Windows.Forms.RadioButton();
            this.radioButtonTema3 = new System.Windows.Forms.RadioButton();
            this.bnt_Start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Interface)).BeginInit();
            this.SuspendLayout();
            // 
            // Interface
            // 
            this.Interface.InitialImage = null;
            this.Interface.Location = new System.Drawing.Point(118, 31);
            this.Interface.Name = "Interface";
            this.Interface.Size = new System.Drawing.Size(244, 243);
            this.Interface.TabIndex = 0;
            this.Interface.TabStop = false;
            // 
            // PalavraSecreta
            // 
            this.PalavraSecreta.AutoSize = true;
            this.PalavraSecreta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PalavraSecreta.Location = new System.Drawing.Point(185, 295);
            this.PalavraSecreta.Name = "PalavraSecreta";
            this.PalavraSecreta.Size = new System.Drawing.Size(112, 18);
            this.PalavraSecreta.TabIndex = 1;
            this.PalavraSecreta.Text = "Palavra Secreta";
            this.PalavraSecreta.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(152, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Coloque uma letra";
            this.label2.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(287, 329);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(32, 24);
            this.textBox1.TabIndex = 3;
            this.textBox1.Visible = false;
            // 
            // bnt_Testar
            // 
            this.bnt_Testar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_Testar.Location = new System.Drawing.Point(188, 372);
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
            this.listBoxRadio.Location = new System.Drawing.Point(27, 22);
            this.listBoxRadio.Name = "listBoxRadio";
            this.listBoxRadio.Size = new System.Drawing.Size(123, 94);
            this.listBoxRadio.TabIndex = 5;
            // 
            // radioButtonTema1
            // 
            this.radioButtonTema1.AutoSize = true;
            this.radioButtonTema1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonTema1.Location = new System.Drawing.Point(42, 31);
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
            this.radioButtonTema2.Location = new System.Drawing.Point(42, 59);
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
            this.radioButtonTema3.Location = new System.Drawing.Point(42, 87);
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
            this.bnt_Start.Location = new System.Drawing.Point(53, 122);
            this.bnt_Start.Name = "bnt_Start";
            this.bnt_Start.Size = new System.Drawing.Size(75, 33);
            this.bnt_Start.TabIndex = 9;
            this.bnt_Start.Text = "Start";
            this.bnt_Start.UseVisualStyleBackColor = true;
            this.bnt_Start.Click += new System.EventHandler(this.bnt_Start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tentantivas restantes X";
            this.label1.Visible = false;
            // 
            // JogoForca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 417);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bnt_Start);
            this.Controls.Add(this.radioButtonTema3);
            this.Controls.Add(this.radioButtonTema2);
            this.Controls.Add(this.radioButtonTema1);
            this.Controls.Add(this.listBoxRadio);
            this.Controls.Add(this.bnt_Testar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PalavraSecreta);
            this.Controls.Add(this.Interface);
            this.Name = "JogoForca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "jogoForca";
            ((System.ComponentModel.ISupportInitialize)(this.Interface)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Interface;
        private System.Windows.Forms.Label PalavraSecreta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bnt_Testar;
        private System.Windows.Forms.ListBox listBoxRadio;
        private System.Windows.Forms.RadioButton radioButtonTema1;
        private System.Windows.Forms.RadioButton radioButtonTema2;
        private System.Windows.Forms.RadioButton radioButtonTema3;
        private System.Windows.Forms.Button bnt_Start;
        private System.Windows.Forms.Label label1;
    }
}