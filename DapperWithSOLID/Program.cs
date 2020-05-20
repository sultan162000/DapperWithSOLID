using DapperWithSOLID.Controller;
using DapperWithSOLID.Model;
using System;
using System.Collections.Generic;

namespace DapperWithSOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            AddUser<Students> conn = new AddUser<Students>();
            Students newS = new Students() { FullName = "Dilnoza Aminova", Course = 4, Team = 240010135 };
            conn.OpenConnection();
            conn.Add(newS);
            Console.ReadKey();
        }
    }
}
