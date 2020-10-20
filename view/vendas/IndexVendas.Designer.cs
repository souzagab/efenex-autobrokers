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
            this.SuspendLayout();
            // 
            // btnNewVenda
            // 
            this.btnNewVenda.Location = new System.Drawing.Point(142, 107);
            this.btnNewVenda.Name = "btnNewVenda";
            this.btnNewVenda.Size = new System.Drawing.Size(102, 23);
            this.btnNewVenda.TabIndex = 0;
            this.btnNewVenda.Text = "Nova Venda";
            this.btnNewVenda.UseVisualStyleBackColor = true;
            this.btnNewVenda.Click += new System.EventHandler(this.btnNewVenda_Click);
            // 
            // IndexVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNewVenda);
            this.Name = "IndexVendas";
            this.Text = "IndexVendas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewVenda;
    }
}