using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace DapperWithSOLID.Controller
{
    class SelectTheUser<Model> : CreatConnectionDb<Model>, ISelectUser<Model>
    {
        public List<Model> SelectAll()
        {
            if (connection.State == ConnectionState.Open) return connection.Query<Model>($"Select * from {typeof(Model).Name}").ToList();
            else
            {
                Console.WriteLine("Соединение закрыто!");
                return null;
            }
        }

        public Model SelectById(int id)
        {
            if (connection.State == ConnectionState.Open) return connection.QueryFirstOrDefault<Model>($"Select * from {typeof(Model).Name} where Id={id}");
            else
            {
                Console.WriteLine("Соединение закрыто!");
                return default(Model);
            }
        }
    }
}
