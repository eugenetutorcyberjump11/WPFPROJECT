using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFPROJECT
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text = textBoxInput.Text;
           
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedColor = ((ComboBoxItem)colorComboBox.SelectedItem).Content.ToString();

            switch (selectedColor)
            {
                case "Чорний":
                    txtDisplay.Foreground = Brushes.Black;
                    break;
                case "Червоний":
                    txtDisplay.Foreground = Brushes.Red;
                    break;
                case "Зелений":
                    txtDisplay.Foreground = Brushes.Green;
                    break;
                case "Синій":
                    txtDisplay.Foreground = Brushes.Blue;
                    break;
                default:
                    txtDisplay.Foreground = Brushes.Black;
                    break;
            }
        }
    }
}