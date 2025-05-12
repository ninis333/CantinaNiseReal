namespace CantinaNiseReal
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtprodutos = new Label();
            txtcarrinho = new Label();
            txtitem = new ListBox();
            txtlista = new ListBox();
            txtadicionar = new Button();
            txtremover = new Button();
            txtfechar = new Button();
            lblTotal = new Label();
            SuspendLayout();
            // 
            // txtprodutos
            // 
            txtprodutos.AutoSize = true;
            txtprodutos.Location = new Point(161, 53);
            txtprodutos.Name = "txtprodutos";
            txtprodutos.Size = new Size(99, 15);
            txtprodutos.TabIndex = 0;
            txtprodutos.Text = "Produtos Cantina";
            // 
            // txtcarrinho
            // 
            txtcarrinho.AutoSize = true;
            txtcarrinho.Location = new Point(726, 53);
            txtcarrinho.Name = "txtcarrinho";
            txtcarrinho.Size = new Size(53, 15);
            txtcarrinho.TabIndex = 1;
            txtcarrinho.Text = "Carrinho";
            // 
            // txtitem
            // 
            txtitem.FormattingEnabled = true;
            txtitem.ItemHeight = 15;
            txtitem.Location = new Point(663, 74);
            txtitem.Name = "txtitem";
            txtitem.Size = new Size(170, 274);
            txtitem.TabIndex = 2;
            // 
            // txtlista
            // 
            txtlista.FormattingEnabled = true;
            txtlista.ItemHeight = 15;
            txtlista.Location = new Point(123, 74);
            txtlista.Name = "txtlista";
            txtlista.Size = new Size(186, 274);
            txtlista.TabIndex = 3;
            txtlista.SelectedIndexChanged += txtlista_SelectedIndexChanged;
            // 
            // txtadicionar
            // 
            txtadicionar.Location = new Point(464, 83);
            txtadicionar.Name = "txtadicionar";
            txtadicionar.Size = new Size(66, 21);
            txtadicionar.TabIndex = 4;
            txtadicionar.Text = "Adicionar";
            txtadicionar.UseVisualStyleBackColor = true;
            txtadicionar.Click += txtadicionar_Click;
            // 
            // txtremover
            // 
            txtremover.Location = new Point(464, 122);
            txtremover.Name = "txtremover";
            txtremover.Size = new Size(66, 21);
            txtremover.TabIndex = 5;
            txtremover.Text = "Remover";
            txtremover.UseMnemonic = false;
            txtremover.UseVisualStyleBackColor = true;
            txtremover.Click += txtremover_Click;
            // 
            // txtfechar
            // 
            txtfechar.Location = new Point(454, 320);
            txtfechar.Name = "txtfechar";
            txtfechar.Size = new Size(107, 28);
            txtfechar.TabIndex = 6;
            txtfechar.Text = "Fechar Pedido";
            txtfechar.UseVisualStyleBackColor = true;
            txtfechar.Click += txtfechar_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(478, 278);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(52, 15);
            lblTotal.TabIndex = 7;
            lblTotal.Text = "Total: R$";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(929, 471);
            Controls.Add(lblTotal);
            Controls.Add(txtfechar);
            Controls.Add(txtremover);
            Controls.Add(txtadicionar);
            Controls.Add(txtlista);
            Controls.Add(txtitem);
            Controls.Add(txtcarrinho);
            Controls.Add(txtprodutos);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtprodutos;
        private ListBox txtitem;
        private ListBox txtlista;
        private Button txtadicionar;
        private Button txtremover;
        private Button txtfechar;
        private Label txtcarrinho;
        private Label lblTotal;
    }
}
