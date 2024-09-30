using Microsoft.Maui.Controls;

namespace tareafunciones
{
    public partial class ResultPage : ContentPage
{
    public ResultPage(string operacion, double resultado)
    {
            InitializeComponent();
            ResultLabel.Text = $"La {operacion} es: {resultado}";
     }
    }
}