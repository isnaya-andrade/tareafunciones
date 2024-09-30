using Microsoft.Maui.Controls;

namespace tareafunciones
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnSumar(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Num1Entry.Text) || string.IsNullOrEmpty(Num2Entry.Text))
                return;

            double num1 = Convert.ToDouble(Num1Entry.Text);
            double num2 = Convert.ToDouble(Num2Entry.Text);
            double resultado = num1 + num2;

            await Navigation.PushAsync(new ResultPage("Suma", resultado));
        }

        private async void OnRestar(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Num1Entry.Text) || string.IsNullOrEmpty(Num2Entry.Text))
                return;

            double num1 = Convert.ToDouble(Num1Entry.Text);
            double num2 = Convert.ToDouble(Num2Entry.Text);
            double resultado = num1 - num2;

            await Navigation.PushAsync(new ResultPage("Resta", resultado));
        }

        private async void OnDividir(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Num1Entry.Text) || string.IsNullOrEmpty(Num2Entry.Text))
                return;

            double num1 = Convert.ToDouble(Num1Entry.Text);
            double num2 = Convert.ToDouble(Num2Entry.Text);
            double resultado = num1 / num2;

            await Navigation.PushAsync(new ResultPage("División", resultado));
        }

        private async void OnMultiplicar(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Num1Entry.Text) || string.IsNullOrEmpty(Num2Entry.Text))
                return;

            double num1 = Convert.ToDouble(Num1Entry.Text);
            double num2 = Convert.ToDouble(Num2Entry.Text);
            double resultado = num1 * num2;

            await Navigation.PushAsync(new ResultPage("Multiplicación", resultado));
        }
    }
}
