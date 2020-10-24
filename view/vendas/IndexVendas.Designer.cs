namespace Efenex.view.vendas
{
    partial class IndexVendas
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
            this.btnNewVenda = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNewVenda
            // 
            this.btnNewVenda.Location = new System.Drawing.Point(12, 12);
            this.btnNewVenda.Name = "btnNewVenda";
            this.btnNewVenda.Size = new System.Drawing.Size(166, 61);
            this.btnNewVenda.TabIndex = 0;
            this.btnNewVenda.Text = "Nova Venda";
            this.btnNewVenda.UseVisualStyleBackColor = true;
            this.btnNewVenda.Click += new System.EventHandler(this.btnNewVenda_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 41);
            this.button1.TabIndex = 2;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // IndexVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(187, 147);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNewVenda);
            this.Name = "IndexVendas";
            this.Text = "Vendas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewVenda;
        private System.Windows.Forms.Button button1;
    }
}