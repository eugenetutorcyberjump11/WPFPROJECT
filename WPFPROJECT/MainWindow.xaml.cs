using Microsoft.Win32;
using System.Windows.Media;
using System.IO;
using System.Windows;
using System.Windows.Controls;

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

        private void ChangeTextColor_Click(object sender, RoutedEventArgs e)
        {
            string selectedColor = ((ComboBoxItem)colorComboBox.SelectedItem).Content.ToString();
            inputTextBox.Foreground = selectedColor switch
            {
                "Чорний" => Brushes.Black,
                "Червоний" => Brushes.Red,
                "Зелений" => Brushes.Green,
                "Синій" => Brushes.Blue,
                _ => Brushes.Black,
            };
        }

        private void OpenFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                inputTextBox.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }

        private void SaveFileAs_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == true)
            {
                File.WriteAllText(saveFileDialog.FileName, inputTextBox.Text);
            }
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}