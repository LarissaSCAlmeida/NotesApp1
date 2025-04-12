namespace NotesApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OiButton_Clicked(object sender, EventArgs e)
        {
            //Pegar o nome que a pessoa digitou
            //Armazenar o nome em uma variável
            //Escrever o nome que está na variável em uma caixa de texto

            string nome = NomeEntry.Text;
            //NomeLabel.Text = "Oi," + nome;
            NomeLabel.Text = $"Oi, {nome}";
        }
    }
}
