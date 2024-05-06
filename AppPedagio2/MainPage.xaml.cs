namespace AppPedagio2
{
    public partial class MainPage : ContentPage
    {
        double total_em_pedgios = 0;
        public MainPage()
        {
            InitializeComponent();
        }

        private void txt_search_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ref_carregando_Refreshing(object sender, EventArgs e)
        {

        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {

        }

        private void ToolbarItem_Clicked_1(object sender, EventArgs e)
        {

        }

        private void ToolbarItem_Clicked_2(object sender, EventArgs e)
        {

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (txt_destino.Text != String.Empty && txt_distancia.Text != String.Empty && txt_origem.Text != String.Empty && txt_preco.Text != String.Empty && txt_rendimento.Text != String.Empty)
            {


                double litros = double.Parse(txt_distancia.Text) / double.Parse(txt_rendimento.Text);

                double total_viagem = litros * double.Parse(txt_preco.Text);
                total_viagem += total_em_pedgios;

                await DisplayAlert("Total em viagem", $"O total da viagem resultou em: {total_viagem.ToString("C")}", "Certo, obrigado(a)!");
            }
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {

            string result = await DisplayPromptAsync("Adicionar pedágio", "Digite o valor da taxa do pedágio!");
            if (result != null)
            {
                double taxa = double.Parse(result);

                total_em_pedgios += taxa;
            }
        }
    }

}
