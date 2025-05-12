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
            txtlista.Items.Add(new Produtos("Coxinha", 5.00));
            txtlista.Items.Add(new Produtos("Pastel", 6.00));
            txtlista.Items.Add(new Produtos("refrigerante", 4.50));
            txtlista.Items.Add(new Produtos("Suco", 3.00));
            txtlista.Items.Add(new Produtos("Brigadeiro", 3.00));
        }

        private void txtlista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
