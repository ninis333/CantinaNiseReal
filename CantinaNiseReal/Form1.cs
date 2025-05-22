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
                int quantidadeSelecionada = (int)txtQuantidade.Value;

                // Verifica se o produto já está na lista de itens
                Produtos produtoNaLista = null;
                foreach (Produtos p in txtitem.Items)
                {
                    if (p.Nome == produtoSelecionado.Nome)
                    {
                        produtoNaLista = p;
                        break;
                    }
                }

                if (produtoNaLista != null)
                {
                    // Se já existe, aumenta a quantidade
                    produtoNaLista.quantidade += quantidadeSelecionada;
                }
                else
                {
                    // Se não existe, cria um novo com a quantidade selecionada
                    Produtos novoProduto = new Produtos()
                    {
                        Nome = produtoSelecionado.Nome,
                        preco = produtoSelecionado.preco,
                        quantidade = quantidadeSelecionada
                    };
                    txtitem.Items.Add(novoProduto);
                }

                AtualizarTotal();
                AtualizarListaProdutos();
            }

        }

        private void txtremover_Click(object sender, EventArgs e)
        {
            if (txtitem.SelectedItem != null)
            {
                Produtos produtoSelecionado = (Produtos)txtitem.SelectedItem;
                int quantidadeSelecionada = (int)txtQuantidade.Value;

                if (quantidadeSelecionada <= produtoSelecionado.quantidade)
                {
                    // Remove a quantidade desejada
                    produtoSelecionado.quantidade -= quantidadeSelecionada;

                    if (produtoSelecionado.quantidade == 0)
                    {
                        txtitem.Items.Remove(produtoSelecionado);
                    }

                    AtualizarTotal();
                    AtualizarListaProdutos();
                }
                else
                {
                    MessageBox.Show("Erro: Você está tentando remover mais itens do que há na lista.", "Quantidade inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AtualizarTotal()
        {
            total = 0;
            foreach (Produtos p in txtitem.Items)
            {
                total += p.Total;  // Usar propriedade calculada Total
            }
            lblTotal.Text = $"Total: R$ {total:F2}";
        }
        private void AtualizarListaProdutos()
        {
            // Atualiza o ListBox para refletir as quantidades e preços atualizados
            var itens = new List<Produtos>();
            foreach (Produtos p in txtitem.Items)
            {
                itens.Add(p);
            }
            txtitem.Items.Clear();
            foreach (Produtos p in itens)
            {
                txtitem.Items.Add(p);
            }
        }
        private void txtfechar_Click(object sender, EventArgs e)
        {
            string cliente = txtNomecliente.Text.Trim();

            if (string.IsNullOrEmpty(cliente))
            {
                MessageBox.Show("Por favor, preencha o nome do cliente para finalizar a compra.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cBoxPagamento.SelectedIndex == 0)
            {
                MessageBox.Show("Por favor, selecione uma forma de pagamento para finalizar a compra.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            cliente = char.ToUpper(cliente[0]) + cliente.Substring(1).ToLower();

            StringBuilder extrato = new StringBuilder();

            foreach (Produtos item in txtitem.Items)
            {
                extrato.AppendLine(item.ToString());
            }

            DateTime datinha = data.Value.Date;
            DateTime horinha = hora.Value;

            string datinhaEhorinha = $"{datinha:dd/MM/yyyy} - {horinha:HH:mm:ss}";

            MessageBox.Show($"Nome do cliente: {cliente} \n" +
                $"O seu Pedido foi: \n{extrato} \n " +
                $"O seu total é: R$ {total:F2} \n" +
                $"{datinhaEhorinha} \n" +
                $"Forma de pagamento: {cBoxPagamento.SelectedItem}", "Comanda");

            if (cBoxPagamento.SelectedIndex == 1)
            {
                string input = Microsoft.VisualBasic.Interaction.InputBox("Valor que será pago: ", "Pagamento");


                if (double.TryParse(input, out double ValorPago))
                {
                    if (ValorPago >= total)
                    {
                        double Troco = ValorPago - total;
                        MessageBox.Show($"Troco: R$ {Troco:F2} \nMuito obrigada, volte sempre!", "Troco");
                    }
                    else
                    {
                        MessageBox.Show("Valor pago insuficiente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Valor inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            else
            {
                MessageBox.Show("O sistema está indisponivel no momento, selecione outra forma de pagamento");
                return;
            }
                txtitem.Items.Clear();
                total = 0;
                lblTotal.Text = "Total: R$ 0,00";
                txtNomecliente.Clear();
                cBoxPagamento.SelectedIndex = 0; // Reseta o comboBox para "Selecione..."
            }




        private void Form1_Load(object sender, EventArgs e)
        {
            txtlista.Items.Add(new Produtos() { Nome = "Pão de queijo", preco = 3.50, ExibirComoCatalogo = true });
            txtlista.Items.Add(new Produtos() { Nome = "Coxinha", preco = 5.00, ExibirComoCatalogo = true });
            txtlista.Items.Add(new Produtos() { Nome = "Pastel de carne", preco = 6.00, ExibirComoCatalogo = true });
            txtlista.Items.Add(new Produtos() { Nome = "Pastel de queijo", preco = 5.50, ExibirComoCatalogo = true });
            txtlista.Items.Add(new Produtos() { Nome = "Suco natural", preco = 4.00, ExibirComoCatalogo = true });
            txtlista.Items.Add(new Produtos() { Nome = "Refrigerante", preco = 4.50, ExibirComoCatalogo = true });
            txtlista.Items.Add(new Produtos() { Nome = "Hambúrguer simples", preco = 8.00, ExibirComoCatalogo = true });
            txtlista.Items.Add(new Produtos() { Nome = "Hambúrguer com queijo", preco = 9.00, ExibirComoCatalogo = true });
            txtlista.Items.Add(new Produtos() { Nome = "X-tudo", preco = 12.00, ExibirComoCatalogo = true });
            txtlista.Items.Add(new Produtos() { Nome = "Água Mineral", preco = 2.50, ExibirComoCatalogo = true });


            // ComboBox de pagamento
            cBoxPagamento.Items.Add("Selecione...");
            cBoxPagamento.Items.Add("Dinheiro");
            cBoxPagamento.Items.Add("Cartão de crédito");
            cBoxPagamento.Items.Add("Cartão de débito");
            cBoxPagamento.Items.Add("PIX");
            cBoxPagamento.SelectedIndex = 0;
        }



        private void txtQuantidade_ValueChanged(object sender, EventArgs e)
        {

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

        private void txtlista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
