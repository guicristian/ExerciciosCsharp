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
            this.bnt_TestarLetra = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
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
            this.Interface.Location = new System.Drawing.Point(211, 31);
            this.Interface.Name = "Interface";
            this.Interface.Size = new System.Drawing.Size(244, 243);
            this.Interface.TabIndex = 0;
            this.Interface.TabStop = false;
            // 
            // PalavraSecreta
            // 
            this.PalavraSecreta.AutoSize = true;
            this.PalavraSecreta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PalavraSecreta.Location = new System.Drawing.Point(276, 295);
            this.PalavraSecreta.Name = "PalavraSecreta";
            this.PalavraSecreta.Size = new System.Drawing.Size(112, 18);
            this.PalavraSecreta.TabIndex = 1;
            this.PalavraSecreta.Text = "Palavra Secreta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(230, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Coloque uma letra";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(372, 329);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(32, 24);
            this.textBox1.TabIndex = 3;
            // 
            // bnt_TestarLetra
            // 
            this.bnt_TestarLetra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_TestarLetra.Location = new System.Drawing.Point(279, 372);
            this.bnt_TestarLetra.Name = "bnt_TestarLetra";
            this.bnt_TestarLetra.Size = new System.Drawing.Size(108, 33);
            this.bnt_TestarLetra.TabIndex = 4;
            this.bnt_TestarLetra.Text = "Testar";
            this.bnt_TestarLetra.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(27, 22);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(123, 94);
            this.listBox1.TabIndex = 5;
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
            this.bnt_Start.Click += new System.EventHandler(this.button2_Click);
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
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.bnt_TestarLetra);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PalavraSecreta);
            this.Controls.Add(this.Interface);
            this.Name = "JogoForca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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
        private System.Windows.Forms.Button bnt_TestarLetra;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RadioButton radioButtonTema1;
        private System.Windows.Forms.RadioButton radioButtonTema2;
        private System.Windows.Forms.RadioButton radioButtonTema3;
        private System.Windows.Forms.Button bnt_Start;
        private System.Windows.Forms.Label label1;
    }
}