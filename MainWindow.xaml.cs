using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace Binding
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //dans notre cas, la bonne pratique est d'utiliser un binding oneway (moins gourmand en ressources que le twoway),
        //et dans les fonctions des boutons, de changer la valeur du slider, et non du texte

        private void SetToSmall(object sender, RoutedEventArgs e)
        {
            sliderFontSize.Value = 5.0;
        }

        private void SetToNormal(object sender, RoutedEventArgs e)
        {
            sliderFontSize.Value = 10.0;
        }

        private void SetToLarge(object sender, RoutedEventArgs e)
        {
            sliderFontSize.Value = 60.0;
        }

        private void Valid_Click(object sender, RoutedEventArgs e)
        {
            BindingExpression _binding = lblSampleText.GetBindingExpression(TextBox.TextProperty);
            _binding.UpdateSource();
        }
    }
}
