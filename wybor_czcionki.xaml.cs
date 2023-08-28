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
using System.Windows.Shapes;

namespace notatnik
{
    /// <summary>
    /// Logika interakcji dla klasy wybor_czcionki.xaml
    /// </summary>
    public partial class wybor_czcionki : Window
    {
        public wybor_czcionki()
        {
            InitializeComponent();
        }

        private void listbox_fonts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listbox_fonts.SelectedIndex == 0 && listbox_fonts.SelectedIndex != -1)
            {
                sampletext.FontFamily = new FontFamily("Cooper");
            }
            else if (listbox_fonts.SelectedIndex == 1 && listbox_fonts.SelectedIndex != -1)
            {
                sampletext.FontFamily = new FontFamily("Arial");
            }
            else if (listbox_fonts.SelectedIndex == 2 && listbox_fonts.SelectedIndex != -1)
            {
                sampletext.FontFamily = new FontFamily("Calibri");
            }
            else if (listbox_fonts.SelectedIndex == 3 && listbox_fonts.SelectedIndex != -1)
            {
                sampletext.FontFamily = new FontFamily("Impact");
            }
            else if (listbox_fonts.SelectedIndex == 4 && listbox_fonts.SelectedIndex != -1)
            {
                sampletext.FontFamily = new FontFamily("Jokerman");
            }

        }

        private void listbox_size_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listbox_size.SelectedIndex == 0 && listbox_size.SelectedIndex != -1)
            {
                sampletext.FontSize = 8;
            }
            else if (listbox_size.SelectedIndex == 1 && listbox_size.SelectedIndex != -1)
            {
                sampletext.FontSize = 12;
            }
            else if (listbox_size.SelectedIndex == 2 && listbox_size.SelectedIndex != -1)
            {
                sampletext.FontSize = 16;
            }
            else if (listbox_size.SelectedIndex == 3 && listbox_size.SelectedIndex != -1)
            {
                sampletext.FontSize = 18;
            }
            else if (listbox_size.SelectedIndex == 4 && listbox_size.SelectedIndex != -1)
            {
                sampletext.FontSize = 22;
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           // ((MainWindow)Application.Current.MainWindow).mainInputField.FontFamily = 
           string selectedFont = ((ListBoxItem)listbox_fonts.SelectedValue).Content.ToString();
           string selectedSize = ((ListBoxItem)listbox_size.SelectedValue).Content.ToString();

            ((MainWindow)Application.Current.MainWindow).mainInputField.FontFamily = new FontFamily(selectedFont);
            ((MainWindow)Application.Current.MainWindow).mainInputField.FontSize = int.Parse(selectedSize);
        }
    }
}
