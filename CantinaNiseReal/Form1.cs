using System.Windows.Forms;
using CantinaNiseReal;

namespace CantinaNiseReal
{
    public partial class Form1 : Form
    {
        List<string> list = new List<string>();
        double total = 0;
        public Form1()
        {
            InitializeComponent();
        }


        private void txtadicionar_Click(object sender, EventArgs e)
        {

            if (txtlista.SelectedItem != null)
            {
                Produtos produtoSelecionado = (Produtos)txtlista.SelectedItem;
                txtlista.SelectedItem = null;
                txtitem.Items.Add(produtoSelecionado);
                total += produtoSelecionado.Preco;
                lblTotal.Text = $"Total: R$ {total:F2}";
            }

        }

        private void txtremover_Click(object sender, EventArgs e)
        {
            if (txtitem.SelectedItem != null)
            {
                Produtos produtoSelecionado = (Produtos)txtitem.SelectedItem;
                txtitem.SelectedItem = null;
                txtitem.Items.Remove(produtoSelecionado);
                total -= produtoSelecionado.Preco;
                lblTotal.Text = $"Total: R$ {total:F2}";

            }
        }



        private void txtfechar_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"O total do pedido é: {total:F2}");
            txtitem.Items.Clear();
            lblTotal.Text = $"O total do pedido é: {total = 0}";
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            txtlista.Items.Add(new Produtos("Pão de queijo", 3.50));
            txtlista.Items.Add(new Produtos("Coxinha", 5.00));
            txtlista.Items.Add(new Produtos("Pastel de carne", 6.00));
            txtlista.Items.Add(new Produtos("Pastel de queijo", 5.50));
            txtlista.Items.Add(new Produtos("Suco natural", 4.00));
            txtlista.Items.Add(new Produtos("Refrigerante", 4.50));
            txtlista.Items.Add(new Produtos("Hambúrguer simples", 8.00));
            txtlista.Items.Add(new Produtos("Hambúrguer com queijo", 9.00));
            txtlista.Items.Add(new Produtos("X-tudo", 12.00));
            txtlista.Items.Add(new Produtos("Água Mineral", 2.50));
        }

        private void txtlista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void quantidade_TextChanged(object sender, EventArgs e)
        {
            if (quantidade.Text == "0")
            {
                MessageBox.Show("Digite outro numero");
                quantidade.Clear();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
