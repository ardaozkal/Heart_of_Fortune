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

namespace Heart_of_Fortune
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string heartemoji = "♥";
        List<string> dontmess = new List<string> { " ", ".", "?" , "!"};
        string startstring = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            startstring = textBox.Text;
            for (int i = 0; i < textBox.Text.Length; i++)
            {
                var gotchar = textBox.Text.Substring(i, 1);
                if (!dontmess.Contains(gotchar))
                {
                    textBox.Text = textBox.Text.Replace(gotchar, heartemoji);
                }
            }
            button.IsEnabled = false;
            textBox.IsEnabled = false;
            textBox1.IsEnabled = true;
            button1.IsEnabled = false;
        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
             button1.IsEnabled = (textBox1.Text.Length == 1);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (startstring.Contains(textBox1.Text))
            {
                for (int i = 0; i < textBox.Text.Length -1 ; i++)
                {
                    var startstrchar = startstring.Substring(i, 1);
                    if (startstrchar == textBox1.Text)
                    {
                        textBox.Text = textBox.Text.Substring(0, i) + startstrchar + textBox.Text.Substring(i + 1);
                    }
                }
            }
            textBox1.Text = "";
            textBox1.IsEnabled = false;
        }
    }
}
