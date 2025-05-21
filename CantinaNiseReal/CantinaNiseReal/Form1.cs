using System.Text;
using System.Windows.Forms;
using CantinaNiseReal;

namespace CantinaNiseReal
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            txtQuantidade.Minimum = 1;
        }

        List<string> list = new List<string>();
        double total = 0;
        public int quantidade = 0;


        private void txtadicionar_Click(object sender, EventArgs e)
        {
          
            if (txtlista.SelectedItem != null)
            {
                Produtos produtoSelecionado = (Produtos)txtlista.SelectedItem;
                txtlista.SelectedItem = null;
                int quantidade = (int)txtQuantidade.Value;
                txtitem.Items.Add(produtoSelecionado);
                total += produtoSelecionado.preco * quantidade;
                lblTotal.Text = $"Total: R$ {total:F2}";
            }

        }

        private void txtremover_Click(object sender, EventArgs e)
        {
            if (txtitem.SelectedItem != null)
            {
                Produtos produtoSelecionado = (Produtos)txtitem.SelectedItem;
                txtitem.SelectedItem = null;
                int quantidade = (int)txtQuantidade.Value;
                txtitem.Items.Remove(produtoSelecionado);
                total -= produtoSelecionado.preco * quantidade;
                lblTotal.Text = $"Total: R$ {total * quantidade:F2}";

            }
        }
        private void txtfechar_Click(object sender, EventArgs e)
        {
            string cliente = txtNomecliente.Text.Trim();

            if (string.IsNullOrEmpty(cliente))
            {
                cliente = char.ToUpper(cliente[0]) + cliente.Substring(1).ToLower();
            }

            StringBuilder extrato = new StringBuilder();

            foreach (Produtos item in txtitem.Items)
            {
                extrato.AppendLine(item.ToString());
            }

            DateTime datinha = data.Value.Date;
            DateTime horinha = hora.Value;

            string datinhaEhorinha = $"{datinha:dd/MM/yyyy} - {horinha:HH:mm:ss}";

            switch (cBoxPagamento.SelectedIndex)
            {
                case 0:
                    MessageBox.Show($"Nome do cliente: {cliente} \n" +
                        $"O seu Pedido foi: {extrato} \n " +
                        $"O seu total é: R$ {total:F2} \n" +
                        $"{datinhaEhorinha} \n" +
                        $" Forma de pagamento: {cBoxPagamento.SelectedItem}","Comanda");

                    string input = Microsoft.VisualBasic.Interaction.InputBox("Valor que será pago: ", "Pagamento");

                    if (double.TryParse(input, out double ValorPago))
                    {
                        if (ValorPago >= total)
                        {
                            double Troco = ValorPago - total;
                            MessageBox.Show($"troco: R$ {Troco} \n Muito obrigada, volte sempre", "Trocado");
                        }
                        else
                        {
                            MessageBox.Show("Valor pago insuficiente");
                           
                        }
                    }
                    else
                    {
                        MessageBox.Show("Valor inválido");
                        
                    }
                        break;

            }
         
            txtitem.Items.Clear();
            lblTotal.Text = $"O total do pedido é: {total = 0}";
            total = 0;
            txtNomecliente.Clear();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

            txtlista.Items.Add(new Produtos() { Nome = "Pão de queijo", preco = 3.50 });
            txtlista.Items.Add(new Produtos() { Nome = "Coxinha", preco = 5.00 });
            txtlista.Items.Add(new Produtos() { Nome = "Pastel de carne", preco = 6.00 });
            txtlista.Items.Add(new Produtos() { Nome = "Pastel de queijo", preco = 5.50 });
            txtlista.Items.Add(new Produtos() { Nome = "Suco natural", preco = 4.00 });
            txtlista.Items.Add(new Produtos() { Nome = "Refrigerante", preco = 4.50 });
            txtlista.Items.Add(new Produtos() { Nome = "Hambúrguer simples", preco = 8.00 });
            txtlista.Items.Add(new Produtos() { Nome = "Hambúrguer com queijo", preco = 9.00 });
            txtlista.Items.Add(new Produtos() { Nome = "X-tudo", preco = 12.00 });
            txtlista.Items.Add(new Produtos() { Nome = "Água Mineral", preco = 2.50 });
        }

        private void txtQuantidade_ValueChanged(object sender, EventArgs e)
        {


        }

        class Produtos
        {
            public string Nome { get; set; }
            public double total { set; get; }
            public double preco { set; get; }
            public int quantidade { set; get; }
            public double Total => preco * quantidade;
            public override string ToString()
            {
                if (quantidade > 1)
                {
                    return $"{quantidade} x - {Nome} - R${preco:F2}";
                }
                else
                {
                    return $"{Nome} - R${preco:F2}";
                }
            }
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void lblPagamento(object sender, EventArgs e)
        {

        }

        private void txtbox(object sender, EventArgs e)
        {

        }

        private void cBoxPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
