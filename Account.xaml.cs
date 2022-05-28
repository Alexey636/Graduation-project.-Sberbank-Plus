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

namespace Дипломный_проект.СбербанкПлюс
{
    /// <summary>
    /// Логика взаимодействия для Account.xaml
    /// </summary>
    public partial class Account : Window
    {
        public Account()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void AdvancedSearch_Click(object sender, RoutedEventArgs e) // Создаем кнопку "Расширенный поиск"
        {
            {
                AdvancedSearch advancedSearch = new AdvancedSearch(); // Создаем переход на страницу Расширенный поиск (AdvancedSearch) 
                advancedSearch.Show();
                Hide();
            }
        }

        private void textBoxsearch_MouseDown(object sender, MouseButtonEventArgs e)
        {
           
        }

        private void Window_Mouse_textBoxsearch(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)// Создаем иструмент для кнопки "Сбросить" для окна Account
        {
            textBoxsearch.Clear(); // Очищаем поле "Введите текст или название документа"
           
        }
    }
}
