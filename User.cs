using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Дипломный_проект.СбербанкПлюс
{
    class User // Создаем новый класс модели, который описывает созданную таблицу и в котором описываем поля в созданной таблице SQL (Users)
    {
        private int id { get; set; } // Описываем поля таблицы (id, login, password)

        public string login, password; // Описываем поля таблицы (id, login, password)

        public User() { } // Сщздаем конструктор по-умолчанию

        public User (string login, string password) // Создаем конструктор, с которым в дальнейшем будем взаимодействовать при авторизации пользователей
        {
            this.login = login;
            this.password = password;
        }
    }// Создаем специальный класс (контекст), с помощью которого мы сможем подключиться к созданной нами SQL таблице (Users)
}
