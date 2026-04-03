using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.User_Personal_Bookshelf
{
    internal interface IUser
    {
        void AddUser();
        void DisplayUsers();
        void AddBooks(string name);
        void SortBooks(string name);
        void SearchBook(string name);
        void DisplayBooks(string name);
        public bool AdminAuth(int passward);
        public string UserAuth(int passward);
    }
}
