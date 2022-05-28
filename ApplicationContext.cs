using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity; // Библиотека для работы с базой данных

// Создаем специальный класс (Context), с помощью которого происходит подключение к базе данных
// С помощью данного класса в дальнейшем сможем вносить информацию, удалять информацию, находить необходимую информацию

namespace Дипломный_проект.СбербанкПлюс
{
    class ApplicationContext: DbContext // Указываем, что создаваемый нами класс будет наследовать от класса DbContext
    {
        public DbSet<User> Users { get; set; } // Создаем поле на основе класса DbSet. От представляет собой список, в нутри которого будут находится элементы из созданной таблицы

        public ApplicationContext() : base("DefaultConnection") { } // Передаем информацию о подключении созданной базы данных из App.config* в родительский конструктор
    }
}
