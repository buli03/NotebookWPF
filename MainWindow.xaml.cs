using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace notatnik
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

        private void MenuItemNewWindow_Click(object sender, RoutedEventArgs e)
        {
            var n1 = new MainWindow();
            n1.Show();
        }

        private void mainInputField_TextChanged(object sender, TextChangedEventArgs e)
        {
            string str = mainInputField.Text;
            int occur = 0;
            int occur_verbs = 0;
            int x = 0;

            foreach (char letter in str)
            {
                occur++;
            }

            while (x <= str.Length - 1)
            {
                if (str[x] == ' ' || str[x] == '\n' || str[x] == '\t')
                {
                    occur_verbs++;
                }
                x++;
            }

            count_signs.Text = "Ilość znaków: " + occur;
            count_verbs.Text = "Ilość wyrazów: " + occur_verbs;
        }

        private void MenuItemClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void MenuItemOpenFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text file (*.txt)|*.txt";
            if (openFileDialog.ShowDialog() == true)
                mainInputField.Text = File.ReadAllText(openFileDialog.FileName);
        }

        private void MenuItemSaveFileAs_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text file (*.txt)|*.txt";
            if (saveFileDialog.ShowDialog() == true)
                File.WriteAllText(saveFileDialog.FileName, mainInputField.Text);
        }

        private void MenuItemTextWrapping_Click(object sender, RoutedEventArgs e)
        {
            if (mainInputField.TextWrapping == TextWrapping.Wrap)
            {
                mainInputField.TextWrapping = TextWrapping.NoWrap;
                textwrapbutton.IsChecked = false;   
            }
            else
            {
                textwrapbutton.IsChecked = true;   
                mainInputField.TextWrapping = TextWrapping.Wrap;
            }
        }

        private void MenuItemChooseFont_Click(object sender, RoutedEventArgs e)
        {
            var choice = new wybor_czcionki();
            choice.Show();
          
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            mainInputField.FontSize += 5;
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            mainInputField.FontSize -= 5;

        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Radź sobie","Pomoc");
        }
    }
}
