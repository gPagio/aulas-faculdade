namespace verifica_palindromo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (verificaSeEhPalindromo(EntradaDeTexto.Text.ToString()) == true)
            {
                RetornoVerificacao.Text = "É PALINDROMO";
            }
            else
            {
                RetornoVerificacao.Text = "NÃO É PALINDROMO";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private Boolean verificaSeEhPalindromo(String palavraParaVerificacao)
        {
            return palavraParaVerificacao.ToLower().Equals(new String(palavraParaVerificacao.ToLower().Reverse().ToArray()));
        }
    }
}