namespace CotaçãoMoeda
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuConvertTemp = new System.Windows.Forms.ToolStripMenuItem();
            this.comissaoVendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculaDiasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jogoForcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuConvertTemp,
            this.comissaoVendaToolStripMenuItem,
            this.calculaDiasToolStripMenuItem,
            this.jogoForcaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(996, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // MenuConvertTemp
            // 
            this.MenuConvertTemp.Name = "MenuConvertTemp";
            this.MenuConvertTemp.Size = new System.Drawing.Size(181, 25);
            this.MenuConvertTemp.Text = "ConvertorTemperatura";
            this.MenuConvertTemp.Click += new System.EventHandler(this.ConvertorTemp_Click);
            // 
            // comissaoVendaToolStripMenuItem
            // 
            this.comissaoVendaToolStripMenuItem.Name = "comissaoVendaToolStripMenuItem";
            this.comissaoVendaToolStripMenuItem.Size = new System.Drawing.Size(134, 25);
            this.comissaoVendaToolStripMenuItem.Text = "ComissaoVenda";
            this.comissaoVendaToolStripMenuItem.Click += new System.EventHandler(this.comissaoVendaToolStripMenuItem_Click);
            // 
            // calculaDiasToolStripMenuItem
            // 
            this.calculaDiasToolStripMenuItem.Name = "calculaDiasToolStripMenuItem";
            this.calculaDiasToolStripMenuItem.Size = new System.Drawing.Size(102, 25);
            this.calculaDiasToolStripMenuItem.Text = "CalculaDias";
            this.calculaDiasToolStripMenuItem.Click += new System.EventHandler(this.calculaDiasToolStripMenuItem_Click);
            // 
            // jogoForcaToolStripMenuItem
            // 
            this.jogoForcaToolStripMenuItem.Name = "jogoForcaToolStripMenuItem";
            this.jogoForcaToolStripMenuItem.Size = new System.Drawing.Size(93, 25);
            this.jogoForcaToolStripMenuItem.Text = "JogoForca";
            this.jogoForcaToolStripMenuItem.Click += new System.EventHandler(this.jogoForcaToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 525);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuConvertTemp;
        private System.Windows.Forms.ToolStripMenuItem comissaoVendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculaDiasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jogoForcaToolStripMenuItem;
    }
}