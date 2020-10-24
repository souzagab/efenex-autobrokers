namespace Efenex.view.vendas
{
    partial class FormVendas
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
            this.cboxVendedores = new System.Windows.Forms.ComboBox();
            this.labelVendedores = new System.Windows.Forms.Label();
            this.cboxClientes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lboxVeiculos = new System.Windows.Forms.ListBox();
            this.labelClientes = new System.Windows.Forms.Label();
            this.btnVenda = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.VlrCaption = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboxVendedores
            // 
            this.cboxVendedores.FormattingEnabled = true;
            this.cboxVendedores.Location = new System.Drawing.Point(12, 47);
            this.cboxVendedores.Name = "cboxVendedores";
            this.cboxVendedores.Size = new System.Drawing.Size(182, 23);
            this.cboxVendedores.TabIndex = 0;
            this.cboxVendedores.SelectedIndexChanged += new System.EventHandler(this.cboxVendedores_SelectedIndexChanged);
            // 
            // labelVendedores
            // 
            this.labelVendedores.AutoSize = true;
            this.labelVendedores.Location = new System.Drawing.Point(12, 29);
            this.labelVendedores.Name = "labelVendedores";
            this.labelVendedores.Size = new System.Drawing.Size(57, 15);
            this.labelVendedores.TabIndex = 1;
            this.labelVendedores.Text = "Vendedor";
            this.labelVendedores.Click += new System.EventHandler(this.labelVendedores_Click);
            // 
            // cboxClientes
            // 
            this.cboxClientes.FormattingEnabled = true;
            this.cboxClientes.Location = new System.Drawing.Point(214, 47);
            this.cboxClientes.Name = "cboxClientes";
            this.cboxClientes.Size = new System.Drawing.Size(181, 23);
            this.cboxClientes.TabIndex = 0;
            this.cboxClientes.SelectedIndexChanged += new System.EventHandler(this.cboxVendedores_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 3;
            // 
            // lboxVeiculos
            // 
            this.lboxVeiculos.FormattingEnabled = true;
            this.lboxVeiculos.ItemHeight = 15;
            this.lboxVeiculos.Location = new System.Drawing.Point(12, 89);
            this.lboxVeiculos.Name = "lboxVeiculos";
            this.lboxVeiculos.Size = new System.Drawing.Size(385, 319);
            this.lboxVeiculos.TabIndex = 2;
            this.lboxVeiculos.SelectedIndexChanged += new System.EventHandler(this.lboxVeiculos_SelectedIndexChanged);
            // 
            // labelClientes
            // 
            this.labelClientes.AutoSize = true;
            this.labelClientes.Location = new System.Drawing.Point(214, 29);
            this.labelClientes.Name = "labelClientes";
            this.labelClientes.Size = new System.Drawing.Size(44, 15);
            this.labelClientes.TabIndex = 1;
            this.labelClientes.Text = "Cliente";
            this.labelClientes.Click += new System.EventHandler(this.labelVendedores_Click);
            // 
            // btnVenda
            // 
            this.btnVenda.Location = new System.Drawing.Point(178, 431);
            this.btnVenda.Name = "btnVenda";
            this.btnVenda.Size = new System.Drawing.Size(219, 39);
            this.btnVenda.TabIndex = 4;
            this.btnVenda.Text = "Confirmar venda";
            this.btnVenda.UseVisualStyleBackColor = true;
            this.btnVenda.Click += new System.EventHandler(this.btnVenda_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 516);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // VlrCaption
            // 
            this.VlrCaption.AutoSize = true;
            this.VlrCaption.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VlrCaption.Location = new System.Drawing.Point(12, 429);
            this.VlrCaption.Name = "VlrCaption";
            this.VlrCaption.Size = new System.Drawing.Size(67, 32);
            this.VlrCaption.TabIndex = 5;
            this.VlrCaption.Text = "Valor";
            // 
            // FormVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 566);
            this.Controls.Add(this.VlrCaption);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnVenda);
            this.Controls.Add(this.labelClientes);
            this.Controls.Add(this.lboxVeiculos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboxClientes);
            this.Controls.Add(this.labelVendedores);
            this.Controls.Add(this.cboxVendedores);
            this.Name = "FormVendas";
            this.Text = "Realizar Venda";
            this.Load += new System.EventHandler(this.FormVendas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxVendedores;
        private System.Windows.Forms.Label labelVendedores;
        private System.Windows.Forms.ComboBox cboxClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lboxVeiculos;
        private System.Windows.Forms.Label labelClientes;
        private System.Windows.Forms.Button btnVenda;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label VlrCaption;
    }
}