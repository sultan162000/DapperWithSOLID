using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using DapperWithSOLID.Model;

namespace DapperWithSOLID.Controller
{
    class AddUser<Model> : CreatConnectionDb<Model>
    {
        Students students = null;

        public void Add(Model m)
        {
            if(connection.State == ConnectionState.Open)
            {
                if(m is Students)
                {
                    students = (dynamic)m;
                    connection.Execute($"Insert into Students(FullName,Team,Course) values('{students.FullName}','{students.Team}','{students.Course}')");
                    Console.WriteLine("Студент добавлен в БД");
                }
            }
        }
    }
}
