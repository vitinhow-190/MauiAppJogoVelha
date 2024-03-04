namespace MauiAppJogoVelha
{
    public partial class MainPage : ContentPage
    {

        String vez = "0"; 

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(Object sender, EventArgs e)
        {
            Button disparador = (Button)sender;

            disparador.IsEnabled = false;

            if (vez == "O")
            {
                disparador.Text = "O";
                vez = "X";
            }
            else
            {
                disparador.Text = "X";
                vez = "O";
            }
        }
    }

}
