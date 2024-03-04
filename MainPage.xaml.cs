namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button disparador = (Button)sender;

            disparador.IsEnabled = false;

            if (vez == "0")
            {
                disparador.Text = "0";
                vez = "X";

            } else
            {
                disparador.Text="X";
            }

    }
}
}
