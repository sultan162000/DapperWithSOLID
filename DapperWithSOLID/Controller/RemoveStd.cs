using Dapper;
using DapperWithSOLID.Model;
using System;

namespace DapperWithSOLID.Controller
{
    class RemoveStd<T> : CreatConnectionDb<T>
    {

        public void Remove(ISelectUser<T> selectUser,int id)
        {

            var usr = selectUser.SelectById(id);
            if (usr == null)
            {
                Console.WriteLine("Студент не сущесвтует в БД.");
            }
            else
            {
                if(connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Execute($"Delete From Students Where Id = {id}");
                    Console.WriteLine("Студент удален из БД.");
                }
                else
                {
                    Console.WriteLine("Соединение закрыто.");
                }
            }
        }
    }
}
