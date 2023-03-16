using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace background_color_change
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
        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (textbox.Text == "red")
            {
                this.Background = new SolidColorBrush(Colors.Red);
            }
            else if (textbox.Text == "green")
            {
                this.Background = new SolidColorBrush(Colors.Green);
            }
            else if (textbox.Text == "blue")
            {
                this.Background = new SolidColorBrush(Colors.Blue);
            }
            else if (textbox.Text == "orange")
            {
                this.Background = new SolidColorBrush(Colors.Orange);
            }
            else if (textbox.Text == "violet")
            {
                this.Background = new SolidColorBrush(Colors.Violet);
            }
            else if (textbox.Text == "yellow")
            {
                this.Background = new SolidColorBrush(Colors.Yellow);
            }
            else if (textbox.Text == "indigo")
            {
                this.Background = new SolidColorBrush(Colors.Indigo);
            }
            else
            {
                this.Background = new SolidColorBrush(Colors.White);
            }
        }
    }
}
