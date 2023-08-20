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

namespace calculate_project
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

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            int Textbox1 = int.Parse(income.Text);
            int Textbox2 = int.Parse(textbox2.Text);
            int Textbox3 = int.Parse(textbox3.Text);
            int Textbox4 = Textbox3 / ( Textbox1 - Textbox2);
            textbox4.Text = Textbox4.ToString();
        }

        private void textbox4_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
