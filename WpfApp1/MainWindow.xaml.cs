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
using System.Xml.Linq;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            this.Background = new SolidColorBrush(Colors.SteelBlue);

            MainMusic.Play();
        }

        private void TextBox_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (sender is TextBox textBox && name.Text == "Name")
            {
                name.Text = string.Empty;
            }
        }

        private void TextBox2_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (sender is TextBox textBox && age.Text == "Age")
            {
                age.Text = string.Empty;
            }
        }
        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            string userName = name.Text;
            string userAge = age.Text;

            if (name.Text.Length > 0 && age.Text.Length > 0 && name.Text != "Name" && age.Text != "Age")
            {
                Window1 window1 = new Window1(userName, userName);
                window1.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("You must write your name and age before starting!");
            }

        }

        private void quitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

        }
    }
}