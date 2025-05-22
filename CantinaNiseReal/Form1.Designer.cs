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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            txtQuantidade = new NumericUpDown();
            label2 = new Label();
            txtNomecliente = new TextBox();
            lblNome = new Label();
            cBoxPagamento = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtQuantidade).BeginInit();
            SuspendLayout();
            // 
            // txtprodutos
            // 
            txtprodutos.AutoSize = true;
            txtprodutos.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtprodutos.ForeColor = Color.FromArgb(230, 255, 0);
            txtprodutos.Location = new Point(278, 51);
            txtprodutos.Name = "txtprodutos";
            txtprodutos.Size = new Size(125, 16);
            txtprodutos.TabIndex = 0;
            txtprodutos.Text = "Produtos Cantina";
            // 
            // txtcarrinho
            // 
            txtcarrinho.AutoSize = true;
            txtcarrinho.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtcarrinho.ForeColor = Color.FromArgb(230, 255, 0);
            txtcarrinho.Location = new Point(780, 51);
            txtcarrinho.Name = "txtcarrinho";
            txtcarrinho.Size = new Size(65, 16);
            txtcarrinho.TabIndex = 1;
            txtcarrinho.Text = "Carrinho";
            // 
            // txtitem
            // 
            txtitem.BackColor = Color.FromArgb(243, 241, 238);
            txtitem.FormattingEnabled = true;
            txtitem.ItemHeight = 15;
            txtitem.Location = new Point(723, 69);
            txtitem.Name = "txtitem";
            txtitem.Size = new Size(170, 274);
            txtitem.TabIndex = 2;
            // 
            // txtlista
            // 
            txtlista.BackColor = Color.FromArgb(243, 241, 238);
            txtlista.FormattingEnabled = true;
            txtlista.ItemHeight = 15;
            txtlista.Location = new Point(242, 69);
            txtlista.Name = "txtlista";
            txtlista.Size = new Size(186, 274);
            txtlista.TabIndex = 3;
            txtlista.SelectedIndexChanged += txtlista_SelectedIndexChanged;
            // 
            // txtadicionar
            // 
            txtadicionar.BackColor = Color.FromArgb(202, 196, 183);
            txtadicionar.ForeColor = SystemColors.ActiveCaptionText;
            txtadicionar.Location = new Point(529, 83);
            txtadicionar.Name = "txtadicionar";
            txtadicionar.Size = new Size(66, 21);
            txtadicionar.TabIndex = 4;
            txtadicionar.Text = "Adicionar";
            txtadicionar.UseVisualStyleBackColor = false;
            txtadicionar.Click += txtadicionar_Click;
            // 
            // txtremover
            // 
            txtremover.BackColor = Color.FromArgb(202, 196, 183);
            txtremover.ForeColor = SystemColors.ActiveCaptionText;
            txtremover.Location = new Point(529, 122);
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
            txtfechar.BackColor = Color.FromArgb(230, 255, 0);
            txtfechar.ForeColor = SystemColors.ActiveCaptionText;
            txtfechar.Location = new Point(519, 320);
            txtfechar.Name = "txtfechar";
            txtfechar.Size = new Size(107, 28);
            txtfechar.TabIndex = 6;
            txtfechar.Text = "Fechar Pedido";
            txtfechar.UseVisualStyleBackColor = false;
            txtfechar.Click += txtfechar_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(543, 267);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(52, 15);
            lblTotal.TabIndex = 7;
            lblTotal.Text = "Total: R$";
            lblTotal.Click += lblTotal_Click;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(230, 255, 0);
            label1.Location = new Point(59, 301);
            label1.Name = "label1";
            label1.Size = new Size(124, 15);
            label1.TabIndex = 11;
            label1.Text = "Informe a quantidade";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Captura_de_tela_2025_05_19_081851;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(23, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(123, 56);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(96, 320);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(50, 23);
            txtQuantidade.TabIndex = 14;
            txtQuantidade.ValueChanged += txtQuantidade_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(230, 255, 0);
            label2.Location = new Point(57, 232);
            label2.Name = "label2";
            label2.Size = new Size(126, 15);
            label2.TabIndex = 15;
            label2.Text = "Forma de pagamento";
            label2.Click += lblPagamento;
            // 
            // txtNomecliente
            // 
            txtNomecliente.Location = new Point(793, 401);
            txtNomecliente.Name = "txtNomecliente";
            txtNomecliente.Size = new Size(100, 23);
            txtNomecliente.TabIndex = 17;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.ForeColor = Color.FromArgb(230, 255, 0);
            lblNome.Location = new Point(689, 404);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(98, 15);
            lblNome.TabIndex = 18;
            lblNome.Text = "Nome do cliente:";
            // 
            // cBoxPagamento
            // 
            cBoxPagamento.FormattingEnabled = true;
            cBoxPagamento.Location = new Point(57, 251);
            cBoxPagamento.Name = "cBoxPagamento";
            cBoxPagamento.Size = new Size(121, 23);
            cBoxPagamento.TabIndex = 19;
            cBoxPagamento.SelectedIndexChanged += cBoxPagamento_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 25, 12);
            ClientSize = new Size(974, 471);
            Controls.Add(cBoxPagamento);
            Controls.Add(lblNome);
            Controls.Add(txtNomecliente);
            Controls.Add(label2);
            Controls.Add(txtQuantidade);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
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
            Text = "s";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtQuantidade).EndInit();
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
        private Label label1;
        private PictureBox pictureBox1;
        private NumericUpDown txtQuantidade;
        private Label label2;
        private TextBox txtNomecliente;
        private Label lblNome;
        private ComboBox cBoxPagamento;
    }
}
