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
using System.Data;
using System.Data.SqlClient;

namespace Дипломный_проект.СбербанкПлюс
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ApplicationContext db;

        public MainWindow()
        {
            InitializeComponent();

            db = new ApplicationContext();
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Close();
        }
        private void MinButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
        private void ToolBar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                DragMove();
            }
        }

        public void Button_Authorization_Click(object sender, RoutedEventArgs e) // Прописываю логику работы кнопки "Войти"            

        {
            string login = textBoxLogin.Text.Trim(); // При нажатии на кнопку "Войти" программа будет получать информацию из поля "Введите логин"
            string password = passBox.Password.Trim(); // При нажатии на кнопку "Войти" программа будет получать информацию из поля "Введите пароль"

            if (login.Length == 0) // Если значение в поле "Введите логин" не содержит символов, то система выводит информационное окно "Введите логин"
            {
                MessageBox.Show("Введите логин"); // Команда вывода информационного окна "Введите логин"
                textBoxLogin.Focus();
                return;
            }
            if (password.Length == 0)
            {
                MessageBox.Show("Введите пароль");
                passBox.Focus();
                return;
            }
            return;
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            textBoxLogin.Clear(); // Очищаем поле "Введите логин"
            passBox.Clear(); // Очищаем поле "Введите пароль"
        }
    }
}
