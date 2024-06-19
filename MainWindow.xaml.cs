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

namespace _28._05
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

        private void CalculateSum_Click(object sender, RoutedEventArgs e)
        {
            string input = inputTextBox.Text;
            string[] inputs = input.Split(',');

            double sum = 0;
            foreach (string s in inputs)
            {
                if (double.TryParse(s.Trim(), out double value))
                {
                    sum += value;
                }
                else
                {
                    MessageBox.Show($"Incorrect value: {s}", "ERROR!!!", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
            }

            resultTextBox.Text = sum.ToString("F2");
        }
    }
}