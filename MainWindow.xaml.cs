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
using System.Xml.Serialization;

namespace RGB_Színkeverő
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

        private void Slider_Changed(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            RGB.Text = $"RGB({(int)RedSlider.Value}, {(int)GreenSlider.Value}, {(int)BlueSlider.Value})";
            HEX.Text = $"#{((int)RedSlider.Value):X2}{((int)GreenSlider.Value):X2}{((int)BlueSlider.Value):X2}";
            ColorPreview.Fill = new SolidColorBrush(Color.FromRgb((byte)RedSlider.Value, (byte)GreenSlider.Value, (byte)BlueSlider.Value));

            if ((int)RedSlider.Value > 111 && (int)GreenSlider.Value > 111 && (int)BlueSlider.Value > 111)
            {
                PreviewText.Foreground = new SolidColorBrush(Colors.Black);
            }
            else
            {
                PreviewText.Foreground = new SolidColorBrush(Colors.White);
            }

        }
        private void RandomizeButton_Click(object sender, RoutedEventArgs e)
        {
            int Red_rnd = new Random().Next(0, 256);
            int Green_rnd = new Random().Next(0, 256);
            int Blue_rnd = new Random().Next(0, 256);
            if (RedLock.IsChecked == false)
            {
                RedSlider.Value = Red_rnd;
            }
            if (GreenLock.IsChecked == false)
            {
                GreenSlider.Value = Green_rnd;
            }
            if (BlueLock.IsChecked == false)
            {
                BlueSlider.Value = Blue_rnd;
            }
        }

        private void DefaultButton_Click(object sender, RoutedEventArgs e)
        {
            RedSlider.Value = 0;
            GreenSlider.Value = 0;
            BlueSlider.Value = 0;
        }

        private void ClearCanvasButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}