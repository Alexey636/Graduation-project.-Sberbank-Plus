using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Дипломный_проект.СбербанкПлюс
{
    class SQL_USER
    {
        private int id { get; set; }

        private string login, password; // ниже создаю площадку, если приму решение, чтобы пользователь сам регистрировался

        //public string Login
        //{
        //    get { return login; }
        //    set { login = value; }
        //}
        //public string Password
        //{
        //    get { return Password; }
        //    set { login = value; }
        //}

        public SQL_USER()
        {

        }
        public SQL_USER (string login, string password)
        {
            this.login = login;
            this.password = password;
        }
    }
}
