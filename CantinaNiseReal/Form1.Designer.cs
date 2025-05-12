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
            data = new DateTimePicker();
            hora = new DateTimePicker();
            quantidade = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtprodutos
            // 
            txtprodutos.AutoSize = true;
            txtprodutos.Location = new Point(213, 51);
            txtprodutos.Name = "txtprodutos";
            txtprodutos.Size = new Size(99, 15);
            txtprodutos.TabIndex = 0;
            txtprodutos.Text = "Produtos Cantina";
            // 
            // txtcarrinho
            // 
            txtcarrinho.AutoSize = true;
            txtcarrinho.Location = new Point(715, 51);
            txtcarrinho.Name = "txtcarrinho";
            txtcarrinho.Size = new Size(53, 15);
            txtcarrinho.TabIndex = 1;
            txtcarrinho.Text = "Carrinho";
            // 
            // txtitem
            // 
            txtitem.FormattingEnabled = true;
            txtitem.ItemHeight = 15;
            txtitem.Location = new Point(658, 69);
            txtitem.Name = "txtitem";
            txtitem.Size = new Size(170, 274);
            txtitem.TabIndex = 2;
            // 
            // txtlista
            // 
            txtlista.FormattingEnabled = true;
            txtlista.ItemHeight = 15;
            txtlista.Location = new Point(177, 69);
            txtlista.Name = "txtlista";
            txtlista.Size = new Size(186, 274);
            txtlista.TabIndex = 3;
            txtlista.SelectedIndexChanged += txtlista_SelectedIndexChanged;
            // 
            // txtadicionar
            // 
            txtadicionar.BackColor = Color.White;
            txtadicionar.ForeColor = SystemColors.ActiveCaptionText;
            txtadicionar.Location = new Point(464, 83);
            txtadicionar.Name = "txtadicionar";
            txtadicionar.Size = new Size(66, 21);
            txtadicionar.TabIndex = 4;
            txtadicionar.Text = "Adicionar";
            txtadicionar.UseVisualStyleBackColor = false;
            txtadicionar.Click += txtadicionar_Click;
            // 
            // txtremover
            // 
            txtremover.BackColor = SystemColors.ButtonHighlight;
            txtremover.ForeColor = SystemColors.ActiveCaptionText;
            txtremover.Location = new Point(464, 122);
            txtremover.Name = "txtremover";
            txtremover.Size = new Size(66, 21);
            txtremover.TabIndex = 5;
            txtremover.Text = "Remover";
            txtremover.UseMnemonic = false;
            txtremover.UseVisualStyleBackColor = false;
            txtremover.Click += txtremover_Click;
            // 
            // txtfechar
            // 
            txtfechar.ForeColor = SystemColors.ActiveCaptionText;
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
            lblTotal.Location = new Point(478, 267);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(52, 15);
            lblTotal.TabIndex = 7;
            lblTotal.Text = "Total: R$";
            // 
            // data
            // 
            data.Format = DateTimePickerFormat.Short;
            data.Location = new Point(23, 424);
            data.Name = "data";
            data.Size = new Size(85, 23);
            data.TabIndex = 8;
            // 
            // hora
            // 
            hora.Format = DateTimePickerFormat.Time;
            hora.Location = new Point(132, 424);
            hora.Name = "hora";
            hora.Size = new Size(68, 23);
            hora.TabIndex = 9;
            // 
            // quantidade
            // 
            quantidade.Location = new Point(23, 320);
            quantidade.Name = "quantidade";
            quantidade.Size = new Size(100, 23);
            quantidade.TabIndex = 10;
            quantidade.TextChanged += quantidade_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 302);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 11;
            label1.Text = "Digite a quantidade";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Snap ITC", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 22);
            label2.Name = "label2";
            label2.Size = new Size(76, 31);
            label2.TabIndex = 12;
            label2.Text = "Bolt";
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            ClientSize = new Size(919, 476);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(quantidade);
            Controls.Add(hora);
            Controls.Add(data);
            Controls.Add(lblTotal);
            Controls.Add(txtfechar);
            Controls.Add(txtremover);
            Controls.Add(txtadicionar);
            Controls.Add(txtlista);
            Controls.Add(txtitem);
            Controls.Add(txtcarrinho);
            Controls.Add(txtprodutos);
            ForeColor = SystemColors.ButtonFace;
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
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
        private DateTimePicker data;
        private DateTimePicker hora;
        private TextBox quantidade;
        private Label label1;
        private Label label2;
    }
}
